
namespace ServerSide
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_rock
            // 
            this.b_rock.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rock.Location = new System.Drawing.Point(199, 250);
            this.b_rock.Name = "b_rock";
            this.b_rock.Size = new System.Drawing.Size(58, 55);
            this.b_rock.TabIndex = 0;
            this.b_rock.UseVisualStyleBackColor = true;
            this.b_rock.Click += new System.EventHandler(this.b_rock_Click);
            // 
            // b_paper
            // 
            this.b_paper.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_paper.Location = new System.Drawing.Point(282, 250);
            this.b_paper.Name = "b_paper";
            this.b_paper.Size = new System.Drawing.Size(58, 55);
            this.b_paper.TabIndex = 1;
            this.b_paper.UseVisualStyleBackColor = true;
            this.b_paper.Click += new System.EventHandler(this.b_paper_Click);
            // 
            // b_scissor
            // 
            this.b_scissor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_scissor.Location = new System.Drawing.Point(367, 250);
            this.b_scissor.Name = "b_scissor";
            this.b_scissor.Size = new System.Drawing.Size(58, 55);
            this.b_scissor.TabIndex = 2;
            this.b_scissor.UseVisualStyleBackColor = true;
            this.b_scissor.Click += new System.EventHandler(this.b_scissor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_scissor);
            this.Controls.Add(this.b_paper);
            this.Controls.Add(this.b_rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_rock;
        private System.Windows.Forms.Button b_paper;
        private System.Windows.Forms.Button b_scissor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

