using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string[] ips = "112".Split(',');
            label1.Text = "Empty";

            users.Add("192.168.0." + ips[0]);
            Console.WriteLine(users[0]);
            Thread n = new Thread(() => read(0, Convert.ToInt32(ips[0])));   //creates thread for individual to read data from
            n.Start();

            Thread comparision = new Thread(compare);
            comparision.Start();

            Thread w = new Thread(wait);
            w.Start();
        }

        List<string> users = new List<string>();
        int opdecision = -1;
        int mydecision = -1;
        bool myturn = true;
        bool opturn = true;
        public int globalport = 11000;

        private void b_rock_Click(object sender, EventArgs e)
        {
            if (myturn)
            {
                mydecision = 0;
                Thread n = new Thread(mymove);
                n.Start();
                myturn = false;
            }
        }

        private void b_paper_Click(object sender, EventArgs e)
        {
            if (myturn)
            {
                mydecision = 1;
                Thread n = new Thread(mymove);
                n.Start();
                myturn = false;
            }
        }

        private void b_scissor_Click(object sender, EventArgs e)
        {
            if (myturn)
            {
                mydecision = 2;
                Thread n = new Thread(mymove);
                n.Start();
                myturn = false;
            }
        }

        public void mymove()
        {
            myupdate();
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

        public void read(int id, int ipp)
        {
            using (UdpClient listener = new UdpClient(ipp * 10))
            {
                Console.WriteLine(ipp * 10);
                while (true)                    // ERROR here because as soon as a new value is mydecisioncount is increased it runs auto matically
                {
                    if(opturn)
                    {
                        IPEndPoint listenEndPoint = new IPEndPoint(IPAddress.Parse(users[id]), ipp * 10);
                        opdecision = Convert.ToInt32(Encoding.ASCII.GetString(listener.Receive(ref listenEndPoint)));     //listinng to moves: Rock, Paper, Scissors from client.

                        if(opturn && (opdecision == 0 || opdecision == 1 || opdecision == 2))
                        {
                            Console.WriteLine("Opp Decision: " + Convert.ToString(opdecision));
                            opturn = false;
                            move();
                        }
                    }
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
                else if (mydecision == -1 && opdecision != -1)
                {
                    label3.Text = "Please Choose";
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
                    myturn = true;
                    opturn = true;
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
                    label3.Text = "Opponent Win!";
                }
                else if (label1.Text == "Scissor" && label2.Text == "Paper")
                {
                    label3.Text = "Opponent Win!";
                }
                else if (label1.Text == "Rock" && label2.Text == "Scissor")
                {
                    label3.Text = "Opponent Win!";
                }
                else if (label2.Text == "Paper" && label1.Text == "Rock")
                {
                    label3.Text = "You Win!";
                }
                else if (label2.Text == "Scissor" && label1.Text == "Paper")
                {
                    label3.Text = "You Win!";
                }
                else if (label2.Text == "Rock" && label1.Text == "Scissor")
                {
                    label3.Text = "You Win!";
                }
                else if (label2.Text == "Rock" && label1.Text == "Rock")
                {
                    label3.Text = "Its a Draw!";
                }
                else if (label2.Text == "Scissor" && label1.Text == "Scissor")
                {
                    label3.Text = "Its a Draw!";
                }
                else if (label2.Text == "Paper" && label1.Text == "Paper")
                {
                    label3.Text = "Its a Draw!";
                }
            }
        }
    }
}
