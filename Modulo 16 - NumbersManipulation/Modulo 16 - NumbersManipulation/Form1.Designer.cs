namespace Modulo_16___NumbersManipulation
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
            this.btn_execute = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_execute
            // 
            this.btn_execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_execute.Location = new System.Drawing.Point(647, 370);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(141, 68);
            this.btn_execute.TabIndex = 0;
            this.btn_execute.Text = "Executar";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // txt_result
            // 
            this.txt_result.AutoSize = true;
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_result.Location = new System.Drawing.Point(13, 13);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(0, 22);
            this.txt_result.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_execute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Label txt_result;
    }
}

