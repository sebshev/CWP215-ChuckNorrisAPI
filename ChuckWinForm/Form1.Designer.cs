﻿
namespace ChuckWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categorieCmbBox = new System.Windows.Forms.ComboBox();
            this.randJokeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorieCmbBox
            // 
            this.categorieCmbBox.FormattingEnabled = true;
            this.categorieCmbBox.Location = new System.Drawing.Point(180, 72);
            this.categorieCmbBox.Name = "categorieCmbBox";
            this.categorieCmbBox.Size = new System.Drawing.Size(257, 23);
            this.categorieCmbBox.TabIndex = 0;
            this.categorieCmbBox.Text = "Categories";
            // 
            // randJokeBtn
            // 
            this.randJokeBtn.Location = new System.Drawing.Point(221, 176);
            this.randJokeBtn.Name = "randJokeBtn";
            this.randJokeBtn.Size = new System.Drawing.Size(155, 36);
            this.randJokeBtn.TabIndex = 1;
            this.randJokeBtn.Text = "Random Joke";
            this.randJokeBtn.UseVisualStyleBackColor = true;
            this.randJokeBtn.Click += new System.EventHandler(this.randJokeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randJokeBtn);
            this.Controls.Add(this.categorieCmbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categorieCmbBox;
        private System.Windows.Forms.Button randJokeBtn;
    }
}

