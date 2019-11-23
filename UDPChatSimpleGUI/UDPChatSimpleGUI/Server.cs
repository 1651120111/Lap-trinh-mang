using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChatSimpleGUI
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        //Khai bao 2 sockets
        Socket sckServer;
        byte[] data = new byte[1024];
        private void butKhoitao_Click(object sender, EventArgs e)
        {
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //Gan ket socket den cong - Bind
            EndPoint localEP = new IPEndPoint(IPAddress.Any, 12345);
            sckServer.Bind(localEP);
           
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            lbTrangThai.Invoke(new CapNhatGiaoDien(CapNhatTrangThai), new object[] { "Dang cho ket noi..." });
            
            sckServer.BeginReceiveFrom(data, 0, 1024, SocketFlags.None, ref remoteEP, new AsyncCallback(xulydulieunhanduoc), null);

        }
        private void xulydulieunhanduoc(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            EndPoint ep = new IPEndPoint(IPAddress.Any, 0);
            int size = s.EndReceiveFrom(ar,ref ep);
            String thongdiep = Encoding.ASCII.GetString(data, 0, size);
            txtNoidungChat.Invoke(new CapNhatGiaoDien(CapNhatNoiDungChat), new object[] { "Client: " + thongdiep });
           
        }


        delegate void CapNhatGiaoDien(string s);
        private void CapNhatTrangThai(string s)
        {
            lbTrangThai.Text = s;
        }
        void CapNhatNoiDungChat(string s)
        {
            txtNoidungChat.Text += s + "\r\n";
        }

        private void butGui_Click(object sender, EventArgs e)
        {
            sckServer.BeginSend(Encoding.ASCII.GetBytes(txtThongdiep.Text), 0, txtThongdiep.Text.Length, SocketFlags.None, new AsyncCallback(OnDataSent), null);
            CapNhatNoiDungChat("Server: " + txtNoidungChat.Text);
            txtThongdiep.Text = "";
        }


        private void OnDataSent(IAsyncResult ar)
        {
            sckServer.EndSend(ar);
        }
    }
}
