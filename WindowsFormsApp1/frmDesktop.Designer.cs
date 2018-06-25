namespace ComputerSalesWinForm
{
    partial class frmDesktop
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
            this.lblTower = new System.Windows.Forms.Label();
            this.txtTowerType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTower
            // 
            this.lblTower.AutoSize = true;
            this.lblTower.Location = new System.Drawing.Point(25, 253);
            this.lblTower.Name = "lblTower";
            this.lblTower.Size = new System.Drawing.Size(91, 17);
            this.lblTower.TabIndex = 18;
            this.lblTower.Text = "Tower Type :";
            // 
            // txtTowerType
            // 
            this.txtTowerType.Location = new System.Drawing.Point(161, 253);
            this.txtTowerType.Name = "txtTowerType";
            this.txtTowerType.Size = new System.Drawing.Size(149, 22);
            this.txtTowerType.TabIndex = 19;
            // 
            // frmDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 390);
            this.Controls.Add(this.txtTowerType);
            this.Controls.Add(this.lblTower);
            this.Name = "frmDesktop";
            this.Text = "Desktop";
            this.Controls.SetChildIndex(this.lblTower, 0);
            this.Controls.SetChildIndex(this.txtTowerType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTower;
        private System.Windows.Forms.TextBox txtTowerType;
    }
}