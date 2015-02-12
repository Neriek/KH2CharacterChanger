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
            this.updatebtn = new System.Windows.Forms.Button();
            this.srclink = new System.Windows.Forms.LinkLabel();
            this.nguthread = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credits: \r\nThose who found the codes:\r\nkronoaxis, Kreativity, Motivez, x66dme66x," +
    " and kuxir97\r\n\r\nPlugin Development:\r\nNeriek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 182);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // helpwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nguthread);
            this.Controls.Add(this.srclink);
            this.Controls.Add(this.updatebtn);
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

        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.LinkLabel srclink;
        private System.Windows.Forms.LinkLabel nguthread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}