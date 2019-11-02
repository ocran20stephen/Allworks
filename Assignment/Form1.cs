using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assingment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variable declaration
        Double monthly,period,start,rate,month_cont, year_cont, end_balance, total_contribution, total_interest;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //to close app when clicked
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //code to clear all text field on a button click
            txt_amount.Clear();
            txt_principal.Clear();
            txt_period.Clear();
            txt_average.Clear();
            txt_month.Clear();
            txt_year.Clear();
            txt_end.Clear();
            txt_contribution.Clear();
            txt_interest.Clear();
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //text input validation
            if (txt_amount.Text != "" && txt_principal.Text != "" && txt_period.Text != "" && txt_average.Text != "")
            {
             
                //converting and assigning variables for further calculations
                monthly = Convert.ToDouble(txt_amount.Text);
                period = Convert.ToDouble(txt_period.Text);
                start = Convert.ToDouble(txt_principal.Text);
                rate = Convert.ToDouble(txt_average.Text);

                //performing calculations
                month_cont = monthly;
                year_cont = monthly * period;
                total_contribution = (monthly * (period * 12) + start);
                total_interest = (monthly * (period * 12) * (rate / 100) - 100);
                end_balance = (total_contribution + total_interest);

                //setting answers to the various textboxs for display
                txt_month.Text = "₵" + year_cont;
                txt_year.Text = "₵" + year_cont;
                txt_end.Text = "₵" + end_balance;
                txt_contribution.Text = "₵" + total_contribution;
                txt_interest.Text = "₵" + total_interest;
            }
            else
            {
                MessageBox.Show("Please fill all the feilds");
            }
        }
    }
}
