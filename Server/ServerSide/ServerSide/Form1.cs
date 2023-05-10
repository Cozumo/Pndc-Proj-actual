using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSide
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            b_rock.Text = "\U000026F0";
            b_paper.Text = "\U0001F4C3";
            b_scissor.Text = "\U00002702";
        }

        private void Form1_Load_1(object sender, EventArgs e)       //Gameloop
        {
            Thread listningFrom = new Thread(() => read());
            listningFrom.Start();

            Thread n = new Thread(mymove);
            n.Start();

            Thread comparision = new Thread(compare);
            comparision.Start();

            Thread w = new Thread(wait);
            w.Start();
        }


        public string ip = ("192.168.0.112");
        int opdecision = -1;
        int mydecision = -1;


        private void b_rock_Click(object sender, EventArgs e)
        {
            if (mydecision == -1)
            {
                mydecision = 0;
            }
        }

        private void b_paper_Click(object sender, EventArgs e)
        {
            if (mydecision == -1)
            {
                mydecision = 1;
            }
        }

        private void b_scissor_Click(object sender, EventArgs e)
        {
            if (mydecision == -1)
            {
                mydecision = 2;
            }
        }

        public void mymove()
        {
            while (true)
            {
                if(mydecision != -1)
                {
                    myupdate();
                }
            }
        }

        private void myupdate()
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new MethodInvoker(myupdate));
            }
            else
            {
                if (mydecision == 0)
                {
                    label2.Text = "Rock";
                }
                else if (mydecision == 1)
                {
                    label2.Text = "Paper";
                }
                else if (mydecision == 2)
                {
                    label2.Text = "Scissor";
                }
            }
        }

        public void read()
        {
            IPEndPoint listenEndPoint = new IPEndPoint(IPAddress.Parse(ip), 8000);
            TcpListener listner = new TcpListener(listenEndPoint);
            listner.Start();
            TcpClient cl = listner.AcceptTcpClient();
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter wr = new StreamWriter(cl.GetStream());

            while (true)                    // ERROR here because as soon as a new value is mydecisioncount is increased it runs auto matically
            {
                if(opdecision == -1)
                {
                    opdecision = Convert.ToInt32(sr.ReadLine());
                    Console.WriteLine(opdecision + " THis is opponent selection");
                    if(opdecision != -1)
                        move();
                }
            }
        }

        public void send(int id)
        {
            // write send code here for updating screen on user screens with broadcast

        }

        //===================================Opponents Move===========================

        public void move()
        {
            update();
        }

        public void update()
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new MethodInvoker(update));

            }
            else
            {
                if (opdecision == 0)
                {
                    label1.Text = "Rock";
                }
                else if (opdecision == 1)
                {
                    label1.Text = "Paper";
                }
                else if (opdecision == 2)
                {
                    label1.Text = "Scissor";
                }
            }
        }

        //===================================Wait Message loop===========================

        public void wait()
        {
            while (true)
            {
                waitUpdate();
            }
        }

        public void waitUpdate()
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new MethodInvoker(waitUpdate));
            }
            else
            {
                if (mydecision != -1 && opdecision == -1)
                {
                    label3.Text = "Waiting for Opponent's Turn";
                }
            }
        }

        //===================================Comparision Loop===========================

        public void compare()
        {
            while (true)
            {
                if(mydecision != -1 && opdecision != -1)
                {
                    compareUpdate();
                    mydecision = -1;
                    opdecision = -1;
                }
            }
        }

        public void compareUpdate()
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new MethodInvoker(compareUpdate));

            }
            else
            {
                if (label1.Text == "Paper" && label2.Text == "Rock")
                {
                    label3.Text = "Opponent Win! \nPlease Choose";
                }
                else if (label1.Text == "Scissor" && label2.Text == "Paper")
                {
                    label3.Text = "Opponent Win! \nPlease Choose";
                }
                else if (label1.Text == "Rock" && label2.Text == "Scissor")
                {
                    label3.Text = "Opponent Win! \nPlease Choose";
                }
                else if (label2.Text == "Paper" && label1.Text == "Rock")
                {
                    label3.Text = "You Win! \nPlease Choose";
                }
                else if (label2.Text == "Scissor" && label1.Text == "Paper")
                {
                    label3.Text = "You Win! \nPlease Choose";
                }
                else if (label2.Text == "Rock" && label1.Text == "Scissor")
                {
                    label3.Text = "You Win! \nPlease Choose";
                }
                else if (label2.Text == "Rock" && label1.Text == "Rock")
                {
                    label3.Text = "Its a Draw! \nPlease Choose";
                }
                else if (label2.Text == "Scissor" && label1.Text == "Scissor")
                {
                    label3.Text = "Its a Draw! \nPlease Choose";
                }
                else if (label2.Text == "Paper" && label1.Text == "Paper")
                {
                    label3.Text = "Its a Draw! \nPlease Choose";
                }
            }
        }
    }
}
