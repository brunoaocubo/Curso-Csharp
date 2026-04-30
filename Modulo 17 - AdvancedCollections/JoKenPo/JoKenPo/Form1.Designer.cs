namespace JoKenPo
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
            this.txtUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picturePC = new System.Windows.Forms.Panel();
            this.txtPC = new System.Windows.Forms.Label();
            this.pictureResult = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.picturePC.SuspendLayout();
            this.pictureResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Red;
            this.txtUser.Location = new System.Drawing.Point(113, 150);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(56, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha pedra, papel ou tesoura...";
            // 
            // picturePC
            // 
            this.picturePC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePC.Controls.Add(this.txtPC);
            this.picturePC.Location = new System.Drawing.Point(291, 79);
            this.picturePC.Name = "picturePC";
            this.picturePC.Size = new System.Drawing.Size(219, 160);
            this.picturePC.TabIndex = 2;
            // 
            // txtPC
            // 
            this.txtPC.AutoSize = true;
            this.txtPC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPC.ForeColor = System.Drawing.Color.Red;
            this.txtPC.Location = new System.Drawing.Point(89, 71);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(37, 22);
            this.txtPC.TabIndex = 0;
            this.txtPC.Text = "PC";
            // 
            // pictureResult
            // 
            this.pictureResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureResult.Controls.Add(this.result);
            this.pictureResult.Location = new System.Drawing.Point(549, 79);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(219, 160);
            this.pictureResult.TabIndex = 3;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(65, 71);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(102, 22);
            this.result.TabIndex = 0;
            this.result.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(262, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(520, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Transparent;
            this.btnRock.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRock.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRock.Location = new System.Drawing.Point(33, 246);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(219, 164);
            this.btnRock.TabIndex = 6;
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.Location = new System.Drawing.Point(291, 246);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(219, 164);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.Transparent;
            this.btnScissors.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissors.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissors.Location = new System.Drawing.Point(549, 246);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(219, 164);
            this.btnScissors.TabIndex = 8;
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.Location = new System.Drawing.Point(33, 79);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(219, 161);
            this.pictureUser.TabIndex = 9;
            this.pictureUser.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureResult);
            this.Controls.Add(this.picturePC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.picturePC.ResumeLayout(false);
            this.picturePC.PerformLayout();
            this.pictureResult.ResumeLayout(false);
            this.pictureResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel picturePC;
        private System.Windows.Forms.Label txtPC;
        private System.Windows.Forms.Panel pictureResult;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox pictureUser;
    }
}

