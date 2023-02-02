namespace NotFlappyBird
{
    partial class NotFlappyBird
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
            this.UI_Start_Btn = new System.Windows.Forms.Button();
            this.UI_Scores = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_Start_Btn
            // 
            this.UI_Start_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Start_Btn.Location = new System.Drawing.Point(12, 12);
            this.UI_Start_Btn.Name = "UI_Start_Btn";
            this.UI_Start_Btn.Size = new System.Drawing.Size(146, 58);
            this.UI_Start_Btn.TabIndex = 0;
            this.UI_Start_Btn.Text = "Start";
            this.UI_Start_Btn.UseVisualStyleBackColor = true;
            this.UI_Start_Btn.Click += new System.EventHandler(this.UI_Start_Btn_Click);
            // 
            // UI_Scores
            // 
            this.UI_Scores.FormattingEnabled = true;
            this.UI_Scores.Location = new System.Drawing.Point(164, 64);
            this.UI_Scores.Name = "UI_Scores";
            this.UI_Scores.Size = new System.Drawing.Size(245, 225);
            this.UI_Scores.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // NotFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 302);
            this.Controls.Add(this.UI_Scores);
            this.Controls.Add(this.UI_Start_Btn);
            this.Name = "NotFlappyBird";
            this.Text = "Not Flappy Bird";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Start_Btn;
        private System.Windows.Forms.ListBox UI_Scores;
        private System.Windows.Forms.Timer timer1;
    }
}

