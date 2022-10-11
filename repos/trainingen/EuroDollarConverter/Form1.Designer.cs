namespace EuroDollarConverter
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
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDollar = new System.Windows.Forms.Label();
            this.tbEuroAmount = new System.Windows.Forms.TextBox();
            this.tbDollarAmount = new System.Windows.Forms.TextBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.labelRate = new System.Windows.Forms.Label();
            this.nmrUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.buttonDollar = new System.Windows.Forms.Button();
            this.buttonYen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(29, 9);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(68, 73);
            this.labelEuro.TabIndex = 0;
            this.labelEuro.Text = "€";
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDollar.Location = new System.Drawing.Point(387, 9);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(68, 73);
            this.labelDollar.TabIndex = 1;
            this.labelDollar.Text = "$";
            // 
            // tbEuroAmount
            // 
            this.tbEuroAmount.Location = new System.Drawing.Point(85, 37);
            this.tbEuroAmount.Name = "tbEuroAmount";
            this.tbEuroAmount.Size = new System.Drawing.Size(100, 20);
            this.tbEuroAmount.TabIndex = 2;
            this.tbEuroAmount.Text = "1";
            this.tbEuroAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuroAmount_KeyPress);
            // 
            // tbDollarAmount
            // 
            this.tbDollarAmount.Location = new System.Drawing.Point(281, 35);
            this.tbDollarAmount.Name = "tbDollarAmount";
            this.tbDollarAmount.Size = new System.Drawing.Size(100, 20);
            this.tbDollarAmount.TabIndex = 3;
            this.tbDollarAmount.Text = "1";
            this.tbDollarAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDollarAmount_KeyPress);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(236, 35);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(39, 23);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(191, 35);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(39, 23);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(163, 78);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(88, 13);
            this.labelRate.TabIndex = 6;
            this.labelRate.Text = "Koers: 1 euro = $";
            // 
            // nmrUpDownRate
            // 
            this.nmrUpDownRate.DecimalPlaces = 2;
            this.nmrUpDownRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrUpDownRate.Location = new System.Drawing.Point(257, 76);
            this.nmrUpDownRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrUpDownRate.Name = "nmrUpDownRate";
            this.nmrUpDownRate.Size = new System.Drawing.Size(43, 20);
            this.nmrUpDownRate.TabIndex = 7;
            this.nmrUpDownRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonDollar
            // 
            this.buttonDollar.Location = new System.Drawing.Point(316, 86);
            this.buttonDollar.Name = "buttonDollar";
            this.buttonDollar.Size = new System.Drawing.Size(55, 23);
            this.buttonDollar.TabIndex = 8;
            this.buttonDollar.Text = "Dollar";
            this.buttonDollar.UseVisualStyleBackColor = true;
            this.buttonDollar.Click += new System.EventHandler(this.buttonDollar_Click);
            // 
            // buttonYen
            // 
            this.buttonYen.Location = new System.Drawing.Point(386, 86);
            this.buttonYen.Name = "buttonYen";
            this.buttonYen.Size = new System.Drawing.Size(55, 23);
            this.buttonYen.TabIndex = 9;
            this.buttonYen.Text = "Yen";
            this.buttonYen.UseVisualStyleBackColor = true;
            this.buttonYen.Click += new System.EventHandler(this.buttonYen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 121);
            this.Controls.Add(this.buttonYen);
            this.Controls.Add(this.buttonDollar);
            this.Controls.Add(this.nmrUpDownRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.tbDollarAmount);
            this.Controls.Add(this.tbEuroAmount);
            this.Controls.Add(this.labelDollar);
            this.Controls.Add(this.labelEuro);
            this.Name = "Form1";
            this.Text = "Euro - US Dollar Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.TextBox tbEuroAmount;
        private System.Windows.Forms.TextBox tbDollarAmount;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.NumericUpDown nmrUpDownRate;
        private System.Windows.Forms.Button buttonDollar;
        private System.Windows.Forms.Button buttonYen;
    }
}

