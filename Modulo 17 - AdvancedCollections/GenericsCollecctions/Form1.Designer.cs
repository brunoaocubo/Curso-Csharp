namespace GenericsCollecctions
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
            this.btnList = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnList.Location = new System.Drawing.Point(641, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(147, 42);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 20;
            this.listResult.Location = new System.Drawing.Point(13, 12);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(622, 424);
            this.listResult.TabIndex = 1;
            // 
            // btnHashSet
            // 
            this.btnHashSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHashSet.Location = new System.Drawing.Point(641, 60);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(147, 42);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button btnHashSet;
    }
}

