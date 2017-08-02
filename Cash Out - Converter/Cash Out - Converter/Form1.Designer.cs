namespace Cash_Out___Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalculatorBTN = new System.Windows.Forms.Button();
            this.Money_Dollar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Money_Cent = new System.Windows.Forms.TextBox();
            this.Dollar_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Dollar_5 = new System.Windows.Forms.Label();
            this.Dollar_10 = new System.Windows.Forms.Label();
            this.Dollar_20 = new System.Windows.Forms.Label();
            this.Dollar_50 = new System.Windows.Forms.Label();
            this.Dollar_100 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Money_Penny = new System.Windows.Forms.Label();
            this.Money_Nickel = new System.Windows.Forms.Label();
            this.Money_Dime = new System.Windows.Forms.Label();
            this.Money_Quarter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculatorBTN
            // 
            this.CalculatorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CalculatorBTN.Location = new System.Drawing.Point(347, 369);
            this.CalculatorBTN.Name = "CalculatorBTN";
            this.CalculatorBTN.Size = new System.Drawing.Size(96, 41);
            this.CalculatorBTN.TabIndex = 3;
            this.CalculatorBTN.Text = "Calculate";
            this.CalculatorBTN.UseVisualStyleBackColor = true;
            this.CalculatorBTN.Click += new System.EventHandler(this.CalculatorBTN_Click);
            // 
            // Money_Dollar
            // 
            this.Money_Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Money_Dollar.Location = new System.Drawing.Point(189, 53);
            this.Money_Dollar.Name = "Money_Dollar";
            this.Money_Dollar.Size = new System.Drawing.Size(88, 23);
            this.Money_Dollar.TabIndex = 1;
            this.Money_Dollar.Text = "0";
            this.Money_Dollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Money_Dollar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_Dollar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(29, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "$1                  : ";
            // 
            // ResetBTN
            // 
            this.ResetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ResetBTN.Location = new System.Drawing.Point(32, 369);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(96, 41);
            this.ResetBTN.TabIndex = 4;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(167, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(280, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // Money_Cent
            // 
            this.Money_Cent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Money_Cent.Location = new System.Drawing.Point(296, 53);
            this.Money_Cent.MaxLength = 2;
            this.Money_Cent.Name = "Money_Cent";
            this.Money_Cent.Size = new System.Drawing.Size(50, 23);
            this.Money_Cent.TabIndex = 2;
            this.Money_Cent.Text = "00";
            this.Money_Cent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_Cent_KeyPress);
            // 
            // Dollar_1
            // 
            this.Dollar_1.AutoSize = true;
            this.Dollar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Dollar_1.Location = new System.Drawing.Point(190, 153);
            this.Dollar_1.Name = "Dollar_1";
            this.Dollar_1.Size = new System.Drawing.Size(23, 25);
            this.Dollar_1.TabIndex = 0;
            this.Dollar_1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(29, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "$5                  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(23, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "$10                 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(23, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "$20                 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(23, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "$50                 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(17, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "$100                : ";
            // 
            // Dollar_5
            // 
            this.Dollar_5.AutoSize = true;
            this.Dollar_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Dollar_5.Location = new System.Drawing.Point(190, 178);
            this.Dollar_5.Name = "Dollar_5";
            this.Dollar_5.Size = new System.Drawing.Size(23, 25);
            this.Dollar_5.TabIndex = 0;
            this.Dollar_5.Text = "0";
            // 
            // Dollar_10
            // 
            this.Dollar_10.AutoSize = true;
            this.Dollar_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Dollar_10.Location = new System.Drawing.Point(190, 203);
            this.Dollar_10.Name = "Dollar_10";
            this.Dollar_10.Size = new System.Drawing.Size(23, 25);
            this.Dollar_10.TabIndex = 0;
            this.Dollar_10.Text = "0";
            // 
            // Dollar_20
            // 
            this.Dollar_20.AutoSize = true;
            this.Dollar_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Dollar_20.Location = new System.Drawing.Point(190, 228);
            this.Dollar_20.Name = "Dollar_20";
            this.Dollar_20.Size = new System.Drawing.Size(23, 25);
            this.Dollar_20.TabIndex = 0;
            this.Dollar_20.Text = "0";
            // 
            // Dollar_50
            // 
            this.Dollar_50.AutoSize = true;
            this.Dollar_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Dollar_50.Location = new System.Drawing.Point(190, 253);
            this.Dollar_50.Name = "Dollar_50";
            this.Dollar_50.Size = new System.Drawing.Size(23, 25);
            this.Dollar_50.TabIndex = 0;
            this.Dollar_50.Text = "0";
            // 
            // Dollar_100
            // 
            this.Dollar_100.AutoSize = true;
            this.Dollar_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Dollar_100.Location = new System.Drawing.Point(190, 278);
            this.Dollar_100.Name = "Dollar_100";
            this.Dollar_100.Size = new System.Drawing.Size(23, 25);
            this.Dollar_100.TabIndex = 0;
            this.Dollar_100.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(315, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = ".01           : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(315, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = ".05           : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(315, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = ".10           : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(315, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = ".25           : ";
            // 
            // Money_Penny
            // 
            this.Money_Penny.AutoSize = true;
            this.Money_Penny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Money_Penny.Location = new System.Drawing.Point(452, 153);
            this.Money_Penny.Name = "Money_Penny";
            this.Money_Penny.Size = new System.Drawing.Size(23, 25);
            this.Money_Penny.TabIndex = 0;
            this.Money_Penny.Text = "0";
            // 
            // Money_Nickel
            // 
            this.Money_Nickel.AutoSize = true;
            this.Money_Nickel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Money_Nickel.Location = new System.Drawing.Point(452, 178);
            this.Money_Nickel.Name = "Money_Nickel";
            this.Money_Nickel.Size = new System.Drawing.Size(23, 25);
            this.Money_Nickel.TabIndex = 0;
            this.Money_Nickel.Text = "0";
            // 
            // Money_Dime
            // 
            this.Money_Dime.AutoSize = true;
            this.Money_Dime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Money_Dime.Location = new System.Drawing.Point(452, 203);
            this.Money_Dime.Name = "Money_Dime";
            this.Money_Dime.Size = new System.Drawing.Size(23, 25);
            this.Money_Dime.TabIndex = 0;
            this.Money_Dime.Text = "0";
            // 
            // Money_Quarter
            // 
            this.Money_Quarter.AutoSize = true;
            this.Money_Quarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Money_Quarter.Location = new System.Drawing.Point(452, 228);
            this.Money_Quarter.Name = "Money_Quarter";
            this.Money_Quarter.Size = new System.Drawing.Size(23, 25);
            this.Money_Quarter.TabIndex = 0;
            this.Money_Quarter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 431);
            this.Controls.Add(this.Money_Quarter);
            this.Controls.Add(this.Money_Dime);
            this.Controls.Add(this.Money_Nickel);
            this.Controls.Add(this.Money_Penny);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dollar_100);
            this.Controls.Add(this.Dollar_50);
            this.Controls.Add(this.Dollar_20);
            this.Controls.Add(this.Dollar_10);
            this.Controls.Add(this.Dollar_5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dollar_1);
            this.Controls.Add(this.Money_Cent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Money_Dollar);
            this.Controls.Add(this.CalculatorBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 470);
            this.MinimumSize = new System.Drawing.Size(549, 470);
            this.Name = "Form1";
            this.Text = "Cash Out";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculatorBTN;
        private System.Windows.Forms.TextBox Money_Dollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Money_Cent;
        private System.Windows.Forms.Label Dollar_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Dollar_5;
        private System.Windows.Forms.Label Dollar_10;
        private System.Windows.Forms.Label Dollar_20;
        private System.Windows.Forms.Label Dollar_50;
        private System.Windows.Forms.Label Dollar_100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Money_Penny;
        private System.Windows.Forms.Label Money_Nickel;
        private System.Windows.Forms.Label Money_Dime;
        private System.Windows.Forms.Label Money_Quarter;
    }
}

