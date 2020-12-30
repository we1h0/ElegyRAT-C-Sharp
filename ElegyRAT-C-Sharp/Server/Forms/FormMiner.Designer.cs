namespace Server.Forms
{
    partial class FormMiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiner));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboInjection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPool = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboInjection);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWallet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPool);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(560, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "注入:";
            // 
            // comboInjection
            // 
            this.comboInjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInjection.FormattingEnabled = true;
            this.comboInjection.Items.AddRange(new object[] {
            "RegAsm.exe",
            "MSBuild.exe",
            "RegSvcs.exe"});
            this.comboInjection.Location = new System.Drawing.Point(103, 107);
            this.comboInjection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboInjection.Name = "comboInjection";
            this.comboInjection.Size = new System.Drawing.Size(135, 20);
            this.comboInjection.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码";
            // 
            // txtPass
            // 
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtxmrPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPass.Location = new System.Drawing.Point(103, 78);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(443, 21);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = global::Server.Properties.Settings.Default.txtxmrPass;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wallet";
            // 
            // txtWallet
            // 
            this.txtWallet.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtWallet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWallet.Location = new System.Drawing.Point(103, 50);
            this.txtWallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.Size = new System.Drawing.Size(443, 21);
            this.txtWallet.TabIndex = 2;
            this.txtWallet.Text = global::Server.Properties.Settings.Default.txtWallet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pool:Port";
            // 
            // txtPool
            // 
            this.txtPool.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtPool", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPool.Location = new System.Drawing.Point(103, 24);
            this.txtPool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPool.Name = "txtPool";
            this.txtPool.Size = new System.Drawing.Size(443, 21);
            this.txtPool.TabIndex = 0;
            this.txtPool.Text = global::Server.Properties.Settings.Default.txtPool;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(8, 164);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(560, 35);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FormMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 214);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XMR Miner | ElegyRAT";
            this.Load += new System.EventHandler(this.FormMiner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPool;
        public System.Windows.Forms.TextBox txtWallet;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboInjection;
    }
}