namespace _16_Raushan
{
    partial class asd
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Converted = new System.Windows.Forms.TextBox();
            this.rb_US = new System.Windows.Forms.RadioButton();
            this.rb_Yen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(255, 52);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 0;
            // 
            // txt_Converted
            // 
            this.txt_Converted.Location = new System.Drawing.Point(255, 268);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.Size = new System.Drawing.Size(100, 20);
            this.txt_Converted.TabIndex = 1;
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(255, 102);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(70, 17);
            this.rb_US.TabIndex = 2;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "US Dollar";
            this.rb_US.UseVisualStyleBackColor = true;
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(255, 125);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(93, 17);
            this.rb_Yen.TabIndex = 3;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Currency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Converterd Amount:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // asd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_Yen);
            this.Controls.Add(this.rb_US);
            this.Controls.Add(this.txt_Converted);
            this.Controls.Add(this.txt_Amount);
            this.Name = "asd";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Converted;
        private System.Windows.Forms.RadioButton rb_US;
        private System.Windows.Forms.RadioButton rb_Yen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

