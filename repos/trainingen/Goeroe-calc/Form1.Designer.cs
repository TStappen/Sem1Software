namespace WindowsFormsAppPresentatie
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
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.buttonMult = new System.Windows.Forms.Button();
            this.labelAntwood = new System.Windows.Forms.Label();
            this.buttonWortel = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(259, 86);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(0, 13);
            this.labelAnswer.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(193, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(100, 86);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(13, 13);
            this.labelPlus.TabIndex = 4;
            this.labelPlus.Text = "+";
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(243, 80);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(44, 23);
            this.buttonMult.TabIndex = 5;
            this.buttonMult.Text = "x";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMultClick);
            // 
            // labelAntwood
            // 
            this.labelAntwood.AutoSize = true;
            this.labelAntwood.Location = new System.Drawing.Point(123, 120);
            this.labelAntwood.Name = "labelAntwood";
            this.labelAntwood.Size = new System.Drawing.Size(51, 13);
            this.labelAntwood.TabIndex = 6;
            this.labelAntwood.Text = "Uitkomst:";
            this.labelAntwood.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonWortel
            // 
            this.buttonWortel.Location = new System.Drawing.Point(193, 51);
            this.buttonWortel.Name = "buttonWortel";
            this.buttonWortel.Size = new System.Drawing.Size(94, 23);
            this.buttonWortel.TabIndex = 7;
            this.buttonWortel.Text = "Wortel";
            this.buttonWortel.UseVisualStyleBackColor = true;
            this.buttonWortel.Click += new System.EventHandler(this.buttonWortel_click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(193, 115);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(44, 23);
            this.buttonDivision.TabIndex = 8;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivisionClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 212);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonWortel);
            this.Controls.Add(this.labelAntwood);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Label labelAntwood;
        private System.Windows.Forms.Button buttonWortel;
        private System.Windows.Forms.Button buttonDivision;
    }
}

