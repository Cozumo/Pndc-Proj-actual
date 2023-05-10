
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
            this.b_scissor = new System.Windows.Forms.Button();
            this.b_paper = new System.Windows.Forms.Button();
            this.b_rock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_scissor
            // 
            this.b_scissor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_scissor.Location = new System.Drawing.Point(385, 272);
            this.b_scissor.Name = "b_scissor";
            this.b_scissor.Size = new System.Drawing.Size(58, 55);
            this.b_scissor.TabIndex = 5;
            this.b_scissor.UseVisualStyleBackColor = true;
            this.b_scissor.Click += new System.EventHandler(this.b_scissor_Click);
            // 
            // b_paper
            // 
            this.b_paper.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_paper.Location = new System.Drawing.Point(300, 272);
            this.b_paper.Name = "b_paper";
            this.b_paper.Size = new System.Drawing.Size(58, 55);
            this.b_paper.TabIndex = 4;
            this.b_paper.UseVisualStyleBackColor = true;
            this.b_paper.Click += new System.EventHandler(this.b_paper_Click);
            // 
            // b_rock
            // 
            this.b_rock.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rock.Location = new System.Drawing.Point(217, 272);
            this.b_rock.Name = "b_rock";
            this.b_rock.Size = new System.Drawing.Size(58, 55);
            this.b_rock.TabIndex = 3;
            this.b_rock.UseVisualStyleBackColor = true;
            this.b_rock.Click += new System.EventHandler(this.b_rock_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(546, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_scissor);
            this.Controls.Add(this.b_paper);
            this.Controls.Add(this.b_rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_scissor;
        private System.Windows.Forms.Button b_paper;
        private System.Windows.Forms.Button b_rock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

