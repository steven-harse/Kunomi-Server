namespace Server
{
    partial class KunomiServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KunomiServerForm));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMediaURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queueVideoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(13, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(267, 242);
            this.txtLog.TabIndex = 0;
            // 
            // txtMediaURL
            // 
            this.txtMediaURL.Location = new System.Drawing.Point(13, 277);
            this.txtMediaURL.Name = "txtMediaURL";
            this.txtMediaURL.Size = new System.Drawing.Size(267, 20);
            this.txtMediaURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Media URL";
            // 
            // queueVideoBtn
            // 
            this.queueVideoBtn.Location = new System.Drawing.Point(13, 304);
            this.queueVideoBtn.Name = "queueVideoBtn";
            this.queueVideoBtn.Size = new System.Drawing.Size(267, 23);
            this.queueVideoBtn.TabIndex = 3;
            this.queueVideoBtn.Text = "Queue this video";
            this.queueVideoBtn.UseVisualStyleBackColor = true;
            this.queueVideoBtn.Click += new System.EventHandler(this.queueVideoBtn_Click);
            // 
            // SGSserverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 340);
            this.Controls.Add(this.queueVideoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMediaURL);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SGSserverForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kunomi Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMediaURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button queueVideoBtn;
    }
}

