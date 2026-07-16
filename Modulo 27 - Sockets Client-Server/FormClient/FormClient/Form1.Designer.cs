namespace FormClient
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
            this.title = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.inputPort = new System.Windows.Forms.NumericUpDown();
            this.linkFile = new System.Windows.Forms.LinkLabel();
            this.btnSendFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputPort)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title.Location = new System.Drawing.Point(6, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(604, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Cliente para Compartilhar Arquivo";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtStatus.ForeColor = System.Drawing.Color.Green;
            this.txtStatus.Location = new System.Drawing.Point(12, 206);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(598, 157);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "Status";
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputIP
            // 
            this.inputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputIP.Location = new System.Drawing.Point(13, 75);
            this.inputIP.Multiline = true;
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(300, 27);
            this.inputIP.TabIndex = 2;
            this.inputIP.Text = "127.0.0.1";
            // 
            // inputPort
            // 
            this.inputPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputPort.Location = new System.Drawing.Point(319, 76);
            this.inputPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(73, 26);
            this.inputPort.TabIndex = 3;
            this.inputPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // linkFile
            // 
            this.linkFile.AutoSize = true;
            this.linkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.linkFile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkFile.Location = new System.Drawing.Point(12, 113);
            this.linkFile.Name = "linkFile";
            this.linkFile.Size = new System.Drawing.Size(294, 20);
            this.linkFile.TabIndex = 4;
            this.linkFile.TabStop = true;
            this.linkFile.Text = "Clique para selecionar um arquivo...";
            this.linkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFile_LinkClicked);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSendFile.Location = new System.Drawing.Point(12, 146);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(380, 43);
            this.btnSendFile.TabIndex = 5;
            this.btnSendFile.Text = "Enviar Arquivo";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 372);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.linkFile);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.NumericUpDown inputPort;
        private System.Windows.Forms.LinkLabel linkFile;
        private System.Windows.Forms.Button btnSendFile;
    }
}

