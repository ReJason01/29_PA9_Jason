using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Raushan
{
    public partial class asd : Form
    {
        public asd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (rb_US.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 0.74M;
                    txt_Converted.Text = "$" + converted_amount.ToString();
           
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
         
                }
            }
            else if (rb_Yen.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 81.97M;
                
                    txt_Converted.Text = "Y" + converted_amount.ToString();
    
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
           
                }
            }
            // The form missing -Jason
            //else if (rb_RM.Checked)
                //{
                //try
                //{
                    //decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    //decimal converted_amount = amount * 81.97M;

                   // txt_Converted.Text = "RM" + converted_amount.ToString();

                //}
                //catch (FormatException)
                //{
                   // txt_Amount.Clear();
                   // txt_Converted.Clear();
            
                //}
           // }
         
            }
        }
    }

