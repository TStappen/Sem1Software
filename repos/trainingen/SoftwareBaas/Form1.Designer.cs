namespace SoftwareBaas
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
            this.labelInputHeight = new System.Windows.Forms.Label();
            this.labelCM = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInputHeight
            // 
            this.labelInputHeight.AutoSize = true;
            this.labelInputHeight.Location = new System.Drawing.Point(26, 39);
            this.labelInputHeight.Name = "labelInputHeight";
            this.labelInputHeight.Size = new System.Drawing.Size(86, 13);
            this.labelInputHeight.TabIndex = 0;
            this.labelInputHeight.Text = "Input your height";
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Location = new System.Drawing.Point(187, 39);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(21, 13);
            this.labelCM.TabIndex = 1;
            this.labelCM.Text = "cm";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(118, 36);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(63, 20);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            this.textBoxHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxHeight_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 107);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelCM);
            this.Controls.Add(this.labelInputHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputHeight;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.TextBox textBoxHeight;
    }
}

