namespace Activity_3
{
    partial class activity3GUI
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
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.userQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.yesButton.Location = new System.Drawing.Point(107, 269);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(136, 77);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.noButton.Location = new System.Drawing.Point(347, 269);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(136, 77);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // userQuestion
            // 
            this.userQuestion.AutoSize = true;
            this.userQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userQuestion.Location = new System.Drawing.Point(165, 107);
            this.userQuestion.Name = "userQuestion";
            this.userQuestion.Size = new System.Drawing.Size(289, 25);
            this.userQuestion.TabIndex = 2;
            this.userQuestion.Text = "Are you a Denver Broncos fan? ";
            this.userQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activity3GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 398);
            this.Controls.Add(this.userQuestion);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Name = "activity3GUI";
            this.Text = "Activity 3 GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label userQuestion;
    }
}

