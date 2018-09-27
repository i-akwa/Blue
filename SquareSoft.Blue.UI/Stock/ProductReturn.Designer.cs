namespace SquareSoft.Blue.UI.Stock
{
    partial class ProductReturn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotice1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblSalesId = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtract = new System.Windows.Forms.Label();
            this.AmountPaid = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.btnMakeReturns = new System.Windows.Forms.Button();
            this.QuantityReturned = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblQR = new System.Windows.Forms.Label();
            this.QuantityBought = new System.Windows.Forms.Label();
            this.lblQuanttityBought = new System.Windows.Forms.Label();
            this.OriginalPrice = new System.Windows.Forms.Label();
            this.lblOPrice = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.Label();
            this.ProdSalesId = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.footer1 = new SquareSoft.Blue.UI.BlueControls.Footer();
            this.headerPages1 = new SquareSoft.Blue.UI.BlueControls.HeaderPages();
            this.menu1 = new SquareSoft.Blue.UI.BlueControls.Menu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNotice1);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.dgvSales);
            this.panel1.Controls.Add(this.lblSalesId);
            this.panel1.Controls.Add(this.txtSearchId);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(273, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 553);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note:";
            // 
            // lblNotice1
            // 
            this.lblNotice1.AutoSize = true;
            this.lblNotice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice1.ForeColor = System.Drawing.Color.Crimson;
            this.lblNotice1.Location = new System.Drawing.Point(94, 444);
            this.lblNotice1.Name = "lblNotice1";
            this.lblNotice1.Size = new System.Drawing.Size(0, 15);
            this.lblNotice1.TabIndex = 9;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(400, 132);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 17);
            this.total.TabIndex = 8;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(343, 133);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(55, 17);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Total :";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(23, 155);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(543, 255);
            this.dgvSales.TabIndex = 3;
            this.dgvSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSales_KeyDown);
            // 
            // lblSalesId
            // 
            this.lblSalesId.AutoSize = true;
            this.lblSalesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesId.Location = new System.Drawing.Point(47, 34);
            this.lblSalesId.Name = "lblSalesId";
            this.lblSalesId.Size = new System.Drawing.Size(68, 18);
            this.lblSalesId.TabIndex = 2;
            this.lblSalesId.Text = "Sales Id";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.Location = new System.Drawing.Point(141, 32);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(314, 20);
            this.txtSearchId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(141, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.editPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.lblSubtract);
            this.editPanel.Controls.Add(this.AmountPaid);
            this.editPanel.Controls.Add(this.lblAmountPaid);
            this.editPanel.Controls.Add(this.btnMakeReturns);
            this.editPanel.Controls.Add(this.QuantityReturned);
            this.editPanel.Controls.Add(this.btnSubtract);
            this.editPanel.Controls.Add(this.lblQR);
            this.editPanel.Controls.Add(this.QuantityBought);
            this.editPanel.Controls.Add(this.lblQuanttityBought);
            this.editPanel.Controls.Add(this.OriginalPrice);
            this.editPanel.Controls.Add(this.lblOPrice);
            this.editPanel.Controls.Add(this.ProductId);
            this.editPanel.Controls.Add(this.ProdSalesId);
            this.editPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPanel.Location = new System.Drawing.Point(867, 143);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(453, 345);
            this.editPanel.TabIndex = 4;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(153, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "EDIT PANEL";
            // 
            // lblSubtract
            // 
            this.lblSubtract.AutoSize = true;
            this.lblSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtract.Location = new System.Drawing.Point(215, 127);
            this.lblSubtract.Name = "lblSubtract";
            this.lblSubtract.Size = new System.Drawing.Size(41, 9);
            this.lblSubtract.TabIndex = 12;
            this.lblSubtract.Text = "Subtract";
            // 
            // AmountPaid
            // 
            this.AmountPaid.AutoSize = true;
            this.AmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaid.Location = new System.Drawing.Point(153, 186);
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.Size = new System.Drawing.Size(0, 13);
            this.AmountPaid.TabIndex = 11;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAmountPaid.Location = new System.Drawing.Point(58, 186);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(86, 13);
            this.lblAmountPaid.TabIndex = 10;
            this.lblAmountPaid.Text = "Amount Paid :";
            // 
            // btnMakeReturns
            // 
            this.btnMakeReturns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReturns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMakeReturns.Location = new System.Drawing.Point(161, 218);
            this.btnMakeReturns.Name = "btnMakeReturns";
            this.btnMakeReturns.Size = new System.Drawing.Size(141, 23);
            this.btnMakeReturns.TabIndex = 9;
            this.btnMakeReturns.Text = "RETURN";
            this.btnMakeReturns.UseVisualStyleBackColor = false;
            this.btnMakeReturns.Click += new System.EventHandler(this.btnMakeReturns_Click);
            // 
            // QuantityReturned
            // 
            this.QuantityReturned.AutoSize = true;
            this.QuantityReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityReturned.Location = new System.Drawing.Point(153, 155);
            this.QuantityReturned.Name = "QuantityReturned";
            this.QuantityReturned.Size = new System.Drawing.Size(14, 13);
            this.QuantityReturned.TabIndex = 8;
            this.QuantityReturned.Text = "0";
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubtract.Location = new System.Drawing.Point(184, 116);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(31, 20);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "--";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQR.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQR.Location = new System.Drawing.Point(26, 155);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(118, 13);
            this.lblQR.TabIndex = 6;
            this.lblQR.Text = "Quantity Returned :";
            // 
            // QuantityBought
            // 
            this.QuantityBought.AutoSize = true;
            this.QuantityBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBought.Location = new System.Drawing.Point(153, 120);
            this.QuantityBought.Name = "QuantityBought";
            this.QuantityBought.Size = new System.Drawing.Size(0, 13);
            this.QuantityBought.TabIndex = 5;
            // 
            // lblQuanttityBought
            // 
            this.lblQuanttityBought.AutoSize = true;
            this.lblQuanttityBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanttityBought.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuanttityBought.Location = new System.Drawing.Point(38, 120);
            this.lblQuanttityBought.Name = "lblQuanttityBought";
            this.lblQuanttityBought.Size = new System.Drawing.Size(106, 13);
            this.lblQuanttityBought.TabIndex = 4;
            this.lblQuanttityBought.Text = "Quantity Bought :";
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.AutoSize = true;
            this.OriginalPrice.Location = new System.Drawing.Point(153, 81);
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.Size = new System.Drawing.Size(0, 13);
            this.OriginalPrice.TabIndex = 3;
            // 
            // lblOPrice
            // 
            this.lblOPrice.AutoSize = true;
            this.lblOPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPrice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOPrice.Location = new System.Drawing.Point(53, 81);
            this.lblOPrice.Name = "lblOPrice";
            this.lblOPrice.Size = new System.Drawing.Size(91, 13);
            this.lblOPrice.TabIndex = 2;
            this.lblOPrice.Text = "Original Price :";
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Location = new System.Drawing.Point(65, 58);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(0, 13);
            this.ProductId.TabIndex = 1;
            // 
            // ProdSalesId
            // 
            this.ProdSalesId.AutoSize = true;
            this.ProdSalesId.Location = new System.Drawing.Point(138, 58);
            this.ProdSalesId.Name = "ProdSalesId";
            this.ProdSalesId.Size = new System.Drawing.Size(0, 13);
            this.ProdSalesId.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(464, 101);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(145, 22);
            this.Header.TabIndex = 5;
            this.Header.Text = "Return Product";
            // 
            // footer1
            // 
            this.footer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.footer1.Location = new System.Drawing.Point(-3, 701);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1380, 35);
            this.footer1.TabIndex = 2;
            // 
            // headerPages1
            // 
            this.headerPages1._username = "";
            this.headerPages1.Location = new System.Drawing.Point(2, 2);
            this.headerPages1.Name = "headerPages1";
            this.headerPages1.Size = new System.Drawing.Size(1370, 56);
            this.headerPages1.TabIndex = 1;
            // 
            // menu1
            // 
            this.menu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menu1.Location = new System.Drawing.Point(-1, 57);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(239, 650);
            this.menu1.TabIndex = 0;
            // 
            // ProductReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.headerPages1);
            this.Controls.Add(this.menu1);
            this.Name = "ProductReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductReturn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlueControls.Menu menu1;
        private BlueControls.HeaderPages headerPages1;
        private BlueControls.Footer footer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalesId;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label OriginalPrice;
        private System.Windows.Forms.Label lblOPrice;
        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.Label ProdSalesId;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label QuantityBought;
        private System.Windows.Forms.Label lblQuanttityBought;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.Label QuantityReturned;
        private System.Windows.Forms.Button btnMakeReturns;
        private System.Windows.Forms.Label AmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtract;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label lblNotice1;
        private System.Windows.Forms.Label label2;
    }
}