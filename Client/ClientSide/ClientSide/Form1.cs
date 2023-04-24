using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string choice = "";

        public void send()
        {
            UdpClient s = new UdpClient("192.168.0.112", 1120);

            byte[] data = Encoding.ASCII.GetBytes(choice);
            s.Send(data, data.Length);
        }

        private void b_rock_Click(object sender, EventArgs e)
        {
            choice = "0";
            label1.Text = "Rock";
        }

        private void b_paper_Click(object sender, EventArgs e)
        {
            choice = "1";
            label1.Text = "Paper";
        }

        private void b_scissor_Click(object sender, EventArgs e)
        {
            choice = "2";
            label1.Text = "Scissor";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread n = new Thread(send);
            n.Start();
        }
    }
}
