package mainModule;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.SQLException;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.IOException;

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

	public static void main(String[] args) {
		
		ResultSet rs = null;
		Connection dbh = null;
		ServerSocket server = null;
		
		String clientResponse = "";
		String SQLResult = "";
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
					"pass260word"
			);			
		} catch(Exception e) {
			e.printStackTrace();
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
				System.out.println("Server listening at: " + server.getInetAddress() + " on port " + server.getLocalPort());
				
				Socket client = server.accept();
				System.out.println("Connection established");
				
				PrintWriter output = new PrintWriter(client.getOutputStream(), true);
				BufferedReader input = new BufferedReader(new InputStreamReader(client.getInputStream()));
				
				while((clientResponse = input.readLine()) != null) {
					
					System.out.println(clientResponse);
					String sql = "select * from user;";
					int resultCount = -1;
					
					try {
						rs = query(dbh, sql);
						while(rs.next()) {
							SQLResult += String.format("UserID %d\tAcctNum %d\tPwd %s\tf_name %s\tl_name %s\n", 
									rs.getInt("UserID"), rs.getInt("AccountNumber"), rs.getString("Password"),
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
					output.println(resultCount);
					output.println(SQLResult);
					
				}
				
			} catch(IOException e) {
				System.out.println("Exception caught when trying to listen on port " + portNumber + " or listening for a connection");
				System.out.println(e.getMessage());
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