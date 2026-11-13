namespace FRMOrder
{
    partial class FRMOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.GBXDeliveryInfo = new System.Windows.Forms.GroupBox();
            this.RDOMail = new System.Windows.Forms.RadioButton();
            this.RDOHandDelivery = new System.Windows.Forms.RadioButton();
            this.GBXCustomerInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTStreetAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBXState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTPhoneNumber = new System.Windows.Forms.TextBox();
            this.GBXProductInfo = new System.Windows.Forms.GroupBox();
            this.CBXProductType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBXMaterialDesign = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTQuantity = new System.Windows.Forms.TextBox();
            this.BTNAddItemToOrder = new System.Windows.Forms.Button();
            this.GBXDeliveryInfo.SuspendLayout();
            this.GBXCustomerInfo.SuspendLayout();
            this.GBXProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // GBXDeliveryInfo
            // 
            this.GBXDeliveryInfo.Controls.Add(this.RDOHandDelivery);
            this.GBXDeliveryInfo.Controls.Add(this.RDOMail);
            this.GBXDeliveryInfo.Location = new System.Drawing.Point(739, 13);
            this.GBXDeliveryInfo.Name = "GBXDeliveryInfo";
            this.GBXDeliveryInfo.Size = new System.Drawing.Size(354, 100);
            this.GBXDeliveryInfo.TabIndex = 2;
            this.GBXDeliveryInfo.TabStop = false;
            this.GBXDeliveryInfo.Text = "Delivery Information:";
            // 
            // RDOMail
            // 
            this.RDOMail.AutoSize = true;
            this.RDOMail.Location = new System.Drawing.Point(47, 51);
            this.RDOMail.Name = "RDOMail";
            this.RDOMail.Size = new System.Drawing.Size(85, 20);
            this.RDOMail.TabIndex = 0;
            this.RDOMail.TabStop = true;
            this.RDOMail.Text = "Mail ($10)";
            this.RDOMail.UseVisualStyleBackColor = true;
            // 
            // RDOHandDelivery
            // 
            this.RDOHandDelivery.AutoSize = true;
            this.RDOHandDelivery.Location = new System.Drawing.Point(172, 51);
            this.RDOHandDelivery.Name = "RDOHandDelivery";
            this.RDOHandDelivery.Size = new System.Drawing.Size(146, 20);
            this.RDOHandDelivery.TabIndex = 1;
            this.RDOHandDelivery.TabStop = true;
            this.RDOHandDelivery.Text = "Hand Delivery ($15)";
            this.RDOHandDelivery.UseVisualStyleBackColor = true;
            // 
            // GBXCustomerInfo
            // 
            this.GBXCustomerInfo.Controls.Add(this.TXTPhoneNumber);
            this.GBXCustomerInfo.Controls.Add(this.label7);
            this.GBXCustomerInfo.Controls.Add(this.CBXState);
            this.GBXCustomerInfo.Controls.Add(this.label6);
            this.GBXCustomerInfo.Controls.Add(this.TXTStreetAddress);
            this.GBXCustomerInfo.Controls.Add(this.label5);
            this.GBXCustomerInfo.Controls.Add(this.TXTZipCode);
            this.GBXCustomerInfo.Controls.Add(this.label4);
            this.GBXCustomerInfo.Controls.Add(this.TXTCity);
            this.GBXCustomerInfo.Controls.Add(this.label3);
            this.GBXCustomerInfo.Controls.Add(this.TXTCustomerName);
            this.GBXCustomerInfo.Controls.Add(this.label1);
            this.GBXCustomerInfo.Location = new System.Drawing.Point(13, 13);
            this.GBXCustomerInfo.Name = "GBXCustomerInfo";
            this.GBXCustomerInfo.Size = new System.Drawing.Size(701, 211);
            this.GBXCustomerInfo.TabIndex = 3;
            this.GBXCustomerInfo.TabStop = false;
            this.GBXCustomerInfo.Text = "Customer Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // TXTCustomerName
            // 
            this.TXTCustomerName.Location = new System.Drawing.Point(27, 49);
            this.TXTCustomerName.Name = "TXTCustomerName";
            this.TXTCustomerName.Size = new System.Drawing.Size(266, 22);
            this.TXTCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // TXTCity
            // 
            this.TXTCity.Location = new System.Drawing.Point(27, 107);
            this.TXTCity.Name = "TXTCity";
            this.TXTCity.Size = new System.Drawing.Size(180, 22);
            this.TXTCity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zip Code:";
            // 
            // TXTZipCode
            // 
            this.TXTZipCode.Location = new System.Drawing.Point(27, 164);
            this.TXTZipCode.Name = "TXTZipCode";
            this.TXTZipCode.Size = new System.Drawing.Size(131, 22);
            this.TXTZipCode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Street Address:";
            // 
            // TXTStreetAddress
            // 
            this.TXTStreetAddress.Location = new System.Drawing.Point(379, 49);
            this.TXTStreetAddress.Name = "TXTStreetAddress";
            this.TXTStreetAddress.Size = new System.Drawing.Size(291, 22);
            this.TXTStreetAddress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "State:";
            // 
            // CBXState
            // 
            this.CBXState.FormattingEnabled = true;
            this.CBXState.Location = new System.Drawing.Point(379, 107);
            this.CBXState.Name = "CBXState";
            this.CBXState.Size = new System.Drawing.Size(172, 24);
            this.CBXState.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone Number:";
            // 
            // TXTPhoneNumber
            // 
            this.TXTPhoneNumber.Location = new System.Drawing.Point(379, 164);
            this.TXTPhoneNumber.Name = "TXTPhoneNumber";
            this.TXTPhoneNumber.Size = new System.Drawing.Size(172, 22);
            this.TXTPhoneNumber.TabIndex = 11;
            // 
            // GBXProductInfo
            // 
            this.GBXProductInfo.Controls.Add(this.BTNAddItemToOrder);
            this.GBXProductInfo.Controls.Add(this.TXTQuantity);
            this.GBXProductInfo.Controls.Add(this.label10);
            this.GBXProductInfo.Controls.Add(this.CBXMaterialDesign);
            this.GBXProductInfo.Controls.Add(this.label9);
            this.GBXProductInfo.Controls.Add(this.label8);
            this.GBXProductInfo.Controls.Add(this.CBXProductType);
            this.GBXProductInfo.Location = new System.Drawing.Point(27, 261);
            this.GBXProductInfo.Name = "GBXProductInfo";
            this.GBXProductInfo.Size = new System.Drawing.Size(513, 250);
            this.GBXProductInfo.TabIndex = 4;
            this.GBXProductInfo.TabStop = false;
            this.GBXProductInfo.Text = "Product Information:";
            // 
            // CBXProductType
            // 
            this.CBXProductType.FormattingEnabled = true;
            this.CBXProductType.Location = new System.Drawing.Point(13, 51);
            this.CBXProductType.Name = "CBXProductType";
            this.CBXProductType.Size = new System.Drawing.Size(216, 24);
            this.CBXProductType.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Material / Design:";
            // 
            // CBXMaterialDesign
            // 
            this.CBXMaterialDesign.FormattingEnabled = true;
            this.CBXMaterialDesign.Location = new System.Drawing.Point(13, 106);
            this.CBXMaterialDesign.Name = "CBXMaterialDesign";
            this.CBXMaterialDesign.Size = new System.Drawing.Size(216, 24);
            this.CBXMaterialDesign.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Quantity:";
            // 
            // TXTQuantity
            // 
            this.TXTQuantity.Location = new System.Drawing.Point(13, 162);
            this.TXTQuantity.Name = "TXTQuantity";
            this.TXTQuantity.Size = new System.Drawing.Size(131, 22);
            this.TXTQuantity.TabIndex = 5;
            // 
            // BTNAddItemToOrder
            // 
            this.BTNAddItemToOrder.Location = new System.Drawing.Point(297, 187);
            this.BTNAddItemToOrder.Name = "BTNAddItemToOrder";
            this.BTNAddItemToOrder.Size = new System.Drawing.Size(201, 47);
            this.BTNAddItemToOrder.TabIndex = 6;
            this.BTNAddItemToOrder.Text = "Add Item to Order";
            this.BTNAddItemToOrder.UseVisualStyleBackColor = true;
            // 
            // FRMOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 656);
            this.Controls.Add(this.GBXProductInfo);
            this.Controls.Add(this.GBXCustomerInfo);
            this.Controls.Add(this.GBXDeliveryInfo);
            this.Controls.Add(this.label2);
            this.Name = "FRMOrder";
            this.Text = "Order";
            this.GBXDeliveryInfo.ResumeLayout(false);
            this.GBXDeliveryInfo.PerformLayout();
            this.GBXCustomerInfo.ResumeLayout(false);
            this.GBXCustomerInfo.PerformLayout();
            this.GBXProductInfo.ResumeLayout(false);
            this.GBXProductInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBXDeliveryInfo;
        private System.Windows.Forms.RadioButton RDOHandDelivery;
        private System.Windows.Forms.RadioButton RDOMail;
        private System.Windows.Forms.GroupBox GBXCustomerInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTStreetAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTZipCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBXState;
        private System.Windows.Forms.GroupBox GBXProductInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBXMaterialDesign;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBXProductType;
        private System.Windows.Forms.Button BTNAddItemToOrder;
        private System.Windows.Forms.TextBox TXTQuantity;
    }
}

