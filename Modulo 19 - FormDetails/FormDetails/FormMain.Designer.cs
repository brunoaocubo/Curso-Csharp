namespace FormDetails
{
    partial class FormMain
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.btnFormSec = new System.Windows.Forms.Button();
            this.btnFormSecThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.mainTitle.Location = new System.Drawing.Point(13, 13);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(775, 199);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Principal";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormSec
            // 
            this.btnFormSec.BackColor = System.Drawing.Color.Coral;
            this.btnFormSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormSec.Location = new System.Drawing.Point(483, 362);
            this.btnFormSec.Name = "btnFormSec";
            this.btnFormSec.Size = new System.Drawing.Size(145, 76);
            this.btnFormSec.TabIndex = 1;
            this.btnFormSec.Text = "Form Secundário";
            this.btnFormSec.UseVisualStyleBackColor = false;
            this.btnFormSec.Click += new System.EventHandler(this.btnFormSec_Click);
            // 
            // btnFormSecThread
            // 
            this.btnFormSecThread.BackColor = System.Drawing.Color.Coral;
            this.btnFormSecThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormSecThread.Location = new System.Drawing.Point(643, 362);
            this.btnFormSecThread.Name = "btnFormSecThread";
            this.btnFormSecThread.Size = new System.Drawing.Size(145, 76);
            this.btnFormSecThread.TabIndex = 2;
            this.btnFormSecThread.Text = "Form Secundário c/ Thread";
            this.btnFormSecThread.UseVisualStyleBackColor = false;
            this.btnFormSecThread.Click += new System.EventHandler(this.btnFormSecThread_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormSecThread);
            this.Controls.Add(this.btnFormSec);
            this.Controls.Add(this.mainTitle);
            this.Name = "FormMain";
            this.Text = "Form Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button btnFormSec;
        private System.Windows.Forms.Button btnFormSecThread;
    }
}

