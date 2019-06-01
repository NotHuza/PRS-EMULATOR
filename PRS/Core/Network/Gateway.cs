using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Royale2Sharp.Core.Settings;
using Royale2Sharp.Packets;
using Royale2Sharp.Packets.Crypto.RC4;

namespace Royale2Sharp.Core.Network
{
    // State object for reading client data asynchronously
    public class StateObject
    {
        // Size of receive buffer.
        public const int BufferSize = 4096;

        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client  socket.
        public Socket workSocket;
    }

    public class AsynchronousSocketListener
    {
        // Thread signal.
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public static void StartListening()
        {
            // Data buffer for incoming data.
            var bytes = new byte[1024];

            // Establish the local endpoint for the socket.
            // The DNS name of the computer
            // running the listener is "host.contoso.com".
            var ipHostInfo = Dns.Resolve(Dns.GetHostName());
            var ipAddress = ipHostInfo.AddressList[0];
            var localEndPoint = new IPEndPoint(ipAddress, 9339);

            // Create a TCP/IP socket.
            var listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);
                Program.elpst.Stop();
                Logger.Log($"HuzaModz Royale Server Started at {listener.LocalEndPoint} in {Program.elpst.ElapsedMilliseconds}ms!",
                    Logger.DefCon.INFO);
                while (true)
                {
                    // Set the event to nonsignaled state.
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.

                    listener.BeginAccept(
                        AcceptCallback,
                        listener);

                    // Wait until a connection is made before continuing.
                    allDone.WaitOne();
                    Message.RC4 = new RC4_Core();
                    Logger.Log($"Someone Connected YAY!", Logger.DefCon.INFO);
                    Constants.ServerConfig.ConnectedUsers++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();

            // Get the socket that handles the client request.
            var listener = (Socket) ar.AsyncState;
            var handler = listener.EndAccept(ar);

            // Create the state object.
            var state = new StateObject();
            state.workSocket = handler;
            state.buffer = new byte[9999];
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                ReadCallback, state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            var state = (StateObject) ar.AsyncState;
            var handler = state.workSocket;

            try
            {
                var bytesRead = handler.EndReceive(ar);

                if (bytesRead > 0)
                    if (handler.Connected)
                    {
                        new Message(handler, state.buffer);
                        state.buffer = new byte[9999];
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            ReadCallback, state);
                    }
                    else
                    {
                        Logger.Log($"Asshole {handler.RemoteEndPoint} disconnected from the server!",
                            Logger.DefCon.WARN);
                    }
                else
                    Logger.Log($"Asshole {handler.RemoteEndPoint} disconnected from the server!", Logger.DefCon.WARN);
            }
            catch (Exception e)
            {
                Logger.Log("We threw an exception receiving the data from the client : " + e.Message,
                    Logger.DefCon.ERROR);
            }
        }

        private static void Send(Socket handler, byte[] packet)
        {
            handler.BeginSend(packet, 0, packet.Length, 0,
                SendCallback, handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                var handler = (Socket) ar.AsyncState;

                // Complete sending the data to the remote device.
                var bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}