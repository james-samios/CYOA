namespace _2017cyoa
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
            this.lblStory = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStory
            // 
            this.lblStory.Location = new System.Drawing.Point(12, 9);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(389, 163);
            this.lblStory.TabIndex = 0;
            this.lblStory.Text = "label1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 326);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(386, 96);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "button1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 438);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(386, 93);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "button2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 549);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(386, 96);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "button3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 657);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblStory);
            this.Name = "Form1";
            this.Text = "CYOA: Ethical Edition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

