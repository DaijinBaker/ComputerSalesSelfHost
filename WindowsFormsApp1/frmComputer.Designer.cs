namespace ComputerSalesWinForm
{
    partial class frmComputer
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLmodified = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLModified = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtGraphics = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.lblGraphics = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name  :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(25, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price :";
            // 
            // lblLmodified
            // 
            this.lblLmodified.AutoSize = true;
            this.lblLmodified.Location = new System.Drawing.Point(25, 96);
            this.lblLmodified.Name = "lblLmodified";
            this.lblLmodified.Size = new System.Drawing.Size(100, 17);
            this.lblLmodified.TabIndex = 2;
            this.lblLmodified.Text = "Last Modified :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(164, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(149, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // txtLModified
            // 
            this.txtLModified.Location = new System.Drawing.Point(164, 91);
            this.txtLModified.Name = "txtLModified";
            this.txtLModified.Size = new System.Drawing.Size(149, 22);
            this.txtLModified.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(245, 357);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(68, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(25, 131);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(161, 126);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(149, 22);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtGraphics
            // 
            this.txtGraphics.Location = new System.Drawing.Point(161, 212);
            this.txtGraphics.Name = "txtGraphics";
            this.txtGraphics.Size = new System.Drawing.Size(149, 22);
            this.txtGraphics.TabIndex = 18;
            // 
            // txtHDD
            // 
            this.txtHDD.Location = new System.Drawing.Point(161, 180);
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.Size = new System.Drawing.Size(149, 22);
            this.txtHDD.TabIndex = 17;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(161, 152);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(149, 22);
            this.txtRam.TabIndex = 16;
            // 
            // lblGraphics
            // 
            this.lblGraphics.AutoSize = true;
            this.lblGraphics.Location = new System.Drawing.Point(25, 217);
            this.lblGraphics.Name = "lblGraphics";
            this.lblGraphics.Size = new System.Drawing.Size(73, 17);
            this.lblGraphics.TabIndex = 15;
            this.lblGraphics.Text = "Graphics :";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Location = new System.Drawing.Point(25, 186);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(46, 17);
            this.lblHDD.TabIndex = 14;
            this.lblHDD.Text = "HDD :";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(25, 157);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(45, 17);
            this.lblRam.TabIndex = 13;
            this.lblRam.Text = "Ram :";
            // 
            // frmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 392);
            this.Controls.Add(this.txtGraphics);
            this.Controls.Add(this.txtHDD);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.lblGraphics);
            this.Controls.Add(this.lblHDD);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtLModified);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLmodified);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "frmComputer";
            this.Text = "frmComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLmodified;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLModified;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtGraphics;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label lblGraphics;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblRam;
    }
}