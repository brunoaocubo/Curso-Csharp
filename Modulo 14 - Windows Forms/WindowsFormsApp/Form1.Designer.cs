namespace WindowsFormsApp
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
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bornDate = new System.Windows.Forms.DateTimePicker();
            this.civilState = new System.Windows.Forms.ComboBox();
            this.telNumber = new System.Windows.Forms.MaskedTextBox();
            this.checkHouse = new System.Windows.Forms.CheckBox();
            this.checkVehicle = new System.Windows.Forms.CheckBox();
            this.F = new System.Windows.Forms.RadioButton();
            this.M = new System.Windows.Forms.RadioButton();
            this.O = new System.Windows.Forms.RadioButton();
            this.listRegisters = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_name.Location = new System.Drawing.Point(3, 3);
            this.lb_name.Margin = new System.Windows.Forms.Padding(3);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(173, 30);
            this.lb_name.TabIndex = 0;
            this.lb_name.Tag = "Label_Main";
            this.lb_name.Text = "Nome";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Label_Main";
            this.label1.Text = "Data Nascimento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Label_Main";
            this.label2.Text = "Estado Civil";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 3;
            this.label3.Tag = "Label_Main";
            this.label3.Text = "Telefone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(182, 5);
            this.name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.name.MinimumSize = new System.Drawing.Size(200, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(519, 26);
            this.name.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57386F));
            this.tableLayoutPanel1.Controls.Add(this.bornDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.civilState, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.telNumber, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 146);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bornDate
            // 
            this.bornDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bornDate.Location = new System.Drawing.Point(182, 41);
            this.bornDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bornDate.MaxDate = new System.DateTime(2199, 12, 31, 0, 0, 0, 0);
            this.bornDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.bornDate.Name = "bornDate";
            this.bornDate.Size = new System.Drawing.Size(519, 26);
            this.bornDate.TabIndex = 5;
            // 
            // civilState
            // 
            this.civilState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.civilState.FormattingEnabled = true;
            this.civilState.Location = new System.Drawing.Point(182, 77);
            this.civilState.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.civilState.Name = "civilState";
            this.civilState.Size = new System.Drawing.Size(385, 28);
            this.civilState.TabIndex = 7;
            // 
            // telNumber
            // 
            this.telNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.telNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.telNumber.Location = new System.Drawing.Point(182, 115);
            this.telNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.telNumber.Mask = "(99) 00000-0000";
            this.telNumber.Name = "telNumber";
            this.telNumber.Size = new System.Drawing.Size(385, 26);
            this.telNumber.TabIndex = 5;
            this.telNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // checkHouse
            // 
            this.checkHouse.Location = new System.Drawing.Point(190, 180);
            this.checkHouse.Name = "checkHouse";
            this.checkHouse.Size = new System.Drawing.Size(123, 17);
            this.checkHouse.TabIndex = 0;
            this.checkHouse.Text = "Possui Casa Própria";
            this.checkHouse.UseVisualStyleBackColor = true;
            // 
            // checkVehicle
            // 
            this.checkVehicle.Location = new System.Drawing.Point(190, 203);
            this.checkVehicle.Name = "checkVehicle";
            this.checkVehicle.Size = new System.Drawing.Size(123, 17);
            this.checkVehicle.TabIndex = 5;
            this.checkVehicle.Text = "Possui Veículo";
            this.checkVehicle.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(0, 19);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(67, 17);
            this.F.TabIndex = 6;
            this.F.TabStop = true;
            this.F.Text = "Feminino";
            this.F.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(122, 19);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(73, 17);
            this.M.TabIndex = 7;
            this.M.TabStop = true;
            this.M.Text = "Masculino";
            this.M.UseVisualStyleBackColor = true;
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Location = new System.Drawing.Point(0, 44);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(51, 17);
            this.O.TabIndex = 8;
            this.O.TabStop = true;
            this.O.Text = "Outro";
            this.O.UseVisualStyleBackColor = true;
            // 
            // listRegisters
            // 
            this.listRegisters.FormattingEnabled = true;
            this.listRegisters.Location = new System.Drawing.Point(13, 394);
            this.listRegisters.Name = "listRegisters";
            this.listRegisters.Size = new System.Drawing.Size(704, 134);
            this.listRegisters.TabIndex = 9;
            this.listRegisters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRegisters_MouseDoubleClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.O);
            this.groupBox.Controls.Add(this.M);
            this.groupBox.Controls.Add(this.F);
            this.groupBox.Location = new System.Drawing.Point(190, 236);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(201, 67);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Sexo";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(25, 319);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 69);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Cadastrar / Alterar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 319);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 69);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(527, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 69);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(632, 290);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 14;
            this.update.Text = "Atualizar";
            this.update.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 540);
            this.Controls.Add(this.update);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listRegisters);
            this.Controls.Add(this.checkVehicle);
            this.Controls.Add(this.checkHouse);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker bornDate;
        private System.Windows.Forms.ComboBox civilState;
        private System.Windows.Forms.MaskedTextBox telNumber;
        private System.Windows.Forms.CheckBox checkHouse;
        private System.Windows.Forms.CheckBox checkVehicle;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.RadioButton M;
        private System.Windows.Forms.RadioButton O;
        private System.Windows.Forms.ListBox listRegisters;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button update;
    }
}

