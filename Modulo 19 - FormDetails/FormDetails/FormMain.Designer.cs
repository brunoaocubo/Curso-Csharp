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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp_Dev = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp_Versão = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.inputSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.mainTitle.Location = new System.Drawing.Point(12, 27);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(775, 196);
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
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.inputSearch});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOption_NewFile,
            this.menuOption_OpenFile,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 23);
            this.menuFile.Text = "File";
            // 
            // menuOption_NewFile
            // 
            this.menuOption_NewFile.Image = global::FormDetails.Properties.Resources.extract_detail_icon;
            this.menuOption_NewFile.Name = "menuOption_NewFile";
            this.menuOption_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuOption_NewFile.Size = new System.Drawing.Size(180, 22);
            this.menuOption_NewFile.Text = "Novo";
            this.menuOption_NewFile.Click += new System.EventHandler(this.menuOption_NewFile_Click);
            // 
            // menuOption_OpenFile
            // 
            this.menuOption_OpenFile.Image = global::FormDetails.Properties.Resources.extract_detail_icon;
            this.menuOption_OpenFile.Name = "menuOption_OpenFile";
            this.menuOption_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuOption_OpenFile.Size = new System.Drawing.Size(180, 22);
            this.menuOption_OpenFile.Text = "Abrir";
            this.menuOption_OpenFile.Click += new System.EventHandler(this.menuOption_OpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::FormDetails.Properties.Resources.exit_icon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelp_Sobre});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 23);
            this.menuHelp.Text = "Help";
            // 
            // mHelp_Sobre
            // 
            this.mHelp_Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelp_Dev,
            this.mHelp_Versão});
            this.mHelp_Sobre.Name = "mHelp_Sobre";
            this.mHelp_Sobre.Size = new System.Drawing.Size(104, 22);
            this.mHelp_Sobre.Text = "Sobre";
            // 
            // mHelp_Dev
            // 
            this.mHelp_Dev.Name = "mHelp_Dev";
            this.mHelp_Dev.Size = new System.Drawing.Size(152, 22);
            this.mHelp_Dev.Text = "Desenvolvedor";
            this.mHelp_Dev.Click += new System.EventHandler(this.mHelp_Dev_Click);
            // 
            // mHelp_Versão
            // 
            this.mHelp_Versão.Name = "mHelp_Versão";
            this.mHelp_Versão.Size = new System.Drawing.Size(152, 22);
            this.mHelp_Versão.Text = "Versão";
            this.mHelp_Versão.Click += new System.EventHandler(this.mHelp_Versão_Click);
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 23);
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
            // 
            // inputSearch
            // 
            this.inputSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(200, 23);
            this.inputSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputSearch_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormSecThread);
            this.Controls.Add(this.btnFormSec);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.Text = "Form Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button btnFormSec;
        private System.Windows.Forms.Button btnFormSecThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOption_NewFile;
        private System.Windows.Forms.ToolStripMenuItem menuOption_OpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelp_Sobre;
        private System.Windows.Forms.ToolStripMenuItem mHelp_Dev;
        private System.Windows.Forms.ToolStripMenuItem mHelp_Versão;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox inputSearch;
    }
}

