using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("just number !");
                e.Handled = true;
            }
        }
        double a;
        double b;
        double c;
        double d;
        string op;
        bool pass=false;
        private void btn0_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt.Text += "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txt.Text += ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
            txt.Text = "";
            op = "+";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
            txt.Text = "";
            op = "-" ;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
            txt.Text = "";
            op = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
            txt.Text = "";
            op = "/";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(txt.Text);
            switch (op)
            {
                case "+":
                    c = a + b;
                    txt.Text = c.ToString();
                    break;
                case "-":
                    c = a - b;
                    txt.Text = c.ToString();
                    break ;
                case "*":
                    c = a * b;
                    txt.Text = c.ToString();
                    break;
                case "/":
                    c = a / b;
                    txt.Text = c.ToString();
                    break;
                case "%":
                    d = b / 100;
                    c = a * d;
                    txt.Text = c.ToString();
                    break;
                case "e^x":

                    c = Math.Pow(a,b);
                    txt.Text = c.ToString();
                    break;
            }

            /*if (op == "+")
            {
                c = a + b;
                txt.Text = c.ToString();
            }
            else 
            {
                if (op == "-")
                {
                    c = a - b;
                    txt.Text = c.ToString();
                }
                else
                {
                    if (op == "*")
                    {
                        c = a * b;
                        txt.Text = c.ToString();
                    }
                    else
                    {
                        if (op == "/")
                        {
                            c = a / b;
                            txt.Text = c.ToString();
                        }
                        else
                        {
                            if (op == "%")
                            {
                                d = b / 100;
                                c = a * d;
                                txt.Text = c.ToString();
                            }
                            else
                            {
                                if (op == "e^x")
                                {
                                    c = Math.Pow(a,b);
                                    txt.Text = c.ToString();
                                }
                            }
                        }
                    }
                }
            }*/
            op = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txt.Text=string.Empty;
            op="";
        }

        private void btnprs_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
            txt.Text = "";
            op = "%";
        }

        private void btnpuiss_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            c = Math.Pow(a,2);
            txt.Text = c.ToString();
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            c = Math.Sqrt(a);
            txt.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size=new System.Drawing.Size(282, 449);
            btnpowx.Visible=false;
            btnpuiss.Visible=false;
            btnsqrt.Visible=false;
            btnprs.Visible=false;
            btnps.Visible=false;
            pass = false;
            txt.Size = new System.Drawing.Size(230, 63);
        }

        private void btnpowx_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            txt.Text = string.Empty;
            txt.Text = "";
            op = "e^x";
        }

        private void btnsc_Click(object sender, EventArgs e)
        {
            if (pass==false)
            {
                this.Size = new System.Drawing.Size(395, 449);
                btnpowx.Visible = true;
                btnpuiss.Visible = true;
                btnsqrt.Visible = true;
                btnprs.Visible = true;
                btnps.Visible = true;
                pass = true;
                txt.Size = new System.Drawing.Size(346, 63);
            }
            else{
                this.Size = new System.Drawing.Size(282, 449);
                btnpowx.Visible = false;
                btnpuiss.Visible = false;
                btnsqrt.Visible = false;
                btnprs.Visible = false;
                btnps.Visible = false;
                pass = false;
                txt.Size = new System.Drawing.Size(230, 63);
            }
        }

        private void btnps_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmasmenos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt.Text);
            c = -(a);
            txt.Text = c.ToString();
        }

        private void btneq2_Click(object sender, EventArgs e)
        {

        }
    }
}
