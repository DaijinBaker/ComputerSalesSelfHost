namespace ComputerSalesWinForm
{
    partial class frmLaptop
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Color :";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(161, 253);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(149, 22);
            this.txtColor.TabIndex = 20;
            // 
            // frmLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(329, 392);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label1);
            this.Name = "frmLaptop";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtColor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtLModified;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLmodified;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLConfirm;
        private System.Windows.Forms.Button btnLCancel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtGraphics;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label lblGraphics;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
    }
}