package mainModule;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.SQLIntegrityConstraintViolationException;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.IOException;
import java.sql.SQLIntegrityConstraintViolationException;
import java.net.Socket;
import java.net.ServerSocket;

public class ServerDriver {
	
	public static ResultSet query(Connection dbh, String sql) {
		try {
			Statement stmnt = dbh.createStatement();
			return stmnt.executeQuery(sql);
		} catch(SQLException e) {
			e.printStackTrace();
		}
		return null;
	}

	public static void insertUserData(String[] data, Connection dbh, PrintWriter output) {
		String sql = "insert into users values(NULL, '" + data[1] + "', '" + data[2] + "', '" + data[3] + "', '" + data[4] + "');";
		System.out.println("SQL CMD: "+sql);
		//boolean result = false;
		String reply;
		try {
			Statement stmnt = dbh.createStatement();
			//result = 
			stmnt.execute(sql);
			//System.out.println(result);
		    //check result from attempt to add user to database
		    // if(result == true){
				reply = "1:NULL";
				System.out.println("SERVER: Response to Client:" + reply);
				output.println(reply);
			// }
			// else if(result == false);
			// {
			// 	reply = "0:NULL";	
			// 	System.out.println("SERVER: Response to Client(failed):" + reply);
			// 	output.println(reply);
			// }
		}
		catch(SQLIntegrityConstraintViolationException e){
			System.out.println("SQL: ERROR ACCOUNT MAY ALREADY EXIST");
			e.printStackTrace();
		}
		 catch(SQLException e) {
			System.out.println("SQL: OTHER SQL ERROR");
			e.printStackTrace();
			reply = "0:NULL";	
			System.out.println("SERVER: Response to Client:" + reply);
			output.println(reply);
		}
	}

	public static void userLogin(String[] data, Connection dbh, ResultSet rs, PrintWriter output) {
		String SQLResult = "";
		String user = data[1];
		String pwd = data[2];

		System.out.println("Client user: " + user);
		System.out.println("Client pwd:  " + pwd);

		String sql = "select * from users where UserName = '" + user + "' and Password = '" + pwd +"';";
		System.out.println("SQL CMD: "+ sql);
		int resultCount = -1;
					
		try {
			rs = query(dbh, sql);
			while(rs.next()) {
				SQLResult += String.format("UserID: %d -- UserName: %s -- Pwd: %s -- f_name: %s -- l_name: %s\n", 
						rs.getInt("UserID"), rs.getString("UserName"), rs.getString("Password"),
						rs.getString("FirstName"), rs.getString("LastName")
				);
			}
			
			rs.last();
			resultCount = rs.getRow();
		
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println("Record count: " + resultCount);
		System.out.println(SQLResult);
		String reply = "";
		if(resultCount == 0) {
			reply = "0:NULL";
			output.println(reply);
			return;
		}
		reply += resultCount + ":";

		sql = "select * from accounts where UserName = '" + user + "';";
		try {
			rs = query(dbh, sql);
			while(rs.next()) {
				reply += "UserName->" + rs.getString("UserName") + ":";
				reply += "Type->" + rs.getString("Type") + ":";
				reply += "Balance->" + rs.getFloat("Balance") + ":";
			}
		} catch(SQLException e) {
			e.printStackTrace();
		}
		reply += "NULL";

		System.out.println("To Client: " + reply);
		output.println(reply);
		reply = "";
		//output.print(SQLResult);
		//output.flush();
	}

	public static void main(String[] args) {
		
		ResultSet rs = null;
		Connection dbh = null;
		ServerSocket server = null;
		
		String clientResponse = "";
		
		final int portNumber = 1338;
		/*************************************************************************************************/
		/*                                    Establish MySQL connection                                 */
		/*************************************************************************************************/
		
		System.out.println("Welcome to MySQL Java Server");
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			dbh = DriverManager.getConnection(
					"jdbc:mysql://localhost:3306/bank", //?useSSL=false&autoReconnect=true",
					"root",
					//"Magichawk17%"
					"pass260word"
			);			
		}
		 catch(Exception e) {
			e.printStackTrace();
			System.exit(1);
		}
		System.out.println("MySQL Server connected successfully\n");
		
		/*************************************************************************************************/
		/*                                 End Establish MySQL connection                                */
		/*************************************************************************************************/
		
		/*************************************************************************************************/
		/*                                       Establish server socket                                 */
		/*************************************************************************************************/
		

			try {
				
				server = new ServerSocket(portNumber);
				while(true) {
					
					System.out.println("Server listening at: " + server.getInetAddress() + " on port " + server.getLocalPort());
				
					Socket client = server.accept();
					System.out.println("Connection established");
				
					PrintWriter output = new PrintWriter(client.getOutputStream(), true);
					BufferedReader input = new BufferedReader(new InputStreamReader(client.getInputStream()));
				
					while(true) {
						clientResponse = input.readLine();

						if(clientResponse == null) {
							System.out.println("Client Disconnected");
							break;
						}

						System.out.println("Client: " + clientResponse);

						if(clientResponse.equalsIgnoreCase("<--quit--> ")) {
							output.println("Server: 1");
							output.println("Server: You've initiated remote shutdown of server. Goodbye.");
							System.out.println("Server: Shutting down...");
							break;
						}

						if(clientResponse.split("\\s")[0].equals("0"))
						{
							String[] createRecord = clientResponse.split("\\s");
							insertUserData(createRecord, dbh, output);
						}
						 else if(clientResponse.split("\\s")[0].equals("1"))
						{
							String[] login = clientResponse.split("\\s");
							userLogin(login, dbh, rs, output);
						}
						
						//break;
					}
				}
				
			} catch(IOException e) {
				System.out.println("Exception caught when trying to listen on port " + portNumber + " or listening for a connection");
				System.out.println(e.getMessage());
				System.out.println("Please be aware, catastrophic error may not have occurred. This may be a normal shut down. Terminating...");
			}
		
		
		/*************************************************************************************************/
		/*                                   End Establish server socket                                 */
		/*************************************************************************************************/
		
		/*************************************************************************************************/
		/*                                 Close Socket and DB connection                                */
		/*************************************************************************************************/
		try {
			server.close();
			dbh.close();
		} catch(IOException ie) {
			ie.printStackTrace();
		} catch(SQLException sqle) {
			sqle.printStackTrace();
		}
	}
}
