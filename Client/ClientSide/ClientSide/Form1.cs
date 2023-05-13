using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
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

        int choice = -1;
        TcpClient cl = null;
        bool myturn = true;
        int opdecision = -1;
        int opscore = 0;
        int myscore = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cl = new TcpClient("192.168.0.112", 8000);


            Thread listningFrom = new Thread(read);
            listningFrom.Start();

            Thread comparision = new Thread(compare);
            comparision.Start();

            Thread w = new Thread(wait);
            w.Start();
        }

        public void send()
        {
            StreamWriter wr = new StreamWriter(cl.GetStream());
            StreamReader sr = new StreamReader(cl.GetStream());

            string data = Convert.ToString(choice);
            wr.WriteLine(data);
            wr.Flush();
            myturn = false;
        }

        private void b_rock_Click(object sender, EventArgs e)
        {
            choice = 0;
            label2.Text = "Rock";
        }

        private void b_paper_Click(object sender, EventArgs e)
        {
            choice = 1;
            label2.Text = "Paper";
        }

        private void b_scissor_Click(object sender, EventArgs e)
        {
            choice = 2;
            label2.Text = "Scissor";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread n = new Thread(send);
            n.Start();
        }

        public void read()
        {
            StreamReader sr = new StreamReader(cl.GetStream());

            while (true)                    // ERROR here because as soon as a new value is mydecisioncount is increased it runs auto matically
            {
                if (opdecision == -1)
                {
                    opdecision = Convert.ToInt32(sr.ReadLine());
                    Console.WriteLine(opdecision + " THis is Server selection");
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
                if (choice != -1 && opdecision == -1)
                {
                    label3.Text = "Confirm Choice & \n Wait for Opponent's Turn";
                }
                else if (choice == -1 && opdecision != -1)
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
                if (choice != -1 && opdecision != -1 && myturn == false)
                {
                    compareUpdate();
                    choice = -1;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
