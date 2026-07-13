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
            this.btnOrderby = new System.Windows.Forms.Button();
            this.btnGroupby = new System.Windows.Forms.Button();
            this.btnAggregate = new System.Windows.Forms.Button();
            this.btnElement = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 29;
            this.listResult.Location = new System.Drawing.Point(13, 13);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(598, 439);
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
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(617, 67);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(171, 48);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWhere.Location = new System.Drawing.Point(617, 121);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(171, 49);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderby
            // 
            this.btnOrderby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrderby.Location = new System.Drawing.Point(617, 176);
            this.btnOrderby.Name = "btnOrderby";
            this.btnOrderby.Size = new System.Drawing.Size(171, 49);
            this.btnOrderby.TabIndex = 4;
            this.btnOrderby.Text = "Order By";
            this.btnOrderby.UseVisualStyleBackColor = true;
            this.btnOrderby.Click += new System.EventHandler(this.btnOrderby_Click);
            // 
            // btnGroupby
            // 
            this.btnGroupby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGroupby.Location = new System.Drawing.Point(617, 231);
            this.btnGroupby.Name = "btnGroupby";
            this.btnGroupby.Size = new System.Drawing.Size(171, 49);
            this.btnGroupby.TabIndex = 5;
            this.btnGroupby.Text = "Group By";
            this.btnGroupby.UseVisualStyleBackColor = true;
            this.btnGroupby.Click += new System.EventHandler(this.btnGroupby_Click);
            // 
            // btnAggregate
            // 
            this.btnAggregate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAggregate.Location = new System.Drawing.Point(617, 286);
            this.btnAggregate.Name = "btnAggregate";
            this.btnAggregate.Size = new System.Drawing.Size(171, 49);
            this.btnAggregate.TabIndex = 6;
            this.btnAggregate.Text = "Operadores de Agregação";
            this.btnAggregate.UseVisualStyleBackColor = true;
            this.btnAggregate.Click += new System.EventHandler(this.btnAggregate_Click);
            // 
            // btnElement
            // 
            this.btnElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnElement.Location = new System.Drawing.Point(617, 341);
            this.btnElement.Name = "btnElement";
            this.btnElement.Size = new System.Drawing.Size(171, 49);
            this.btnElement.TabIndex = 7;
            this.btnElement.Text = "Operadores de Elemento";
            this.btnElement.UseVisualStyleBackColor = true;
            this.btnElement.Click += new System.EventHandler(this.btnElement_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLambda.Location = new System.Drawing.Point(617, 396);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(171, 49);
            this.btnLambda.TabIndex = 8;
            this.btnLambda.Text = "Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnElement);
            this.Controls.Add(this.btnAggregate);
            this.Controls.Add(this.btnGroupby);
            this.Controls.Add(this.btnOrderby);
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
        private System.Windows.Forms.Button btnOrderby;
        private System.Windows.Forms.Button btnGroupby;
        private System.Windows.Forms.Button btnAggregate;
        private System.Windows.Forms.Button btnElement;
        private System.Windows.Forms.Button btnLambda;
    }
}

