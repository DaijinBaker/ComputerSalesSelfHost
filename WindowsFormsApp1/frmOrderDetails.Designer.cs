namespace ComputerSalesWinform
{
    partial class frmOrderDetails
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
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtOrderDateTime = new System.Windows.Forms.TextBox();
            this.txtPriceAtOrder = new System.Windows.Forms.TextBox();
            this.txtComputerID = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblPriceAtOrder = new System.Windows.Forms.Label();
            this.lblCompId = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(19, 16);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(117, 17);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "Customer Name :";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(18, 50);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(121, 17);
            this.lblCustPhone.TabIndex = 6;
            this.lblCustPhone.Text = "Customer Phone :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(173, 10);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerName.TabIndex = 16;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(173, 45);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerPhone.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(199, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(173, 80);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerAddress.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer Address :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(173, 252);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 31;
            // 
            // txtOrderDateTime
            // 
            this.txtOrderDateTime.Location = new System.Drawing.Point(173, 215);
            this.txtOrderDateTime.Name = "txtOrderDateTime";
            this.txtOrderDateTime.Size = new System.Drawing.Size(100, 22);
            this.txtOrderDateTime.TabIndex = 30;
            // 
            // txtPriceAtOrder
            // 
            this.txtPriceAtOrder.Location = new System.Drawing.Point(173, 183);
            this.txtPriceAtOrder.Name = "txtPriceAtOrder";
            this.txtPriceAtOrder.Size = new System.Drawing.Size(100, 22);
            this.txtPriceAtOrder.TabIndex = 29;
            // 
            // txtComputerID
            // 
            this.txtComputerID.Location = new System.Drawing.Point(171, 147);
            this.txtComputerID.Name = "txtComputerID";
            this.txtComputerID.Size = new System.Drawing.Size(100, 22);
            this.txtComputerID.TabIndex = 28;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(171, 116);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 22);
            this.txtOrderNumber.TabIndex = 27;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(18, 258);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblQuantity.TabIndex = 26;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(18, 221);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(122, 17);
            this.lblOrderDate.TabIndex = 25;
            this.lblOrderDate.Text = "Order Date/Time :";
            // 
            // lblPriceAtOrder
            // 
            this.lblPriceAtOrder.AutoSize = true;
            this.lblPriceAtOrder.Location = new System.Drawing.Point(18, 188);
            this.lblPriceAtOrder.Name = "lblPriceAtOrder";
            this.lblPriceAtOrder.Size = new System.Drawing.Size(106, 17);
            this.lblPriceAtOrder.TabIndex = 24;
            this.lblPriceAtOrder.Text = "Price At Order :";
            // 
            // lblCompId
            // 
            this.lblCompId.AutoSize = true;
            this.lblCompId.Location = new System.Drawing.Point(19, 152);
            this.lblCompId.Name = "lblCompId";
            this.lblCompId.Size = new System.Drawing.Size(94, 17);
            this.lblCompId.TabIndex = 23;
            this.lblCompId.Text = "Computer ID :";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(19, 121);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(107, 17);
            this.lblOrderNum.TabIndex = 22;
            this.lblOrderNum.Text = "Order Number :";
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 353);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrderDateTime);
            this.Controls.Add(this.txtPriceAtOrder);
            this.Controls.Add(this.txtComputerID);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblPriceAtOrder);
            this.Controls.Add(this.lblCompId);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustName);
            this.Name = "frmOrderDetails";
            this.Text = "frmOrderDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtOrderDateTime;
        private System.Windows.Forms.TextBox txtPriceAtOrder;
        private System.Windows.Forms.TextBox txtComputerID;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblPriceAtOrder;
        private System.Windows.Forms.Label lblCompId;
        private System.Windows.Forms.Label lblOrderNum;
    }
}