namespace assingment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_principal = new System.Windows.Forms.TextBox();
            this.txt_period = new System.Windows.Forms.TextBox();
            this.txt_average = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_contribution = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_interest = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Target Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Starting Principal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Period (yr/s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Average return(%)";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(133, 88);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(152, 20);
            this.txt_amount.TabIndex = 2;
            // 
            // txt_principal
            // 
            this.txt_principal.Location = new System.Drawing.Point(133, 116);
            this.txt_principal.Name = "txt_principal";
            this.txt_principal.Size = new System.Drawing.Size(152, 20);
            this.txt_principal.TabIndex = 2;
            // 
            // txt_period
            // 
            this.txt_period.Location = new System.Drawing.Point(133, 146);
            this.txt_period.Name = "txt_period";
            this.txt_period.Size = new System.Drawing.Size(152, 20);
            this.txt_period.TabIndex = 2;
            // 
            // txt_average
            // 
            this.txt_average.Location = new System.Drawing.Point(133, 174);
            this.txt_average.Name = "txt_average";
            this.txt_average.Size = new System.Drawing.Size(152, 20);
            this.txt_average.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Monthly Coontribution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yearly Contribution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "End Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Contribution";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(512, 85);
            this.txt_month.Name = "txt_month";
            this.txt_month.ReadOnly = true;
            this.txt_month.Size = new System.Drawing.Size(152, 20);
            this.txt_month.TabIndex = 2;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(512, 113);
            this.txt_year.Name = "txt_year";
            this.txt_year.ReadOnly = true;
            this.txt_year.Size = new System.Drawing.Size(152, 20);
            this.txt_year.TabIndex = 2;
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(512, 143);
            this.txt_end.Name = "txt_end";
            this.txt_end.ReadOnly = true;
            this.txt_end.Size = new System.Drawing.Size(152, 20);
            this.txt_end.TabIndex = 2;
            // 
            // txt_contribution
            // 
            this.txt_contribution.Location = new System.Drawing.Point(512, 174);
            this.txt_contribution.Name = "txt_contribution";
            this.txt_contribution.ReadOnly = true;
            this.txt_contribution.Size = new System.Drawing.Size(152, 20);
            this.txt_contribution.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total Interest";
            // 
            // txt_interest
            // 
            this.txt_interest.Location = new System.Drawing.Point(512, 200);
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.ReadOnly = true;
            this.txt_interest.Size = new System.Drawing.Size(152, 20);
            this.txt_interest.TabIndex = 2;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_calculate.Location = new System.Drawing.Point(31, 242);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(98, 37);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Location = new System.Drawing.Point(161, 242);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 37);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Location = new System.Drawing.Point(292, 242);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 37);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_interest);
            this.Controls.Add(this.txt_contribution);
            this.Controls.Add(this.txt_average);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_period);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_principal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_principal;
        private System.Windows.Forms.TextBox txt_period;
        private System.Windows.Forms.TextBox txt_average;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_contribution;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_interest;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}

