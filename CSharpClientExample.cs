using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DatabaseInterfaceClient
{
    class CSharpClientExample
    {
        static void Main(string[] args)
        {
            ExecuteClient();
        }

        static void ExecuteClient()
        {
            try
            {
                // Establish the remote endpoint
                // for the socket. This example
                // uses port 1338 on the router
				// located at 24.220.156.95
                
                byte[] ip = {24, 220, 156, 95};
                IPAddress ipAddr = new IPAddress(ip);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 1338);
                Console.WriteLine(localEndPoint.Address);

                // Creation TCP/IP Socket using
                // Socket Class Constructor
                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    // Connect Socket to the remote
                    // endpoint using method Connect()
                    sender.Connect(localEndPoint);

                    // We print EndPoint information
                    // that we are connected
                    Console.WriteLine("Socket connected to -> {0}", sender.RemoteEndPoint.ToString());

                    // Creation of message that
                    // we will send to Server
                    byte[] messageSent = Encoding.ASCII.GetBytes("12");
                    int byteSent = sender.Send(messageSent);

                    // Data buffer
                    byte[] messageReceived = new byte[1024];

                    // We receive the message using
                    // the method Receive(). This
                    // method returns number of bytes
                    // received, that we'll use to
                    // convert them to string
                    int byteRecv = sender.Receive(messageReceived);
                    Console.WriteLine("Message from Server -> {0}", Encoding.ASCII.GetString(messageReceived, 0, byteRecv));

                    // Close Socket using
                    // the method Close()
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch(ArgumentNullException ane)
                {
                    Console.WriteLine("Argument null exception : {0}", ane.ToString());
                } catch(SocketException se)
                {
                    Console.WriteLine("Socket exception : {0}", se.ToString());
                } catch(Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
