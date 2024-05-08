namespace Numere_prime
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
            this.checkBUTTON = new System.Windows.Forms.Button();
            this.primenumbertextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBUTTON
            // 
            this.checkBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBUTTON.ForeColor = System.Drawing.Color.Red;
            this.checkBUTTON.Location = new System.Drawing.Point(380, 277);
            this.checkBUTTON.Name = "checkBUTTON";
            this.checkBUTTON.Size = new System.Drawing.Size(126, 47);
            this.checkBUTTON.TabIndex = 0;
            this.checkBUTTON.Text = "check";
            this.checkBUTTON.UseVisualStyleBackColor = false;
            this.checkBUTTON.Click += new System.EventHandler(this.checkBUTTON_Click);
            // 
            // primenumbertextbox
            // 
            this.primenumbertextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.primenumbertextbox.Location = new System.Drawing.Point(361, 172);
            this.primenumbertextbox.Name = "primenumbertextbox";
            this.primenumbertextbox.Size = new System.Drawing.Size(175, 22);
            this.primenumbertextbox.TabIndex = 1;
            this.primenumbertextbox.Text = "jehje";
            this.primenumbertextbox.TextChanged += new System.EventHandler(this.primenumbertextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 477);
            this.Controls.Add(this.primenumbertextbox);
            this.Controls.Add(this.checkBUTTON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBUTTON;
        private System.Windows.Forms.TextBox primenumbertextbox;
    }
}

