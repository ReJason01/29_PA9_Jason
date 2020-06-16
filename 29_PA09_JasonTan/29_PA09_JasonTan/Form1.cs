using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_PA09_JasonTan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rb_Yen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            if (rb_US.Checked == false)
                if (rb_Yen.Checked == false)
                    //if (rb_Ringgit.Checked == false)
                        label2.Text = "Select currency: ";
            if (rb_US.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 0.74M;
                    txt_Converted.Text = "$" + converted_amount.ToString();
                    label3.Text = "";
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    label2.Text = "Invalid Input.";
                }
            }
            else if (rb_Yen.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 81.97M;
                    txt_Converted.Text = "¥" + converted_amount.ToString();
                    label2.Text = "";
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    label2.Text = "Invalid Input.";
                }
            }
            //else if (rb_Ringgit.Checked)
            //{
                //try
                //{
                   // decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    //decimal converted_amount = amount * 3.01M;
                    //txt_Converted.Text = "$" + converted_amount.ToString();
                    //label2.Text = "";
                //}
                //catch (FormatException)
                //{
                    //txt_Amount.Clear();
                    //txt_Converted.Clear();
                    //label2.Text = "Invalid Input.";
                //}
            //}
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }

}
