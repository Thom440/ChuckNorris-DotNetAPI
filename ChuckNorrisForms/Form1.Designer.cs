
namespace ChuckNorrisForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.jokeCategoriesCmbBox = new System.Windows.Forms.ComboBox();
            this.randomJokeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joke Categories";
            // 
            // jokeCategoriesCmbBox
            // 
            this.jokeCategoriesCmbBox.FormattingEnabled = true;
            this.jokeCategoriesCmbBox.Location = new System.Drawing.Point(102, 5);
            this.jokeCategoriesCmbBox.Name = "jokeCategoriesCmbBox";
            this.jokeCategoriesCmbBox.Size = new System.Drawing.Size(170, 21);
            this.jokeCategoriesCmbBox.TabIndex = 1;
            // 
            // randomJokeBtn
            // 
            this.randomJokeBtn.Location = new System.Drawing.Point(16, 67);
            this.randomJokeBtn.Name = "randomJokeBtn";
            this.randomJokeBtn.Size = new System.Drawing.Size(115, 23);
            this.randomJokeBtn.TabIndex = 2;
            this.randomJokeBtn.Text = "Get Random Joke";
            this.randomJokeBtn.UseVisualStyleBackColor = true;
            this.randomJokeBtn.Click += new System.EventHandler(this.RandomJokeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.randomJokeBtn);
            this.Controls.Add(this.jokeCategoriesCmbBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jokeCategoriesCmbBox;
        private System.Windows.Forms.Button randomJokeBtn;
    }
}

