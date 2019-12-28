using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket sck;
        EndPoint remoteEP;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Tao socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //Gui message dau tien den Server
            remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            //sck.SendTo(Encoding.ASCII.GetBytes("Hello Server"), remoteEP);
        }
        int n;
        byte[] data = new byte[1024];
        private void keo_Click(object sender, EventArgs e)
        {
            try
            {
                sck.SendTo(Encoding.ASCII.GetBytes("Hello Server"), remoteEP);

                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\img\\0.png");
                sck.SendTo(Encoding.ASCII.GetBytes("0"), remoteEP);
                n = sck.ReceiveFrom(data, ref remoteEP);
                string serverSend = Encoding.ASCII.GetString(data, 0, n);
                if(serverSend == "0")
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\0.png");
                else if(serverSend == "1")
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\1.png");
                else
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\2.png");
                n = sck.ReceiveFrom(data, ref remoteEP);
                string kq = Encoding.ASCII.GetString(data, 0, n);

                ketqua.Text = kq;
            }
            catch(Exception)
            {
                MessageBox.Show("Chua co Server!!!");
            }
        }

        private void bua_Click(object sender, EventArgs e)
        {
            try
            {
                sck.SendTo(Encoding.ASCII.GetBytes("Hello Server"), remoteEP);

                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\img\\1.png");
                sck.SendTo(Encoding.ASCII.GetBytes("1"), remoteEP);
                n = sck.ReceiveFrom(data, ref remoteEP);
                string serverSend = Encoding.ASCII.GetString(data, 0, n);
                if (serverSend == "0")
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\0.png");
                else if (serverSend == "1")
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\1.png");
                else
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\2.png");
                n = sck.ReceiveFrom(data, ref remoteEP);
                string kq = Encoding.ASCII.GetString(data, 0, n);

                ketqua.Text = kq;
            }
            catch (Exception)
            {
                MessageBox.Show("Chua co Server!!!");
            }
        }

        private void bao_Click(object sender, EventArgs e)
        {
            try
            {
                sck.SendTo(Encoding.ASCII.GetBytes("Hello Server"), remoteEP);

                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\img\\2.png");
                sck.SendTo(Encoding.ASCII.GetBytes("2"), remoteEP);
                n = sck.ReceiveFrom(data, ref remoteEP);
                string serverSend = Encoding.ASCII.GetString(data, 0, n);
                if (serverSend == "0")
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\0.png");
                else if (serverSend == "1")
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\1.png");
                else
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\img\\2.png");
                n = sck.ReceiveFrom(data, ref remoteEP);
                string kq = Encoding.ASCII.GetString(data, 0, n);

                ketqua.Text = kq;
            }
            catch (Exception)
            {
                MessageBox.Show("Chua co Server!!!");
            }
        }
    }
}
