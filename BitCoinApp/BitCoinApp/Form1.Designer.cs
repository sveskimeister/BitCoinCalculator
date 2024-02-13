namespace BitCoinApp
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
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyCombo.Location = new System.Drawing.Point(62, 53);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(121, 21);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(235, 53);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of BitCoins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(59, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            this.label2.Visible = false;
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(62, 210);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(100, 20);
            this.resultText.TabIndex = 5;
            this.resultText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultText;
    }
}

