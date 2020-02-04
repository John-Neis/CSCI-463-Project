using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MoneyHub
{
    public class ServerConnector
    {
        public void ExecuteClient(string ip, int port, string message)
        {
            string toSend = message;
            // Establish the remote endpoint
            // for the socket. This example
            // uses port 1338 on the router
            // located at 24.220.156.95
            //or
            //Establish the endpoint to the 
            //given ip and port passed to the
            //function.

            //Jack's IP & port configuration
            //byte[] ip = {24, 220, 156, 95};
            //IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 1338);
            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(ip), port);
            try
            {
                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(serverAddress);

                // Sending
                int toSendLen = Encoding.ASCII.GetByteCount(toSend);
                byte[] toSendBytes = Encoding.ASCII.GetBytes(toSend);
                byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
                clientSocket.Send(toSendLenBytes);
                clientSocket.Send(toSendBytes);

                // Receiving
                byte[] rcvLenBytes = new byte[4];
                clientSocket.Receive(rcvLenBytes);
                int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
                byte[] rcvBytes = new byte[rcvLen];
                clientSocket.Receive(rcvBytes);
                String returnMessage= Encoding.ASCII.GetString(rcvBytes);

                Console.WriteLine("Client received: " + returnMessage);

                clientSocket.Close();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Argument null exception : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("Socket exception : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
        }
    }
}
