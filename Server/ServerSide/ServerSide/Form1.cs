using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSide
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            b_rock.Text = "\U000026F0";
            b_paper.Text = "\U0001F4C3";
            b_scissor.Text = "\U00002702";
            opscore_label.Text = opscore.ToString();
            myscore_label.Text = myscore.ToString();
            b_rock.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, b_rock.Width, b_rock.Height, 30, 30));
            b_paper.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, b_paper.Width, b_paper.Height, 30, 30));
            b_scissor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, b_scissor.Width, b_rock.Height, 30, 30));
            b_confirm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, b_confirm.Width, b_confirm.Height, 30, 30));
            pictureBox1.SendToBack();
        }

        private void Form1_Load_1(object sender, EventArgs e)       //Gameloop
        {
            try
            {
                Thread listningFrom = new Thread(read);
                listningFrom.Start();

                Thread comparision = new Thread(compare);
                comparision.Start();

                Thread w = new Thread(wait);
                w.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reading From Opponent Stopped!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool myturn = true;
        TcpListener listner = null;
        TcpClient cl = null;
        public string ip = ("192.168.0.112");
        int opdecision = -1;
        int mydecision = -1;
        int myscore = 0;
        int opscore = 0;


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

        private void b_confirm_Click(object sender, EventArgs e)
        {
            Thread n = new Thread(mymove);
            n.Start();
        }

        public void mymove()
        {
            if(mydecision != -1 && myturn == true)
            {
                myupdate();
                myturn = false;

                StreamWriter wr = new StreamWriter(cl.GetStream());
                wr.WriteLine(mydecision);
                wr.Flush();
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
            listner = new TcpListener(listenEndPoint);
            listner.Start();
            cl = listner.AcceptTcpClient();
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter wr = new StreamWriter(cl.GetStream());

            while (true)                    // ERROR here because as soon as a new value is mydecisioncount is increased it runs auto matically
            {
                if (opdecision == -1)
                {
                    opdecision = Convert.ToInt32(sr.ReadLine());
                    Console.WriteLine(opdecision + " THis is opponent selection");
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
                    label3.Text = "Confirm Choice & \n Wait for Opponent's Turn";
                }
                else if(mydecision == -1 && opdecision != -1)
                {
                    label3.Text = "Oppenent has chosen, \n Waiting on you";
                }
            }
        }

        //===================================Comparision Loop===========================

        public void compare()
        {
            while (true)
            {
                if(mydecision != -1 && opdecision != -1 && myturn == false)
                {
                    compareUpdate();
                    mydecision = -1;
                    opdecision = -1;
                    myturn = true;
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

                if (label1.Text == "Paper" && label2.Text == "Rock")
                {
                    label3.Text = "Opponent Win! \nPlease Choose";
                    opscore++;
                }
                else if (label1.Text == "Scissor" && label2.Text == "Paper")
                {
                    label3.Text = "Opponent Win! \nPlease Choose";
                    opscore++;
                }
                else if (label1.Text == "Rock" && label2.Text == "Scissor")
                {
                    label3.Text = "Opponent Win! \nPlease Choose";
                    opscore++;
                }
                else if (label2.Text == "Paper" && label1.Text == "Rock")
                {
                    label3.Text = "You Win! \nPlease Choose";
                    myscore++;
                }
                else if (label2.Text == "Scissor" && label1.Text == "Paper")
                {
                    label3.Text = "You Win! \nPlease Choose";
                    myscore++;
                }
                else if (label2.Text == "Rock" && label1.Text == "Scissor")
                {
                    label3.Text = "You Win! \nPlease Choose";
                    myscore++;
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
                opscore_label.Text = opscore.ToString();
                myscore_label.Text = myscore.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
