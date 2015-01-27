namespace KingdomHearts2
{
    partial class helpwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpwindow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.srclink = new System.Windows.Forms.LinkLabel();
            this.nguthread = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(378, 301);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(15, 345);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // srclink
            // 
            this.srclink.AutoSize = true;
            this.srclink.Location = new System.Drawing.Point(255, 350);
            this.srclink.Name = "srclink";
            this.srclink.Size = new System.Drawing.Size(41, 13);
            this.srclink.TabIndex = 2;
            this.srclink.TabStop = true;
            this.srclink.Text = "Source";
            this.srclink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.srclink_LinkClicked);
            // 
            // nguthread
            // 
            this.nguthread.AutoSize = true;
            this.nguthread.Location = new System.Drawing.Point(317, 350);
            this.nguthread.Name = "nguthread";
            this.nguthread.Size = new System.Drawing.Size(76, 13);
            this.nguthread.TabIndex = 3;
            this.nguthread.TabStop = true;
            this.nguthread.Text = "Official Thread";
            this.nguthread.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nguthread_LinkClicked);
            // 
            // helpwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 380);
            this.Controls.Add(this.nguthread);
            this.Controls.Add(this.srclink);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "helpwindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.LinkLabel srclink;
        private System.Windows.Forms.LinkLabel nguthread;


    }
}