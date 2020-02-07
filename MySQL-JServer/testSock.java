import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.IOException;

import java.net.Socket;

public class testSock {
	public static void main(String[] args) {
		Socket server = null;
		try {
			server = new Socket("localhost", 1338);
			System.out.println("Connection Established");

			PrintWriter output = new PrintWriter(server.getOutputStream(), true);
			BufferedReader input = new BufferedReader(new InputStreamReader(server.getInputStream()));
			BufferedReader STDIN = new BufferedReader(new InputStreamReader(System.in));

			String userInput;
			while((userInput = STDIN.readLine()) != null) {
				output.println("Client: " + userInput);
				String servermsg = input.readLine();
				System.out.println("Server: " + servermsg);
				int cnt = Integer.parseInt(servermsg);
				for(int i = 0; i < cnt; i++) {
					System.out.println("Server: " + input.readLine());
				}
			}
		} catch(IOException e) {
			e.printStackTrace();
		}
	}
}
