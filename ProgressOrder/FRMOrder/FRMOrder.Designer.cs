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
            this.RDOHandDelivery = new System.Windows.Forms.RadioButton();
            this.RDOMail = new System.Windows.Forms.RadioButton();
            this.GBXCustomerInfo = new System.Windows.Forms.GroupBox();
            this.TXTPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBXState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTStreetAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTZipCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBXProductInfo = new System.Windows.Forms.GroupBox();
            this.BTNAddItemToOrder = new System.Windows.Forms.Button();
            this.TXTQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBXMaterialDesign = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBXProductType = new System.Windows.Forms.ComboBox();
            this.BTNProcessOrder = new System.Windows.Forms.Button();
            this.BTNClearForm = new System.Windows.Forms.Button();
            this.LBXOrderItems = new System.Windows.Forms.ListBox();
            this.PBXProductImage = new System.Windows.Forms.PictureBox();
            this.BTNClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTOrderSubtotal = new System.Windows.Forms.TextBox();
            this.TXTShipping = new System.Windows.Forms.TextBox();
            this.TXTTax = new System.Windows.Forms.TextBox();
            this.TXTOrderTotal = new System.Windows.Forms.TextBox();
            this.BTNViewInventory = new System.Windows.Forms.Button();
            this.BTNDefaultCustomer = new System.Windows.Forms.Button();
            this.GBXDeliveryInfo.SuspendLayout();
            this.GBXCustomerInfo.SuspendLayout();
            this.GBXProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // GBXDeliveryInfo
            // 
            this.GBXDeliveryInfo.Controls.Add(this.RDOHandDelivery);
            this.GBXDeliveryInfo.Controls.Add(this.RDOMail);
            this.GBXDeliveryInfo.Location = new System.Drawing.Point(1108, 21);
            this.GBXDeliveryInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBXDeliveryInfo.Name = "GBXDeliveryInfo";
            this.GBXDeliveryInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBXDeliveryInfo.Size = new System.Drawing.Size(532, 156);
            this.GBXDeliveryInfo.TabIndex = 2;
            this.GBXDeliveryInfo.TabStop = false;
            this.GBXDeliveryInfo.Text = "Delivery Information:";
            // 
            // RDOHandDelivery
            // 
            this.RDOHandDelivery.AutoSize = true;
            this.RDOHandDelivery.Location = new System.Drawing.Point(258, 79);
            this.RDOHandDelivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDOHandDelivery.Name = "RDOHandDelivery";
            this.RDOHandDelivery.Size = new System.Drawing.Size(234, 29);
            this.RDOHandDelivery.TabIndex = 1;
            this.RDOHandDelivery.TabStop = true;
            this.RDOHandDelivery.Text = "Hand Delivery ($15)";
            this.RDOHandDelivery.UseVisualStyleBackColor = true;
            this.RDOHandDelivery.CheckedChanged += new System.EventHandler(this.RDOHandDelivery_CheckedChanged);
            // 
            // RDOMail
            // 
            this.RDOMail.AutoSize = true;
            this.RDOMail.Location = new System.Drawing.Point(70, 79);
            this.RDOMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RDOMail.Name = "RDOMail";
            this.RDOMail.Size = new System.Drawing.Size(139, 29);
            this.RDOMail.TabIndex = 0;
            this.RDOMail.TabStop = true;
            this.RDOMail.Text = "Mail ($10)";
            this.RDOMail.UseVisualStyleBackColor = true;
            this.RDOMail.CheckedChanged += new System.EventHandler(this.RDOMail_CheckedChanged);
            // 
            // GBXCustomerInfo
            // 
            this.GBXCustomerInfo.Controls.Add(this.BTNDefaultCustomer);
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
            this.GBXCustomerInfo.Location = new System.Drawing.Point(20, 21);
            this.GBXCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBXCustomerInfo.Name = "GBXCustomerInfo";
            this.GBXCustomerInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBXCustomerInfo.Size = new System.Drawing.Size(1052, 343);
            this.GBXCustomerInfo.TabIndex = 3;
            this.GBXCustomerInfo.TabStop = false;
            this.GBXCustomerInfo.Text = "Customer Information:";
            // 
            // TXTPhoneNumber
            // 
            this.TXTPhoneNumber.Location = new System.Drawing.Point(568, 256);
            this.TXTPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTPhoneNumber.Name = "TXTPhoneNumber";
            this.TXTPhoneNumber.Size = new System.Drawing.Size(256, 31);
            this.TXTPhoneNumber.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone Number:";
            // 
            // CBXState
            // 
            this.CBXState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXState.FormattingEnabled = true;
            this.CBXState.Location = new System.Drawing.Point(568, 167);
            this.CBXState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBXState.Name = "CBXState";
            this.CBXState.Size = new System.Drawing.Size(256, 33);
            this.CBXState.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "State:";
            // 
            // TXTStreetAddress
            // 
            this.TXTStreetAddress.Location = new System.Drawing.Point(568, 77);
            this.TXTStreetAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTStreetAddress.Name = "TXTStreetAddress";
            this.TXTStreetAddress.Size = new System.Drawing.Size(434, 31);
            this.TXTStreetAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Street Address:";
            // 
            // TXTZipCode
            // 
            this.TXTZipCode.Location = new System.Drawing.Point(40, 256);
            this.TXTZipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTZipCode.Name = "TXTZipCode";
            this.TXTZipCode.Size = new System.Drawing.Size(194, 31);
            this.TXTZipCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zip Code:";
            // 
            // TXTCity
            // 
            this.TXTCity.Location = new System.Drawing.Point(40, 167);
            this.TXTCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTCity.Name = "TXTCity";
            this.TXTCity.Size = new System.Drawing.Size(268, 31);
            this.TXTCity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // TXTCustomerName
            // 
            this.TXTCustomerName.Location = new System.Drawing.Point(40, 77);
            this.TXTCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTCustomerName.Name = "TXTCustomerName";
            this.TXTCustomerName.Size = new System.Drawing.Size(396, 31);
            this.TXTCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
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
            this.GBXProductInfo.Location = new System.Drawing.Point(40, 408);
            this.GBXProductInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBXProductInfo.Name = "GBXProductInfo";
            this.GBXProductInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GBXProductInfo.Size = new System.Drawing.Size(770, 390);
            this.GBXProductInfo.TabIndex = 4;
            this.GBXProductInfo.TabStop = false;
            this.GBXProductInfo.Text = "Product Information:";
            // 
            // BTNAddItemToOrder
            // 
            this.BTNAddItemToOrder.Location = new System.Drawing.Point(446, 292);
            this.BTNAddItemToOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNAddItemToOrder.Name = "BTNAddItemToOrder";
            this.BTNAddItemToOrder.Size = new System.Drawing.Size(302, 73);
            this.BTNAddItemToOrder.TabIndex = 9;
            this.BTNAddItemToOrder.Text = "Add Item to Order";
            this.BTNAddItemToOrder.UseVisualStyleBackColor = true;
            this.BTNAddItemToOrder.Click += new System.EventHandler(this.BTNAddItemToOrder_Click);
            // 
            // TXTQuantity
            // 
            this.TXTQuantity.Location = new System.Drawing.Point(20, 254);
            this.TXTQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTQuantity.Name = "TXTQuantity";
            this.TXTQuantity.Size = new System.Drawing.Size(194, 31);
            this.TXTQuantity.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Quantity:";
            // 
            // CBXMaterialDesign
            // 
            this.CBXMaterialDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXMaterialDesign.FormattingEnabled = true;
            this.CBXMaterialDesign.Location = new System.Drawing.Point(20, 165);
            this.CBXMaterialDesign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBXMaterialDesign.Name = "CBXMaterialDesign";
            this.CBXMaterialDesign.Size = new System.Drawing.Size(322, 33);
            this.CBXMaterialDesign.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Material / Design:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product Type:";
            // 
            // CBXProductType
            // 
            this.CBXProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXProductType.FormattingEnabled = true;
            this.CBXProductType.Location = new System.Drawing.Point(20, 79);
            this.CBXProductType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBXProductType.Name = "CBXProductType";
            this.CBXProductType.Size = new System.Drawing.Size(322, 33);
            this.CBXProductType.TabIndex = 6;
            this.CBXProductType.SelectedIndexChanged += new System.EventHandler(this.CBXProductType_SelectedIndexChanged);
            // 
            // BTNProcessOrder
            // 
            this.BTNProcessOrder.Location = new System.Drawing.Point(1024, 971);
            this.BTNProcessOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNProcessOrder.Name = "BTNProcessOrder";
            this.BTNProcessOrder.Size = new System.Drawing.Size(208, 73);
            this.BTNProcessOrder.TabIndex = 5;
            this.BTNProcessOrder.Text = "Process Order";
            this.BTNProcessOrder.UseVisualStyleBackColor = true;
            this.BTNProcessOrder.Click += new System.EventHandler(this.BTNProcessOrder_Click);
            // 
            // BTNClearForm
            // 
            this.BTNClearForm.Location = new System.Drawing.Point(1252, 971);
            this.BTNClearForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNClearForm.Name = "BTNClearForm";
            this.BTNClearForm.Size = new System.Drawing.Size(208, 73);
            this.BTNClearForm.TabIndex = 6;
            this.BTNClearForm.Text = "Clear Form";
            this.BTNClearForm.UseVisualStyleBackColor = true;
            this.BTNClearForm.Click += new System.EventHandler(this.BTNClearForm_Click);
            // 
            // LBXOrderItems
            // 
            this.LBXOrderItems.FormattingEnabled = true;
            this.LBXOrderItems.ItemHeight = 25;
            this.LBXOrderItems.Location = new System.Drawing.Point(866, 387);
            this.LBXOrderItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LBXOrderItems.Name = "LBXOrderItems";
            this.LBXOrderItems.Size = new System.Drawing.Size(770, 304);
            this.LBXOrderItems.TabIndex = 7;
            // 
            // PBXProductImage
            // 
            this.PBXProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBXProductImage.Location = new System.Drawing.Point(1418, 194);
            this.PBXProductImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PBXProductImage.Name = "PBXProductImage";
            this.PBXProductImage.Size = new System.Drawing.Size(220, 154);
            this.PBXProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXProductImage.TabIndex = 8;
            this.PBXProductImage.TabStop = false;
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(1470, 971);
            this.BTNClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(208, 73);
            this.BTNClose.TabIndex = 9;
            this.BTNClose.Text = "Close Form";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1330, 727);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Order Subtotal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1376, 773);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Shipping: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1416, 825);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tax: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1348, 877);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Order Total: ";
            // 
            // TXTOrderSubtotal
            // 
            this.TXTOrderSubtotal.Location = new System.Drawing.Point(1484, 721);
            this.TXTOrderSubtotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TXTOrderSubtotal.Name = "TXTOrderSubtotal";
            this.TXTOrderSubtotal.ReadOnly = true;
            this.TXTOrderSubtotal.Size = new System.Drawing.Size(148, 31);
            this.TXTOrderSubtotal.TabIndex = 14;
            this.TXTOrderSubtotal.TabStop = false;
            // 
            // TXTShipping
            // 
            this.TXTShipping.Location = new System.Drawing.Point(1484, 773);
            this.TXTShipping.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TXTShipping.Name = "TXTShipping";
            this.TXTShipping.ReadOnly = true;
            this.TXTShipping.Size = new System.Drawing.Size(148, 31);
            this.TXTShipping.TabIndex = 15;
            this.TXTShipping.TabStop = false;
            // 
            // TXTTax
            // 
            this.TXTTax.Location = new System.Drawing.Point(1484, 819);
            this.TXTTax.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TXTTax.Name = "TXTTax";
            this.TXTTax.ReadOnly = true;
            this.TXTTax.Size = new System.Drawing.Size(148, 31);
            this.TXTTax.TabIndex = 16;
            this.TXTTax.TabStop = false;
            // 
            // TXTOrderTotal
            // 
            this.TXTOrderTotal.Location = new System.Drawing.Point(1484, 871);
            this.TXTOrderTotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TXTOrderTotal.Name = "TXTOrderTotal";
            this.TXTOrderTotal.ReadOnly = true;
            this.TXTOrderTotal.Size = new System.Drawing.Size(148, 31);
            this.TXTOrderTotal.TabIndex = 17;
            this.TXTOrderTotal.TabStop = false;
            // 
            // BTNViewInventory
            // 
            this.BTNViewInventory.Location = new System.Drawing.Point(808, 971);
            this.BTNViewInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNViewInventory.Name = "BTNViewInventory";
            this.BTNViewInventory.Size = new System.Drawing.Size(208, 73);
            this.BTNViewInventory.TabIndex = 18;
            this.BTNViewInventory.Text = "View Inventory";
            this.BTNViewInventory.UseVisualStyleBackColor = true;
            this.BTNViewInventory.Click += new System.EventHandler(this.BTNViewInventory_Click);
            // 
            // BTNDefaultCustomer
            // 
            this.BTNDefaultCustomer.Location = new System.Drawing.Point(893, 218);
            this.BTNDefaultCustomer.Name = "BTNDefaultCustomer";
            this.BTNDefaultCustomer.Size = new System.Drawing.Size(130, 109);
            this.BTNDefaultCustomer.TabIndex = 11;
            this.BTNDefaultCustomer.Text = "Default Customer";
            this.BTNDefaultCustomer.UseVisualStyleBackColor = true;
            this.BTNDefaultCustomer.Click += new System.EventHandler(this.BTNDefaultCustomer_Click);
            // 
            // FRMOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1688, 1062);
            this.Controls.Add(this.BTNViewInventory);
            this.Controls.Add(this.TXTOrderTotal);
            this.Controls.Add(this.TXTTax);
            this.Controls.Add(this.TXTShipping);
            this.Controls.Add(this.TXTOrderSubtotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.PBXProductImage);
            this.Controls.Add(this.LBXOrderItems);
            this.Controls.Add(this.BTNClearForm);
            this.Controls.Add(this.BTNProcessOrder);
            this.Controls.Add(this.GBXProductInfo);
            this.Controls.Add(this.GBXCustomerInfo);
            this.Controls.Add(this.GBXDeliveryInfo);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FRMOrder_Load);
            this.GBXDeliveryInfo.ResumeLayout(false);
            this.GBXDeliveryInfo.PerformLayout();
            this.GBXCustomerInfo.ResumeLayout(false);
            this.GBXCustomerInfo.PerformLayout();
            this.GBXProductInfo.ResumeLayout(false);
            this.GBXProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXProductImage)).EndInit();
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
        private System.Windows.Forms.Button BTNProcessOrder;
        private System.Windows.Forms.Button BTNClearForm;
        private System.Windows.Forms.ListBox LBXOrderItems;
        private System.Windows.Forms.PictureBox PBXProductImage;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTOrderSubtotal;
        private System.Windows.Forms.TextBox TXTShipping;
        private System.Windows.Forms.TextBox TXTTax;
        private System.Windows.Forms.TextBox TXTOrderTotal;
        private System.Windows.Forms.Button BTNViewInventory;
        private System.Windows.Forms.Button BTNDefaultCustomer;
    }
}

