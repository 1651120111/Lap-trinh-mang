using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tao socket
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //Gan ket socket den cong - Bind
            EndPoint localEP = new IPEndPoint(IPAddress.Any, 12345);
            sck.Bind(localEP);

            Random rd = new Random();
            byte[] data = new byte[1024];
            int n;
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            Console.WriteLine("Server da san sang nhan yeu cau...");
            //n = sck.ReceiveFrom(data, ref remoteEP);
            //Console.WriteLine("Nhan duoc yeu cau tu Client " + remoteEP.ToString());
            while (true)
            {
                //Nhan yeu cau tu Client
                n = sck.ReceiveFrom(data, ref remoteEP);
                Console.WriteLine("Nhan duoc yeu cau tu Client " + remoteEP.ToString());
                //Nhan lua chon cua Client
                n = sck.ReceiveFrom(data, ref remoteEP);
                string clientSend = Encoding.ASCII.GetString(data, 0, n);
                string clientSend1 = "";
                switch (clientSend)
                {
                    case "0":
                        clientSend1 = "keo";
                        break;
                    case "1":
                        clientSend1 = "bua";
                        break;
                    case "2":
                        clientSend1 = "bao";
                        break;
                }
                Console.Write("Client: " + clientSend1);
                //Gui lua chon cua Server ve Client
                string selectServer = rd.Next(0, 3).ToString();
                sck.SendTo(Encoding.ASCII.GetBytes(selectServer), remoteEP);
                string selectServer1 = "";
                switch (selectServer)
                {
                    case "0":
                        selectServer1 = "keo";
                        break;
                    case "1":
                        selectServer1 = "bua";
                        break;
                    case "2":
                        selectServer1 = "bao";
                        break;
                }
                Console.WriteLine(" Server: " + selectServer1);

                //Xu ly ket qua va gui ve cho Client
                if (selectServer == clientSend)
                {
                    sck.SendTo(Encoding.ASCII.GetBytes("EQUAL"), remoteEP);
                }
                else
                { if (selectServer == "0")
                    {
                        if(clientSend == "1")
                            sck.SendTo(Encoding.ASCII.GetBytes("YOU WIN"), remoteEP);
                        else
                            sck.SendTo(Encoding.ASCII.GetBytes("YOU LOSE!!!"), remoteEP);
                    }
                    else if (selectServer=="1")
                    {
                        if (clientSend == "2")
                            sck.SendTo(Encoding.ASCII.GetBytes("YOU WIN"), remoteEP);
                        else
                            sck.SendTo(Encoding.ASCII.GetBytes("YOU LOSE!!!"), remoteEP);
                    }
                    else
                    {
                        if (clientSend == "0")
                            sck.SendTo(Encoding.ASCII.GetBytes("YOU WIN"), remoteEP);
                        else
                            sck.SendTo(Encoding.ASCII.GetBytes("YOU LOSE!!!"), remoteEP);
                    }

                }
                
            }
        }
    }
}
