
namespace ChuckNorrisForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Random Joke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriesCbox
            // 
            this.categoriesCbox.FormattingEnabled = true;
            this.categoriesCbox.Location = new System.Drawing.Point(117, 57);
            this.categoriesCbox.Name = "categoriesCbox";
            this.categoriesCbox.Size = new System.Drawing.Size(213, 20);
            this.categoriesCbox.TabIndex = 1;
            this.categoriesCbox.SelectedIndexChanged += new System.EventHandler(this.categoriesCbox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 312);
            this.Controls.Add(this.categoriesCbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoriesCbox;
    }
}

