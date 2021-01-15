namespace Investment_Calculator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.principal = new System.Windows.Forms.TextBox();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compoundRateScroll = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.monthAccrueLabel = new System.Windows.Forms.Label();
            this.monthsAccrueScroll = new System.Windows.Forms.HScrollBar();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.label100 = new System.Windows.Forms.Label();
            this.compoundRateLabel = new System.Windows.Forms.Label();
            this.futureValue = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Future Value of an Investment";
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(246, 58);
            this.principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(103, 20);
            this.principal.TabIndex = 1;
            this.principal.Text = "0.0";
            this.principal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.principal_KeyPress);
            this.principal.Validating += new System.ComponentModel.CancelEventHandler(this.principal_Validating);
            // 
            // interestRate
            // 
            this.interestRate.Location = new System.Drawing.Point(246, 93);
            this.interestRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(103, 20);
            this.interestRate.TabIndex = 2;
            this.interestRate.Text = "0.0";
            this.interestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestRate_KeyPress);
            this.interestRate.Validating += new System.ComponentModel.CancelEventHandler(this.interestRate_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interest Rate (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Compound Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "(12 for monthly)";
            // 
            // compoundRateScroll
            // 
            this.compoundRateScroll.Location = new System.Drawing.Point(229, 166);
            this.compoundRateScroll.Maximum = 374;
            this.compoundRateScroll.Name = "compoundRateScroll";
            this.compoundRateScroll.Size = new System.Drawing.Size(136, 30);
            this.compoundRateScroll.TabIndex = 7;
            this.compoundRateScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.compoundRateScroll_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. of Months Principal Accrues";
            // 
            // monthAccrueLabel
            // 
            this.monthAccrueLabel.AutoSize = true;
            this.monthAccrueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthAccrueLabel.Location = new System.Drawing.Point(226, 194);
            this.monthAccrueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthAccrueLabel.Name = "monthAccrueLabel";
            this.monthAccrueLabel.Size = new System.Drawing.Size(16, 17);
            this.monthAccrueLabel.TabIndex = 9;
            this.monthAccrueLabel.Text = "0";
            // 
            // monthsAccrueScroll
            // 
            this.monthsAccrueScroll.Location = new System.Drawing.Point(229, 218);
            this.monthsAccrueScroll.Maximum = 129;
            this.monthsAccrueScroll.Name = "monthsAccrueScroll";
            this.monthsAccrueScroll.Size = new System.Drawing.Size(136, 32);
            this.monthsAccrueScroll.TabIndex = 10;
            this.monthsAccrueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.monthsAccrueScroll_Scroll);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(8, 260);
            this.calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(110, 24);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(139, 260);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 24);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(264, 260);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(110, 24);
            this.quit.TabIndex = 13;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(101, 298);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(105, 20);
            this.label100.TabIndex = 15;
            this.label100.Text = "Future Value:";
            // 
            // compoundRateLabel
            // 
            this.compoundRateLabel.AutoSize = true;
            this.compoundRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compoundRateLabel.Location = new System.Drawing.Point(226, 138);
            this.compoundRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.compoundRateLabel.Name = "compoundRateLabel";
            this.compoundRateLabel.Size = new System.Drawing.Size(18, 20);
            this.compoundRateLabel.TabIndex = 16;
            this.compoundRateLabel.Text = "0";
            // 
            // futureValue
            // 
            this.futureValue.AutoSize = true;
            this.futureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureValue.Location = new System.Drawing.Point(209, 298);
            this.futureValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.futureValue.Name = "futureValue";
            this.futureValue.Size = new System.Drawing.Size(54, 20);
            this.futureValue.TabIndex = 17;
            this.futureValue.Text = "$0.00";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 349);
            this.Controls.Add(this.futureValue);
            this.Controls.Add(this.compoundRateLabel);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.monthsAccrueScroll);
            this.Controls.Add(this.monthAccrueLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compoundRateScroll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.interestRate);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Investment Groups";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar compoundRateScroll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label monthAccrueLabel;
        private System.Windows.Forms.HScrollBar monthsAccrueScroll;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label compoundRateLabel;
        private System.Windows.Forms.Label futureValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

