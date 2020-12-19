using System;
using System.Windows.Forms;

namespace Assignment_1___Chapter_9_Programming_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool check()
        {
            int 1num,2num;
            if (((int.TryParse(txt1num.Text, out 1num)
                == false)(int.TryParse(txt1num.Text, out
                1num) == true))((int.TryParse(txt2num.Text,
                out 2num) == false)(int.TryParse(txt2num.Text,
                out 2num) == true)))
            {
                if (int.TryParse(txt1num.Text, out 1num) == false)
                {
                    txt1num.Text = "0";
                    txt1num.Focus();
                    return true;
                }
                if (1num < 0)
                    {
                    txt1num.Text = "0";
                    txt1num.Focus();
                    return true;
                }

                if (int.TryParse(txt2num.Text, out
                        2num) == false)
                {
                    txt2num.Text = "0";
                    txt2num.Focus();
                    return true;
                }
                if (2num < 0)
                    {
                    txt2num.Text = "0";
                    txt2num.Focus();
                    return true;
                }


            }

            return false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bool check1 = check();
            if check1 = check();
            if (check1)
            {
                this.lbl3.ForeColor =
                    System.Drawing.Color.Red;
                MessageBox.Show("Value must be numeric and >0");
            }

            else

            {
                int 1num,2num,result;
                int.TryParse(txt1num.Text, out 1num);
                int.TryParse(txt2num.Text, out 2num);
                DialogResult = 1num * 2num;
                this.lbl3.Text = "The result is:" + DialogResult;
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool check1 = check();
            if (check1)
            {
                this.lbl3.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Value must be numeric and >0");
                this.lbl3.Text = "The result can't be calculated";
            }
            else
            {
                int 1num, 2num, result;
                int.TryParse(txt1num.Text, out 1num);
                int.TryParse(txt2num.Text, out 2num);
                DialogResult = 1num + 2num;
                this.lbl3.Text = "The result is: " + DialogResult;
            }


        }
    }



}

}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool check()
        {
            int 1num,2num;
            if (((int.TryParse(txt1num.Text, out 1num)
                == false)(int.TryParse(txt1num.Text, out
                1num) == true))((int.TryParse(txt2num.Text,
                out 2num) == false)(int.TryParse(txt2num.Text,
                out 2num) == true)))
            {
                if (int.TryParse(txt1num.Text, out 1num) == false)
                {
                    txt1num.Text = "0";
                    txt1num.Focus();
                    return true;
                }
                if (1num < 0)
                    {
                    txt1num.Text = "0";
                    txt1num.Focus();
                    return true;
                }

                if (int.TryParse(txt2num.Text, out
                        2num) == false)
                {
                    txt2num.Text = "0";
                    txt2num.Focus();
                    return true;
                }
                if (2num < 0)
                    {
                    txt2num.Text = "0";
                    txt2num.Focus();
                    return true;
                }

                
            }

            return false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bool check1 = check();
            if check1 = check();
            if (check1)
            {
                this.lbl3.ForeColor =
                    System.Drawing.Color.Red;
                MessageBox.Show("Value must be numeric and >0");
            }

            else

            {
                int 1num,2num,result;
                int.TryParse(txt1num.Text, out 1num);
                int.TryParse(txt2num.Text, out 2num);
                DialogResult = 1num * 2num;
                this.lbl3.Text = "The result is:" + DialogResult;
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool check1 = check();
            if (check1)
            {
                this.lbl3.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Value must be numeric and >0");
                this.lbl3.Text = "The result can't be calculated";
            }
            else
            {
                int 1num, 2num, result;
                int.TryParse(txt1num.Text, out 1num);
                int.TryParse(txt2num.Text, out 2num);
                DialogResult = 1num + 2num;
                this.lbl3.Text = "The result is: " + DialogResult;
            } 


            }
        }


    }
}

