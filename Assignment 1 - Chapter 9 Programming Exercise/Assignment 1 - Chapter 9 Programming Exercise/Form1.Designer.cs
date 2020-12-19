namespace Assignment_1___Chapter_9_Programming_Exercise
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
            this.lbl1num = new System.Windows.Forms.Label();
            this.txt2num = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl2num = new System.Windows.Forms.Label();
            this.txt1num = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1num
            // 
            this.lbl1num.AutoSize = true;
            this.lbl1num.Location = new System.Drawing.Point(170, 71);
            this.lbl1num.Name = "lbl1num";
            this.lbl1num.Size = new System.Drawing.Size(145, 17);
            this.lbl1num.TabIndex = 0;
            this.lbl1num.Text = "Enter the first number";
            this.lbl1num.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt2num
            // 
            this.txt2num.Location = new System.Drawing.Point(392, 114);
            this.txt2num.Name = "txt2num";
            this.txt2num.Size = new System.Drawing.Size(100, 22);
            this.txt2num.TabIndex = 1;
            this.txt2num.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(240, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Add";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(392, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Multiply";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl2num
            // 
            this.lbl2num.AutoSize = true;
            this.lbl2num.Location = new System.Drawing.Point(169, 115);
            this.lbl2num.Name = "lbl2num";
            this.lbl2num.Size = new System.Drawing.Size(168, 17);
            this.lbl2num.TabIndex = 4;
            this.lbl2num.Text = "Enter the second number";
            this.lbl2num.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // txt1num
            // 
            this.txt1num.Location = new System.Drawing.Point(392, 70);
            this.txt1num.Name = "txt1num";
            this.txt1num.Size = new System.Drawing.Size(100, 22);
            this.txt1num.TabIndex = 5;
            this.txt1num.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(311, 238);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 17);
            this.lbl3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt1num);
            this.Controls.Add(this.lbl2num);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt2num);
            this.Controls.Add(this.lbl1num);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1num;
        private System.Windows.Forms.TextBox txt2num;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl2num;
        private System.Windows.Forms.TextBox txt1num;
        private System.Windows.Forms.Label lbl3;
    }
}

