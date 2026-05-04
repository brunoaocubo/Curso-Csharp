namespace FormDetails
{
    partial class FormSeccondary
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormPrincipal = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 199);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secundária";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormPrincipal
            // 
            this.btnFormPrincipal.BackColor = System.Drawing.Color.Coral;
            this.btnFormPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormPrincipal.Location = new System.Drawing.Point(643, 362);
            this.btnFormPrincipal.Name = "btnFormPrincipal";
            this.btnFormPrincipal.Size = new System.Drawing.Size(145, 76);
            this.btnFormPrincipal.TabIndex = 2;
            this.btnFormPrincipal.Text = "Form Principal";
            this.btnFormPrincipal.UseVisualStyleBackColor = false;
            this.btnFormPrincipal.Click += new System.EventHandler(this.btnFormPrincipal_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(210, 211);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(378, 64);
            this.txtMessage.TabIndex = 3;
            // 
            // btnRetorno
            // 
            this.btnRetorno.BackColor = System.Drawing.Color.Coral;
            this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorno.Location = new System.Drawing.Point(492, 362);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(145, 76);
            this.btnRetorno.TabIndex = 4;
            this.btnRetorno.Text = "Retorno";
            this.btnRetorno.UseVisualStyleBackColor = false;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(341, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 76);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSeccondary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRetorno);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnFormPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "FormSeccondary";
            this.Text = "FormSeccondary";
            this.Load += new System.EventHandler(this.FormSeccondary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormPrincipal;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnClose;
    }
}