namespace LINQ
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
            this.listResult = new System.Windows.Forms.ListBox();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 29;
            this.listResult.Location = new System.Drawing.Point(13, 13);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(598, 410);
            this.listResult.TabIndex = 0;
            // 
            // inputTxt
            // 
            this.inputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputTxt.Location = new System.Drawing.Point(617, 13);
            this.inputTxt.Multiline = true;
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(171, 39);
            this.inputTxt.TabIndex = 1;
            this.inputTxt.Text = "Filtrar...";
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExecute.Location = new System.Drawing.Point(617, 58);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(171, 52);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnWhere.Location = new System.Drawing.Point(617, 116);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(171, 58);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.listResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnWhere;
    }
}

