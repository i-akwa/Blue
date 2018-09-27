namespace SquareSoft.Blue.UI.Stock
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.lblLowAlert = new System.Windows.Forms.Label();
            this.txtLowAlert = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtBQNum = new System.Windows.Forms.TextBox();
            this.lblBQ = new System.Windows.Forms.Label();
            this.cboBulkType = new System.Windows.Forms.ComboBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.txtBulkCostPrice = new System.Windows.Forms.TextBox();
            this.lblBulkCostPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtBulkPrice = new System.Windows.Forms.TextBox();
            this.lblBulkPrice = new System.Windows.Forms.Label();
            this.lblSunglesInBulk = new System.Windows.Forms.Label();
            this.txtSinglesInBulk = new System.Windows.Forms.NumericUpDown();
            this.isBulk_isSingleGroupBox = new System.Windows.Forms.GroupBox();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.radIsBulk = new System.Windows.Forms.RadioButton();
            this.lblStockDate = new System.Windows.Forms.Label();
            this.dtpLastStockDate = new System.Windows.Forms.DateTimePicker();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProductNames = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerPages2 = new SquareSoft.Blue.UI.BlueControls.HeaderPages();
            this.menu2 = new SquareSoft.Blue.UI.BlueControls.Menu();
            this.footer1 = new SquareSoft.Blue.UI.BlueControls.Footer();
            this.pnlAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLowAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinglesInBulk)).BeginInit();
            this.isBulk_isSingleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlAddProduct.Controls.Add(this.lblLowAlert);
            this.pnlAddProduct.Controls.Add(this.txtLowAlert);
            this.pnlAddProduct.Controls.Add(this.progressBar1);
            this.pnlAddProduct.Controls.Add(this.txtBQNum);
            this.pnlAddProduct.Controls.Add(this.lblBQ);
            this.pnlAddProduct.Controls.Add(this.cboBulkType);
            this.pnlAddProduct.Controls.Add(this.lblNotice);
            this.pnlAddProduct.Controls.Add(this.txtDescription);
            this.pnlAddProduct.Controls.Add(this.btnAddProduct);
            this.pnlAddProduct.Controls.Add(this.label1);
            this.pnlAddProduct.Controls.Add(this.dtpExpiryDate);
            this.pnlAddProduct.Controls.Add(this.lblDescription);
            this.pnlAddProduct.Controls.Add(this.lblCreatedDate);
            this.pnlAddProduct.Controls.Add(this.dtpCreatedDate);
            this.pnlAddProduct.Controls.Add(this.txtBulkCostPrice);
            this.pnlAddProduct.Controls.Add(this.lblBulkCostPrice);
            this.pnlAddProduct.Controls.Add(this.txtUnitPrice);
            this.pnlAddProduct.Controls.Add(this.lblUnitPrice);
            this.pnlAddProduct.Controls.Add(this.txtBulkPrice);
            this.pnlAddProduct.Controls.Add(this.lblBulkPrice);
            this.pnlAddProduct.Controls.Add(this.lblSunglesInBulk);
            this.pnlAddProduct.Controls.Add(this.txtSinglesInBulk);
            this.pnlAddProduct.Controls.Add(this.isBulk_isSingleGroupBox);
            this.pnlAddProduct.Controls.Add(this.lblStockDate);
            this.pnlAddProduct.Controls.Add(this.dtpLastStockDate);
            this.pnlAddProduct.Controls.Add(this.lblQuantity);
            this.pnlAddProduct.Controls.Add(this.txtQuantity);
            this.pnlAddProduct.Controls.Add(this.lblProdName);
            this.pnlAddProduct.Controls.Add(this.txtProductNames);
            this.pnlAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddProduct.Location = new System.Drawing.Point(272, 117);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(632, 565);
            this.pnlAddProduct.TabIndex = 3;
            this.pnlAddProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddProduct_Paint);
            // 
            // lblLowAlert
            // 
            this.lblLowAlert.AutoSize = true;
            this.lblLowAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLowAlert.Location = new System.Drawing.Point(3, 183);
            this.lblLowAlert.Name = "lblLowAlert";
            this.lblLowAlert.Size = new System.Drawing.Size(115, 15);
            this.lblLowAlert.TabIndex = 31;
            this.lblLowAlert.Text = "Low Triger Value";
            // 
            // txtLowAlert
            // 
            this.txtLowAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLowAlert.Location = new System.Drawing.Point(176, 178);
            this.txtLowAlert.Name = "txtLowAlert";
            this.txtLowAlert.Size = new System.Drawing.Size(103, 20);
            this.txtLowAlert.TabIndex = 30;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 552);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(626, 10);
            this.progressBar1.TabIndex = 22;
            // 
            // txtBQNum
            // 
            this.txtBQNum.Location = new System.Drawing.Point(174, 18);
            this.txtBQNum.Name = "txtBQNum";
            this.txtBQNum.Size = new System.Drawing.Size(318, 20);
            this.txtBQNum.TabIndex = 29;
            this.txtBQNum.TextChanged += new System.EventHandler(this.txtBQNum_TextChanged);
            // 
            // lblBQ
            // 
            this.lblBQ.AutoSize = true;
            this.lblBQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBQ.Location = new System.Drawing.Point(3, 19);
            this.lblBQ.Name = "lblBQ";
            this.lblBQ.Size = new System.Drawing.Size(115, 15);
            this.lblBQ.TabIndex = 28;
            this.lblBQ.Text = "Barcode Number";
            // 
            // cboBulkType
            // 
            this.cboBulkType.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.cboBulkType.AllowDrop = true;
            this.cboBulkType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboBulkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBulkType.Items.AddRange(new object[] {
            "CARTON",
            "DOZEN",
            "ROLL",
            "SCORE"});
            this.cboBulkType.Location = new System.Drawing.Point(411, 92);
            this.cboBulkType.Name = "cboBulkType";
            this.cboBulkType.Size = new System.Drawing.Size(81, 21);
            this.cboBulkType.TabIndex = 27;
            this.cboBulkType.SelectedIndexChanged += new System.EventHandler(this.cboBulkType_SelectedIndexChanged);
            this.cboBulkType.TextChanged += new System.EventHandler(this.cboBulkType_TextChanged);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNotice.Location = new System.Drawing.Point(388, 429);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 12);
            this.lblNotice.TabIndex = 26;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(176, 415);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 61);
            this.txtDescription.TabIndex = 25;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Bisque;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAddProduct.Location = new System.Drawing.Point(176, 521);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(200, 23);
            this.btnAddProduct.TabIndex = 23;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Expiry Date";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(176, 489);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpiryDate.TabIndex = 21;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(33, 441);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 15);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCreatedDate.Location = new System.Drawing.Point(23, 387);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(91, 15);
            this.lblCreatedDate.TabIndex = 18;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(176, 385);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreatedDate.TabIndex = 17;
            // 
            // txtBulkCostPrice
            // 
            this.txtBulkCostPrice.Location = new System.Drawing.Point(176, 342);
            this.txtBulkCostPrice.Name = "txtBulkCostPrice";
            this.txtBulkCostPrice.Size = new System.Drawing.Size(200, 20);
            this.txtBulkCostPrice.TabIndex = 16;
            // 
            // lblBulkCostPrice
            // 
            this.lblBulkCostPrice.AutoSize = true;
            this.lblBulkCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBulkCostPrice.Location = new System.Drawing.Point(9, 344);
            this.lblBulkCostPrice.Name = "lblBulkCostPrice";
            this.lblBulkCostPrice.Size = new System.Drawing.Size(104, 15);
            this.lblBulkCostPrice.TabIndex = 15;
            this.lblBulkCostPrice.Text = "Bulk Cost Price";
            this.lblBulkCostPrice.Click += new System.EventHandler(this.lblBulkCostPrice_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(176, 303);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 20);
            this.txtUnitPrice.TabIndex = 14;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(48, 305);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(70, 15);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtBulkPrice
            // 
            this.txtBulkPrice.Location = new System.Drawing.Point(176, 263);
            this.txtBulkPrice.Name = "txtBulkPrice";
            this.txtBulkPrice.Size = new System.Drawing.Size(200, 20);
            this.txtBulkPrice.TabIndex = 12;
            // 
            // lblBulkPrice
            // 
            this.lblBulkPrice.AutoSize = true;
            this.lblBulkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBulkPrice.Location = new System.Drawing.Point(46, 267);
            this.lblBulkPrice.Name = "lblBulkPrice";
            this.lblBulkPrice.Size = new System.Drawing.Size(72, 15);
            this.lblBulkPrice.TabIndex = 11;
            this.lblBulkPrice.Text = "Bulk Price";
            // 
            // lblSunglesInBulk
            // 
            this.lblSunglesInBulk.AutoSize = true;
            this.lblSunglesInBulk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSunglesInBulk.Location = new System.Drawing.Point(11, 141);
            this.lblSunglesInBulk.Name = "lblSunglesInBulk";
            this.lblSunglesInBulk.Size = new System.Drawing.Size(103, 15);
            this.lblSunglesInBulk.TabIndex = 10;
            this.lblSunglesInBulk.Text = "Singles In Bulk";
            // 
            // txtSinglesInBulk
            // 
            this.txtSinglesInBulk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinglesInBulk.Location = new System.Drawing.Point(176, 137);
            this.txtSinglesInBulk.Name = "txtSinglesInBulk";
            this.txtSinglesInBulk.Size = new System.Drawing.Size(103, 20);
            this.txtSinglesInBulk.TabIndex = 9;
            // 
            // isBulk_isSingleGroupBox
            // 
            this.isBulk_isSingleGroupBox.Controls.Add(this.rdbSingle);
            this.isBulk_isSingleGroupBox.Controls.Add(this.radIsBulk);
            this.isBulk_isSingleGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isBulk_isSingleGroupBox.Location = new System.Drawing.Point(289, 80);
            this.isBulk_isSingleGroupBox.Name = "isBulk_isSingleGroupBox";
            this.isBulk_isSingleGroupBox.Size = new System.Drawing.Size(116, 36);
            this.isBulk_isSingleGroupBox.TabIndex = 8;
            this.isBulk_isSingleGroupBox.TabStop = false;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSingle.Location = new System.Drawing.Point(53, 13);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(60, 17);
            this.rdbSingle.TabIndex = 7;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            this.rdbSingle.CheckedChanged += new System.EventHandler(this.rdbSingle_CheckedChanged);
            // 
            // radIsBulk
            // 
            this.radIsBulk.AutoSize = true;
            this.radIsBulk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIsBulk.Location = new System.Drawing.Point(3, 13);
            this.radIsBulk.Name = "radIsBulk";
            this.radIsBulk.Size = new System.Drawing.Size(49, 17);
            this.radIsBulk.TabIndex = 5;
            this.radIsBulk.Text = "Bulk";
            this.radIsBulk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radIsBulk.UseVisualStyleBackColor = true;
            this.radIsBulk.CheckedChanged += new System.EventHandler(this.radIsBulk_CheckedChanged);
            // 
            // lblStockDate
            // 
            this.lblStockDate.AutoSize = true;
            this.lblStockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblStockDate.Location = new System.Drawing.Point(38, 227);
            this.lblStockDate.Name = "lblStockDate";
            this.lblStockDate.Size = new System.Drawing.Size(76, 15);
            this.lblStockDate.TabIndex = 6;
            this.lblStockDate.Text = "Stock Date";
            // 
            // dtpLastStockDate
            // 
            this.dtpLastStockDate.Location = new System.Drawing.Point(176, 222);
            this.dtpLastStockDate.Name = "dtpLastStockDate";
            this.dtpLastStockDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLastStockDate.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(57, 96);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 15);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(176, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(103, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(15, 58);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(98, 15);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Product Name";
            // 
            // txtProductNames
            // 
            this.txtProductNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductNames.Location = new System.Drawing.Point(176, 54);
            this.txtProductNames.Name = "txtProductNames";
            this.txtProductNames.Size = new System.Drawing.Size(318, 20);
            this.txtProductNames.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(486, 82);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(167, 22);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "ADD PRODUCTS";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(507, 108);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 21;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // headerPages2
            // 
            this.headerPages2._username = "";
            this.headerPages2.Location = new System.Drawing.Point(-1, 0);
            this.headerPages2.Name = "headerPages2";
            this.headerPages2.Size = new System.Drawing.Size(1356, 56);
            this.headerPages2.TabIndex = 22;
            // 
            // menu2
            // 
            this.menu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menu2.Location = new System.Drawing.Point(-4, 56);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(239, 650);
            this.menu2.TabIndex = 23;
            // 
            // footer1
            // 
            this.footer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.footer1.Location = new System.Drawing.Point(0, 698);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1380, 35);
            this.footer1.TabIndex = 24;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.headerPages2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlAddProduct);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.pnlAddProduct.ResumeLayout(false);
            this.pnlAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLowAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinglesInBulk)).EndInit();
            this.isBulk_isSingleGroupBox.ResumeLayout(false);
            this.isBulk_isSingleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlueControls.HeaderPages headerPages1;
        private BlueControls.Footer footer2;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProductNames;
        private System.Windows.Forms.DateTimePicker dtpLastStockDate;
        private System.Windows.Forms.Label lblStockDate;
        private System.Windows.Forms.Label lblSunglesInBulk;
        private System.Windows.Forms.NumericUpDown txtSinglesInBulk;
        private BlueControls.Menu menu1;
        private System.Windows.Forms.TextBox txtBulkPrice;
        private System.Windows.Forms.Label lblBulkPrice;
        private System.Windows.Forms.Label lblBulkCostPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.TextBox txtBulkCostPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton radIsBulk;
        private System.Windows.Forms.GroupBox isBulk_isSingleGroupBox;
        private System.Windows.Forms.ComboBox cboBulkType;
        private System.Windows.Forms.TextBox txtBQNum;
        private System.Windows.Forms.Label lblBQ;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLowAlert;
        private System.Windows.Forms.NumericUpDown txtLowAlert;
        private BlueControls.HeaderPages headerPages2;
        private BlueControls.Menu menu2;
        private BlueControls.Footer footer1;
    }
}