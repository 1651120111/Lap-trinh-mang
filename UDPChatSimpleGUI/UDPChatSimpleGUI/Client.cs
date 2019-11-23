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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Socket sckClient;
        byte[] data = new byte[1024];
        private void butKetnoi_Click(object sender, EventArgs e)
        {
            //tao socket
            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //connect
            byte[] buff = Encoding.ASCII.GetBytes("Xin chao ban!");
            EndPoint ep  = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), (int)numServerPort.Value);
            lbTrangThai.Invoke(new CapNhatGiaoDien(CapNhatTrangThai), new object[] { "Ket noi thanh cong." });
         
            sckClient.BeginSendTo(buff, 0,buff.Length, SocketFlags.None, ep, new AsyncCallback(xulydulieuguidi), null);
        }

        private void CapNhatTrangThai(string s)
        {
            lbTrangThai.Text = s;
        }

        private void xulydulieuguidi(IAsyncResult ar)
        {
            Socket sck = (Socket)ar.AsyncState;
            int size = sck.EndSendTo(ar);

            String thongdiep = Encoding.ASCII.GetString(data, 0, size);
            txtNoidungChat.Invoke(new CapNhatGiaoDien(CapNhatNoiDungChat), new object[] { "Server: " + thongdiep });
        }

        private void CapNhatNoiDungChat(string s)
        {
            txtNoidungChat.Text += s + "\r\n";
        }

        delegate void CapNhatGiaoDien(string s);
    }
}
