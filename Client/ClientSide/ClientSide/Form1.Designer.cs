
namespace ClientSide
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_rock = new System.Windows.Forms.Button();
            this.b_paper = new System.Windows.Forms.Button();
            this.b_scissor = new System.Windows.Forms.Button();
            this.b_confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opscore_label = new System.Windows.Forms.Label();
            this.myscore_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_rock
            // 
            this.b_rock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_rock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_rock.FlatAppearance.BorderSize = 0;
            this.b_rock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_rock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_rock.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rock.Location = new System.Drawing.Point(281, 301);
            this.b_rock.Name = "b_rock";
            this.b_rock.Size = new System.Drawing.Size(58, 55);
            this.b_rock.TabIndex = 3;
            this.b_rock.UseVisualStyleBackColor = false;
            this.b_rock.Click += new System.EventHandler(this.b_rock_Click);
            // 
            // b_paper
            // 
            this.b_paper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_paper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_paper.FlatAppearance.BorderSize = 0;
            this.b_paper.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_paper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_paper.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_paper.Location = new System.Drawing.Point(364, 301);
            this.b_paper.Name = "b_paper";
            this.b_paper.Size = new System.Drawing.Size(58, 55);
            this.b_paper.TabIndex = 4;
            this.b_paper.UseVisualStyleBackColor = false;
            this.b_paper.Click += new System.EventHandler(this.b_paper_Click);
            // 
            // b_scissor
            // 
            this.b_scissor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_scissor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_scissor.FlatAppearance.BorderSize = 0;
            this.b_scissor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_scissor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_scissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_scissor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_scissor.Location = new System.Drawing.Point(449, 301);
            this.b_scissor.Name = "b_scissor";
            this.b_scissor.Size = new System.Drawing.Size(58, 55);
            this.b_scissor.TabIndex = 5;
            this.b_scissor.UseVisualStyleBackColor = false;
            this.b_scissor.Click += new System.EventHandler(this.b_scissor_Click);
            // 
            // b_confirm
            // 
            this.b_confirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_confirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_confirm.FlatAppearance.BorderSize = 0;
            this.b_confirm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.b_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_confirm.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_confirm.Location = new System.Drawing.Point(610, 301);
            this.b_confirm.Name = "b_confirm";
            this.b_confirm.Size = new System.Drawing.Size(111, 55);
            this.b_confirm.TabIndex = 7;
            this.b_confirm.Text = "CONFIRM";
            this.b_confirm.UseVisualStyleBackColor = false;
            this.b_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 450);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // opscore_label
            // 
            this.opscore_label.AutoSize = true;
            this.opscore_label.BackColor = System.Drawing.Color.Teal;
            this.opscore_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opscore_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opscore_label.Location = new System.Drawing.Point(131, 174);
            this.opscore_label.Name = "opscore_label";
            this.opscore_label.Size = new System.Drawing.Size(52, 25);
            this.opscore_label.TabIndex = 36;
            this.opscore_label.Text = "You:";
            // 
            // myscore_label
            // 
            this.myscore_label.AutoSize = true;
            this.myscore_label.BackColor = System.Drawing.Color.Teal;
            this.myscore_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myscore_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myscore_label.Location = new System.Drawing.Point(131, 138);
            this.myscore_label.Name = "myscore_label";
            this.myscore_label.Size = new System.Drawing.Size(52, 25);
            this.myscore_label.TabIndex = 35;
            this.myscore_label.Text = "You:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(10, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Opponent:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(10, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "You:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(57, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Score\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "You";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Opponent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Client:     ROCK, PAPER, SCISSORS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.opscore_label);
            this.Controls.Add(this.myscore_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_confirm);
            this.Controls.Add(this.b_scissor);
            this.Controls.Add(this.b_paper);
            this.Controls.Add(this.b_rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_rock;
        private System.Windows.Forms.Button b_paper;
        private System.Windows.Forms.Button b_scissor;
        private System.Windows.Forms.Button b_confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label opscore_label;
        private System.Windows.Forms.Label myscore_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

