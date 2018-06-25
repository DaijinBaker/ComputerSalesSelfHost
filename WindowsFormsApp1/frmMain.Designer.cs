namespace ComputerSalesWinForm
{
    partial class frmMain
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
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lstBrand = new System.Windows.Forms.ListBox();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(12, 23);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(72, 17);
            this.lbl_brand.TabIndex = 0;
            this.lbl_brand.Text = "Brand List";
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.ItemHeight = 16;
            this.lstBrand.Location = new System.Drawing.Point(15, 70);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(143, 244);
            this.lstBrand.TabIndex = 1;
            this.lstBrand.DoubleClick += new System.EventHandler(this.lstBrand_DoubleClick);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(195, 70);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 43);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Order List";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(195, 291);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 346);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.lstBrand);
            this.Controls.Add(this.lbl_brand);
            this.Name = "frmMain";
            this.Text = "Computer Sales";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.ListBox lstBrand;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnQuit;
    }
}

