namespace RockPaperScissors
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEnemyChoice = new System.Windows.Forms.TextBox();
            this.labelEnemyChoice = new System.Windows.Forms.Label();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRock);
            this.groupBox1.Controls.Add(this.radioButtonScissors);
            this.groupBox1.Controls.Add(this.radioButtonPaper);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Location = new System.Drawing.Point(6, 65);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRock.TabIndex = 2;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "Rock";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            this.radioButtonRock.Click += new System.EventHandler(this.radioButtonRock_Click);
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Location = new System.Drawing.Point(6, 42);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(64, 17);
            this.radioButtonScissors.TabIndex = 1;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "Scissors";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            this.radioButtonScissors.Click += new System.EventHandler(this.radioButtonScissors_Click);
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPaper.TabIndex = 0;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "Paper";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            this.radioButtonPaper.Click += new System.EventHandler(this.radioButtonPaper_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEnemyChoice);
            this.groupBox2.Controls.Add(this.labelEnemyChoice);
            this.groupBox2.Location = new System.Drawing.Point(205, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enemy";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxEnemyChoice
            // 
            this.textBoxEnemyChoice.Location = new System.Drawing.Point(10, 42);
            this.textBoxEnemyChoice.Name = "textBoxEnemyChoice";
            this.textBoxEnemyChoice.Size = new System.Drawing.Size(75, 20);
            this.textBoxEnemyChoice.TabIndex = 1;
            // 
            // labelEnemyChoice
            // 
            this.labelEnemyChoice.AutoSize = true;
            this.labelEnemyChoice.Location = new System.Drawing.Point(7, 20);
            this.labelEnemyChoice.Name = "labelEnemyChoice";
            this.labelEnemyChoice.Size = new System.Drawing.Size(78, 13);
            this.labelEnemyChoice.TabIndex = 0;
            this.labelEnemyChoice.Text = "Enemy Choice:";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(12, 182);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.Size = new System.Drawing.Size(336, 244);
            this.textBoxHistory.TabIndex = 2;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(18, 154);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(330, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.RadioButton radioButtonScissors;
        private System.Windows.Forms.RadioButton radioButtonPaper;
        private System.Windows.Forms.TextBox textBoxEnemyChoice;
        private System.Windows.Forms.Label labelEnemyChoice;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Button buttonPlay;
    }
}

