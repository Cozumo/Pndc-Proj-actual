using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        TcpClient cl = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            cl = new TcpClient("192.168.0.112", 8000);
        }

        public void send()
        {
            StreamWriter wr = new StreamWriter(cl.GetStream());
            StreamReader sr = new StreamReader(cl.GetStream());

            string data = choice;
            wr.WriteLine(data);
            wr.Flush();
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
