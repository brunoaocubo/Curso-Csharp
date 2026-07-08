namespace ReadWrite_Files
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
            this.btnWriteText = new System.Windows.Forms.Button();
            this.btnReadText = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWriteText
            // 
            this.btnWriteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnWriteText.Location = new System.Drawing.Point(14, 386);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(154, 53);
            this.btnWriteText.TabIndex = 1;
            this.btnWriteText.Text = "Escrever Txt";
            this.btnWriteText.UseVisualStyleBackColor = true;
            this.btnWriteText.Click += new System.EventHandler(this.btnWriteText_Click);
            // 
            // btnReadText
            // 
            this.btnReadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReadText.Location = new System.Drawing.Point(189, 385);
            this.btnReadText.Name = "btnReadText";
            this.btnReadText.Size = new System.Drawing.Size(154, 53);
            this.btnReadText.TabIndex = 2;
            this.btnReadText.Text = "Ler Txt";
            this.btnReadText.UseVisualStyleBackColor = true;
            this.btnReadText.Click += new System.EventHandler(this.btnReadText_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtContent.Location = new System.Drawing.Point(13, 13);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(775, 367);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnReadText);
            this.Controls.Add(this.btnWriteText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWriteText;
        private System.Windows.Forms.Button btnReadText;
        private System.Windows.Forms.RichTextBox txtContent;
    }
}

