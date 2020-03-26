using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace webServer
{

    class Program
    {
        static void Main(string[] args)
        {


            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 80);

            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);


                while (true)
                {
                    Console.WriteLine("Connection port {0}", ipEndPoint);

                    Socket handler = sListener.Accept();
                    string data = null;

                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);

                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);


                    string reply = "<html><p><h1>Hello from web server!</h1></p></html>";
                    byte[] msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);

                   

                    if (data.IndexOf("<End>") > -1)
                    {
                        Console.WriteLine("The server has completed a connection.");
                        break;
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}

