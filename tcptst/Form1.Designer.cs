namespace tcptst
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
            this.iptxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startbttn = new System.Windows.Forms.Button();
            this.loglstbx = new System.Windows.Forms.ListBox();
            this.stopbttn = new System.Windows.Forms.Button();
            this.sendbttn = new System.Windows.Forms.Button();
            this.mssgtxt = new System.Windows.Forms.TextBox();
            this.iplbl = new System.Windows.Forms.Label();
            this.mssglbl = new System.Windows.Forms.Label();
            this.clrbttn = new System.Windows.Forms.Button();
            this.connectbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iptxt
            // 
            this.iptxt.Location = new System.Drawing.Point(770, 151);
            this.iptxt.Name = "iptxt";
            this.iptxt.Size = new System.Drawing.Size(179, 27);
            this.iptxt.TabIndex = 0;
            this.iptxt.Text = "192.168.1.254";
            this.iptxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "log";
            // 
            // startbttn
            // 
            this.startbttn.Location = new System.Drawing.Point(1029, 58);
            this.startbttn.Name = "startbttn";
            this.startbttn.Size = new System.Drawing.Size(94, 29);
            this.startbttn.TabIndex = 2;
            this.startbttn.Text = "start";
            this.startbttn.UseVisualStyleBackColor = true;
            this.startbttn.Click += new System.EventHandler(this.startbttn_Click);
            // 
            // loglstbx
            // 
            this.loglstbx.FormattingEnabled = true;
            this.loglstbx.ItemHeight = 20;
            this.loglstbx.Location = new System.Drawing.Point(46, 104);
            this.loglstbx.Name = "loglstbx";
            this.loglstbx.Size = new System.Drawing.Size(701, 404);
            this.loglstbx.TabIndex = 3;
            // 
            // stopbttn
            // 
            this.stopbttn.Location = new System.Drawing.Point(585, 44);
            this.stopbttn.Name = "stopbttn";
            this.stopbttn.Size = new System.Drawing.Size(94, 29);
            this.stopbttn.TabIndex = 4;
            this.stopbttn.Text = "disconnect";
            this.stopbttn.UseVisualStyleBackColor = true;
            this.stopbttn.Click += new System.EventHandler(this.stopbttn_Click);
            // 
            // sendbttn
            // 
            this.sendbttn.Location = new System.Drawing.Point(975, 274);
            this.sendbttn.Name = "sendbttn";
            this.sendbttn.Size = new System.Drawing.Size(94, 29);
            this.sendbttn.TabIndex = 5;
            this.sendbttn.Text = "send";
            this.sendbttn.UseVisualStyleBackColor = true;
            this.sendbttn.Click += new System.EventHandler(this.sendbttn_Click);
            // 
            // mssgtxt
            // 
            this.mssgtxt.Location = new System.Drawing.Point(770, 274);
            this.mssgtxt.Name = "mssgtxt";
            this.mssgtxt.Size = new System.Drawing.Size(179, 27);
            this.mssgtxt.TabIndex = 6;
            this.mssgtxt.Text = "040000000103E803E8";
            this.mssgtxt.TextChanged += new System.EventHandler(this.mssgtxt_TextChanged);
            // 
            // iplbl
            // 
            this.iplbl.AutoSize = true;
            this.iplbl.Location = new System.Drawing.Point(770, 114);
            this.iplbl.Name = "iplbl";
            this.iplbl.Size = new System.Drawing.Size(22, 20);
            this.iplbl.TabIndex = 7;
            this.iplbl.Text = "ip";
            // 
            // mssglbl
            // 
            this.mssglbl.AutoSize = true;
            this.mssglbl.Location = new System.Drawing.Point(770, 238);
            this.mssglbl.Name = "mssglbl";
            this.mssglbl.Size = new System.Drawing.Size(43, 20);
            this.mssglbl.TabIndex = 8;
            this.mssglbl.Text = "mssg";
            // 
            // clrbttn
            // 
            this.clrbttn.Location = new System.Drawing.Point(814, 359);
            this.clrbttn.Name = "clrbttn";
            this.clrbttn.Size = new System.Drawing.Size(94, 29);
            this.clrbttn.TabIndex = 9;
            this.clrbttn.Text = "clear";
            this.clrbttn.UseVisualStyleBackColor = true;
            this.clrbttn.Click += new System.EventHandler(this.clrbttn_Click);
            // 
            // connectbttn
            // 
            this.connectbttn.Location = new System.Drawing.Point(451, 44);
            this.connectbttn.Name = "connectbttn";
            this.connectbttn.Size = new System.Drawing.Size(94, 29);
            this.connectbttn.TabIndex = 10;
            this.connectbttn.Text = "connect";
            this.connectbttn.UseVisualStyleBackColor = true;
            this.connectbttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 530);
            this.Controls.Add(this.connectbttn);
            this.Controls.Add(this.clrbttn);
            this.Controls.Add(this.mssglbl);
            this.Controls.Add(this.iplbl);
            this.Controls.Add(this.mssgtxt);
            this.Controls.Add(this.sendbttn);
            this.Controls.Add(this.stopbttn);
            this.Controls.Add(this.loglstbx);
            this.Controls.Add(this.startbttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iptxt);
            this.Name = "Form1";
            this.Text = "Tcpclient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox iptxt;
        private Label label1;
        private Button startbttn;
        private ListBox loglstbx;
        private Button stopbttn;
        private Button sendbttn;
        private TextBox mssgtxt;
        private Label iplbl;
        private Label mssglbl;
        private Button clrbttn;
        private Button connectbttn;
    }
}