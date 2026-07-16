namespace FormServer
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
            this.titleTxt = new System.Windows.Forms.Label();
            this.listLogs = new System.Windows.Forms.ListBox();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.inputPortServer = new System.Windows.Forms.NumericUpDown();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.btnDisconnectServer = new System.Windows.Forms.Button();
            this.linkSelectFolder = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.inputPortServer)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Arial", 18F);
            this.titleTxt.Location = new System.Drawing.Point(144, 26);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(395, 32);
            this.titleTxt.TabIndex = 0;
            this.titleTxt.Text = "Servidor para Compartilhar Arquivo";
            // 
            // listLogs
            // 
            this.listLogs.BackColor = System.Drawing.SystemColors.Info;
            this.listLogs.Font = new System.Drawing.Font("Arial", 12F);
            this.listLogs.FormattingEnabled = true;
            this.listLogs.ItemHeight = 18;
            this.listLogs.Location = new System.Drawing.Point(13, 208);
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(631, 184);
            this.listLogs.TabIndex = 1;
            // 
            // inputIP
            // 
            this.inputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputIP.Location = new System.Drawing.Point(13, 83);
            this.inputIP.Multiline = true;
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(309, 26);
            this.inputIP.TabIndex = 2;
            this.inputIP.Text = "127.0.0.1";
            // 
            // inputPortServer
            // 
            this.inputPortServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputPortServer.Location = new System.Drawing.Point(328, 82);
            this.inputPortServer.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputPortServer.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputPortServer.Name = "inputPortServer";
            this.inputPortServer.Size = new System.Drawing.Size(68, 27);
            this.inputPortServer.TabIndex = 3;
            this.inputPortServer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConnectServer.Location = new System.Drawing.Point(13, 116);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(309, 41);
            this.btnConnectServer.TabIndex = 4;
            this.btnConnectServer.Text = "Estabelecer Conexão";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // btnDisconnectServer
            // 
            this.btnDisconnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDisconnectServer.Location = new System.Drawing.Point(328, 116);
            this.btnDisconnectServer.Name = "btnDisconnectServer";
            this.btnDisconnectServer.Size = new System.Drawing.Size(299, 41);
            this.btnDisconnectServer.TabIndex = 5;
            this.btnDisconnectServer.Text = "Parar Servidor";
            this.btnDisconnectServer.UseVisualStyleBackColor = true;
            this.btnDisconnectServer.Click += new System.EventHandler(this.btnDisconnectServer_Click);
            // 
            // linkSelectFolder
            // 
            this.linkSelectFolder.AutoSize = true;
            this.linkSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.linkSelectFolder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSelectFolder.Location = new System.Drawing.Point(12, 170);
            this.linkSelectFolder.Name = "linkSelectFolder";
            this.linkSelectFolder.Size = new System.Drawing.Size(267, 20);
            this.linkSelectFolder.TabIndex = 6;
            this.linkSelectFolder.TabStop = true;
            this.linkSelectFolder.Text = "Clique para selecionar a pasta...";
            this.linkSelectFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectFolder_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 406);
            this.Controls.Add(this.linkSelectFolder);
            this.Controls.Add(this.btnDisconnectServer);
            this.Controls.Add(this.btnConnectServer);
            this.Controls.Add(this.inputPortServer);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.listLogs);
            this.Controls.Add(this.titleTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputPortServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.ListBox listLogs;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.NumericUpDown inputPortServer;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.Button btnDisconnectServer;
        private System.Windows.Forms.LinkLabel linkSelectFolder;
    }
}

