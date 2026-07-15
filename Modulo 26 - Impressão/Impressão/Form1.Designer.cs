namespace Impressão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.btnVisualizer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnVisualizerStandard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPrint.Location = new System.Drawing.Point(501, 378);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(288, 60);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            this.printDialog1.HelpRequest += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(13, 13);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(489, 425);
            this.printPreviewControl1.TabIndex = 1;
            // 
            // btnVisualizer
            // 
            this.btnVisualizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVisualizer.Location = new System.Drawing.Point(500, 13);
            this.btnVisualizer.Name = "btnVisualizer";
            this.btnVisualizer.Size = new System.Drawing.Size(288, 60);
            this.btnVisualizer.TabIndex = 2;
            this.btnVisualizer.Text = "Visualizar";
            this.btnVisualizer.UseVisualStyleBackColor = true;
            this.btnVisualizer.Click += new System.EventHandler(this.btnVisualizer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(500, 79);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 60);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNext.Location = new System.Drawing.Point(663, 79);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 60);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Próximo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnVisualizerStandard
            // 
            this.btnVisualizerStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVisualizerStandard.Location = new System.Drawing.Point(500, 312);
            this.btnVisualizerStandard.Name = "btnVisualizerStandard";
            this.btnVisualizerStandard.Size = new System.Drawing.Size(288, 60);
            this.btnVisualizerStandard.TabIndex = 5;
            this.btnVisualizerStandard.Text = "Visualizar Padrão";
            this.btnVisualizerStandard.UseVisualStyleBackColor = true;
            this.btnVisualizerStandard.Click += new System.EventHandler(this.btnVisualizerStandard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizerStandard);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVisualizer);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button btnVisualizer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnVisualizerStandard;
    }
}

