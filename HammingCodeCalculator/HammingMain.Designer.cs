namespace HammingCodeCalculator
{
    partial class HammingMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEncVisual = new System.Windows.Forms.DataGridView();
            this.lbxEncParity = new System.Windows.Forms.ListBox();
            this.txbEncEncoded = new System.Windows.Forms.TextBox();
            this.txbEncRawInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDecVisual = new System.Windows.Forms.DataGridView();
            this.lbxDecParity = new System.Windows.Forms.ListBox();
            this.txbDecRawMessage = new System.Windows.Forms.TextBox();
            this.txbDecHammingCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDecValidate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncVisual)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 645);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEncVisual);
            this.tabPage1.Controls.Add(this.lbxEncParity);
            this.tabPage1.Controls.Add(this.txbEncEncoded);
            this.tabPage1.Controls.Add(this.txbEncRawInput);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(409, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEncVisual
            // 
            this.dgvEncVisual.AllowUserToAddRows = false;
            this.dgvEncVisual.AllowUserToDeleteRows = false;
            this.dgvEncVisual.AllowUserToOrderColumns = true;
            this.dgvEncVisual.AllowUserToResizeColumns = false;
            this.dgvEncVisual.AllowUserToResizeRows = false;
            this.dgvEncVisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEncVisual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEncVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncVisual.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncVisual.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEncVisual.Location = new System.Drawing.Point(7, 46);
            this.dgvEncVisual.Name = "dgvEncVisual";
            this.dgvEncVisual.ReadOnly = true;
            this.dgvEncVisual.RowHeadersVisible = false;
            this.dgvEncVisual.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvEncVisual.ShowCellErrors = false;
            this.dgvEncVisual.ShowCellToolTips = false;
            this.dgvEncVisual.ShowEditingIcon = false;
            this.dgvEncVisual.Size = new System.Drawing.Size(395, 98);
            this.dgvEncVisual.TabIndex = 4;
            this.dgvEncVisual.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFormater);
            // 
            // lbxEncParity
            // 
            this.lbxEncParity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxEncParity.FormattingEnabled = true;
            this.lbxEncParity.ItemHeight = 19;
            this.lbxEncParity.Location = new System.Drawing.Point(122, 183);
            this.lbxEncParity.Name = "lbxEncParity";
            this.lbxEncParity.Size = new System.Drawing.Size(279, 137);
            this.lbxEncParity.TabIndex = 3;
            // 
            // txbEncEncoded
            // 
            this.txbEncEncoded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEncEncoded.Location = new System.Drawing.Point(122, 150);
            this.txbEncEncoded.Name = "txbEncEncoded";
            this.txbEncEncoded.ReadOnly = true;
            this.txbEncEncoded.Size = new System.Drawing.Size(280, 27);
            this.txbEncEncoded.TabIndex = 2;
            // 
            // txbEncRawInput
            // 
            this.txbEncRawInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEncRawInput.Location = new System.Drawing.Point(122, 13);
            this.txbEncRawInput.Name = "txbEncRawInput";
            this.txbEncRawInput.Size = new System.Drawing.Size(280, 27);
            this.txbEncRawInput.TabIndex = 1;
            this.txbEncRawInput.TextChanged += new System.EventHandler(this.txbEncRawInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parity Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hamming-Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Message";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbDecValidate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgvDecVisual);
            this.tabPage2.Controls.Add(this.lbxDecParity);
            this.tabPage2.Controls.Add(this.txbDecRawMessage);
            this.tabPage2.Controls.Add(this.txbDecHammingCode);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(596, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDecVisual
            // 
            this.dgvDecVisual.AllowUserToAddRows = false;
            this.dgvDecVisual.AllowUserToDeleteRows = false;
            this.dgvDecVisual.AllowUserToOrderColumns = true;
            this.dgvDecVisual.AllowUserToResizeColumns = false;
            this.dgvDecVisual.AllowUserToResizeRows = false;
            this.dgvDecVisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDecVisual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDecVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecVisual.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDecVisual.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDecVisual.Location = new System.Drawing.Point(7, 46);
            this.dgvDecVisual.Name = "dgvDecVisual";
            this.dgvDecVisual.ReadOnly = true;
            this.dgvDecVisual.RowHeadersVisible = false;
            this.dgvDecVisual.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDecVisual.ShowCellErrors = false;
            this.dgvDecVisual.ShowCellToolTips = false;
            this.dgvDecVisual.ShowEditingIcon = false;
            this.dgvDecVisual.Size = new System.Drawing.Size(582, 98);
            this.dgvDecVisual.TabIndex = 11;
            this.dgvDecVisual.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFormater);
            // 
            // lbxDecParity
            // 
            this.lbxDecParity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDecParity.FormattingEnabled = true;
            this.lbxDecParity.ItemHeight = 19;
            this.lbxDecParity.Location = new System.Drawing.Point(128, 216);
            this.lbxDecParity.Name = "lbxDecParity";
            this.lbxDecParity.Size = new System.Drawing.Size(460, 384);
            this.lbxDecParity.TabIndex = 10;
            // 
            // txbDecRawMessage
            // 
            this.txbDecRawMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDecRawMessage.Location = new System.Drawing.Point(128, 183);
            this.txbDecRawMessage.Name = "txbDecRawMessage";
            this.txbDecRawMessage.ReadOnly = true;
            this.txbDecRawMessage.Size = new System.Drawing.Size(460, 27);
            this.txbDecRawMessage.TabIndex = 9;
            // 
            // txbDecHammingCode
            // 
            this.txbDecHammingCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDecHammingCode.Location = new System.Drawing.Point(128, 13);
            this.txbDecHammingCode.Name = "txbDecHammingCode";
            this.txbDecHammingCode.Size = new System.Drawing.Size(461, 27);
            this.txbDecHammingCode.TabIndex = 8;
            this.txbDecHammingCode.TextChanged += new System.EventHandler(this.txbDecHammingCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parity Bits (Corr.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hamming-Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Message (Corr.)";
            // 
            // txbDecValidate
            // 
            this.txbDecValidate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDecValidate.Location = new System.Drawing.Point(128, 150);
            this.txbDecValidate.Name = "txbDecValidate";
            this.txbDecValidate.ReadOnly = true;
            this.txbDecValidate.Size = new System.Drawing.Size(460, 27);
            this.txbDecValidate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Validation";
            // 
            // HammingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 645);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(294, 335);
            this.Name = "HammingMain";
            this.Text = "Hamming Code Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncVisual)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEncVisual;
        private System.Windows.Forms.ListBox lbxEncParity;
        private System.Windows.Forms.TextBox txbEncEncoded;
        private System.Windows.Forms.TextBox txbEncRawInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDecVisual;
        private System.Windows.Forms.ListBox lbxDecParity;
        private System.Windows.Forms.TextBox txbDecRawMessage;
        private System.Windows.Forms.TextBox txbDecHammingCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDecValidate;
        private System.Windows.Forms.Label label7;
    }
}

