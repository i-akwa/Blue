namespace SquareSoft.Blue.UI
{
    partial class LandingPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPercent = new System.Windows.Forms.RadioButton();
            this.radAmount = new System.Windows.Forms.RadioButton();
            this.txtLoyaltyPayMethod = new System.Windows.Forms.TextBox();
            this.txtPosPayMethod = new System.Windows.Forms.TextBox();
            this.txtCashPayMethod = new System.Windows.Forms.TextBox();
            this.chkLoyalty = new System.Windows.Forms.CheckBox();
            this.chkPos = new System.Windows.Forms.CheckBox();
            this.chkCash = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblpaymethod = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnMakePay = new System.Windows.Forms.Button();
            this.CartGrid = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menu1 = new SquareSoft.Blue.UI.BlueControls.Menu();
            this.footer1 = new SquareSoft.Blue.UI.BlueControls.Footer();
            this.headerPages1 = new SquareSoft.Blue.UI.BlueControls.HeaderPages();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialRaisedButton1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menu1);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 646);
            this.panel1.TabIndex = 2;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.materialRaisedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.materialRaisedButton1.FlatAppearance.BorderSize = 0;
            this.materialRaisedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1104, 7);
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Size = new System.Drawing.Size(109, 40);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "SEARCH";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Location = new System.Drawing.Point(249, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 41);
            this.panel3.TabIndex = 2;
            // 
            // txtsearch
            // 
            this.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(2, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(848, 32);
            this.txtsearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtLoyaltyPayMethod);
            this.panel2.Controls.Add(this.txtPosPayMethod);
            this.panel2.Controls.Add(this.txtCashPayMethod);
            this.panel2.Controls.Add(this.chkLoyalty);
            this.panel2.Controls.Add(this.chkPos);
            this.panel2.Controls.Add(this.chkCash);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.lblpaymethod);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.btnMakePay);
            this.panel2.Controls.Add(this.CartGrid);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.ForeColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(245, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 529);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPercent);
            this.groupBox1.Controls.Add(this.radAmount);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(720, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 80);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radPercent
            // 
            this.radPercent.AutoSize = true;
            this.radPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPercent.ForeColor = System.Drawing.Color.Purple;
            this.radPercent.Location = new System.Drawing.Point(6, 43);
            this.radPercent.Name = "radPercent";
            this.radPercent.Size = new System.Drawing.Size(69, 17);
            this.radPercent.TabIndex = 1;
            this.radPercent.TabStop = true;
            this.radPercent.Text = "Percent";
            this.radPercent.UseVisualStyleBackColor = true;
            this.radPercent.CheckedChanged += new System.EventHandler(this.radPercent_CheckedChanged);
            // 
            // radAmount
            // 
            this.radAmount.AutoSize = true;
            this.radAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAmount.ForeColor = System.Drawing.Color.Purple;
            this.radAmount.Location = new System.Drawing.Point(6, 19);
            this.radAmount.Name = "radAmount";
            this.radAmount.Size = new System.Drawing.Size(67, 17);
            this.radAmount.TabIndex = 0;
            this.radAmount.TabStop = true;
            this.radAmount.Text = "Amount";
            this.radAmount.UseVisualStyleBackColor = true;
            this.radAmount.CheckedChanged += new System.EventHandler(this.radAmount_CheckedChanged);
            // 
            // txtLoyaltyPayMethod
            // 
            this.txtLoyaltyPayMethod.Location = new System.Drawing.Point(541, 137);
            this.txtLoyaltyPayMethod.Name = "txtLoyaltyPayMethod";
            this.txtLoyaltyPayMethod.Size = new System.Drawing.Size(173, 20);
            this.txtLoyaltyPayMethod.TabIndex = 15;
            // 
            // txtPosPayMethod
            // 
            this.txtPosPayMethod.Location = new System.Drawing.Point(541, 103);
            this.txtPosPayMethod.Name = "txtPosPayMethod";
            this.txtPosPayMethod.Size = new System.Drawing.Size(173, 20);
            this.txtPosPayMethod.TabIndex = 14;
            // 
            // txtCashPayMethod
            // 
            this.txtCashPayMethod.Location = new System.Drawing.Point(541, 66);
            this.txtCashPayMethod.Name = "txtCashPayMethod";
            this.txtCashPayMethod.Size = new System.Drawing.Size(173, 20);
            this.txtCashPayMethod.TabIndex = 13;
            // 
            // chkLoyalty
            // 
            this.chkLoyalty.AutoSize = true;
            this.chkLoyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoyalty.ForeColor = System.Drawing.Color.Purple;
            this.chkLoyalty.Location = new System.Drawing.Point(443, 137);
            this.chkLoyalty.Name = "chkLoyalty";
            this.chkLoyalty.Size = new System.Drawing.Size(66, 17);
            this.chkLoyalty.TabIndex = 12;
            this.chkLoyalty.Text = "Loyalty";
            this.chkLoyalty.UseVisualStyleBackColor = true;
            this.chkLoyalty.CheckedChanged += new System.EventHandler(this.chkLoyalty_CheckedChanged);
            // 
            // chkPos
            // 
            this.chkPos.AutoSize = true;
            this.chkPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPos.ForeColor = System.Drawing.Color.Purple;
            this.chkPos.Location = new System.Drawing.Point(443, 103);
            this.chkPos.Name = "chkPos";
            this.chkPos.Size = new System.Drawing.Size(51, 17);
            this.chkPos.TabIndex = 11;
            this.chkPos.Text = "POS";
            this.chkPos.UseVisualStyleBackColor = true;
            this.chkPos.CheckedChanged += new System.EventHandler(this.chkPos_CheckedChanged);
            // 
            // chkCash
            // 
            this.chkCash.AutoSize = true;
            this.chkCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCash.ForeColor = System.Drawing.Color.Purple;
            this.chkCash.Location = new System.Drawing.Point(443, 66);
            this.chkCash.Name = "chkCash";
            this.chkCash.Size = new System.Drawing.Size(54, 17);
            this.chkCash.TabIndex = 10;
            this.chkCash.Text = "Cash";
            this.chkCash.UseVisualStyleBackColor = true;
            this.chkCash.CheckedChanged += new System.EventHandler(this.chkCash_CheckedChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(541, 188);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtDiscount.TabIndex = 9;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Purple;
            this.lblDiscount.Location = new System.Drawing.Point(440, 188);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(79, 17);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "DISCOUNT";
            // 
            // lblpaymethod
            // 
            this.lblpaymethod.AutoSize = true;
            this.lblpaymethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblpaymethod.Location = new System.Drawing.Point(384, 39);
            this.lblpaymethod.Name = "lblpaymethod";
            this.lblpaymethod.Size = new System.Drawing.Size(131, 13);
            this.lblpaymethod.TabIndex = 6;
            this.lblpaymethod.Text = "PAYMENT METHODS\r\n";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAmount.Location = new System.Drawing.Point(537, 223);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 20);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "000000.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Purple;
            this.lblTotal.Location = new System.Drawing.Point(457, 223);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL :";
            // 
            // btnMakePay
            // 
            this.btnMakePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMakePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePay.ForeColor = System.Drawing.Color.White;
            this.btnMakePay.Location = new System.Drawing.Point(541, 257);
            this.btnMakePay.Name = "btnMakePay";
            this.btnMakePay.Size = new System.Drawing.Size(145, 43);
            this.btnMakePay.TabIndex = 3;
            this.btnMakePay.Text = "Make Payment";
            this.btnMakePay.UseVisualStyleBackColor = false;
            this.btnMakePay.Click += new System.EventHandler(this.btnMakePay_Click);
            // 
            // CartGrid
            // 
            this.CartGrid.AllowUserToAddRows = false;
            this.CartGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.CartGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CartGrid.BackgroundColor = System.Drawing.Color.White;
            this.CartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.CartGrid.GridColor = System.Drawing.SystemColors.Control;
            this.CartGrid.Location = new System.Drawing.Point(6, 31);
            this.CartGrid.MultiSelect = false;
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CartGrid.RowHeadersWidth = 17;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CartGrid.Size = new System.Drawing.Size(350, 490);
            this.CartGrid.TabIndex = 2;
            this.CartGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.CartGrid_RowStateChanged);
            this.CartGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.CartGrid_UserDeletingRow);
            this.CartGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CartGrid_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1132, 32);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "SALES RECORDS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5618F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menu1
            // 
            this.menu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menu1.Location = new System.Drawing.Point(-3, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(241, 645);
            this.menu1.TabIndex = 0;
            // 
            // footer1
            // 
            this.footer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.footer1.Location = new System.Drawing.Point(0, 701);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1380, 35);
            this.footer1.TabIndex = 1;
            // 
            // headerPages1
            // 
            this.headerPages1._username = "";
            this.headerPages1.Location = new System.Drawing.Point(0, 0);
            this.headerPages1.Name = "headerPages1";
            this.headerPages1.Size = new System.Drawing.Size(1370, 56);
            this.headerPages1.TabIndex = 0;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.headerPages1);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.LandingPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BlueControls.HeaderPages headerPages1;
        private BlueControls.Footer footer1;
        private System.Windows.Forms.Panel panel1;
        private BlueControls.Menu menu1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView CartGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnMakePay;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblpaymethod;
        private System.Windows.Forms.CheckBox chkCash;
        private System.Windows.Forms.TextBox txtLoyaltyPayMethod;
        private System.Windows.Forms.TextBox txtPosPayMethod;
        private System.Windows.Forms.TextBox txtCashPayMethod;
        private System.Windows.Forms.CheckBox chkLoyalty;
        private System.Windows.Forms.CheckBox chkPos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPercent;
        private System.Windows.Forms.RadioButton radAmount;
        private System.Windows.Forms.Button materialRaisedButton1;
    }
}