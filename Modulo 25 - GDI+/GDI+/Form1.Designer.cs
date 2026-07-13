namespace GDI_
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(13, 13);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(775, 369);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDraw.Location = new System.Drawing.Point(609, 389);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(179, 49);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Desenhar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnDraw;
    }
}

