namespace FRMOrder
{
    partial class FRMInventory
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
            this.LBXInventory = new System.Windows.Forms.ListBox();
            this.BTNRefreshInventory = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient Inventory";
            // 
            // LBXInventory
            // 
            this.LBXInventory.FormattingEnabled = true;
            this.LBXInventory.ItemHeight = 16;
            this.LBXInventory.Location = new System.Drawing.Point(29, 60);
            this.LBXInventory.Name = "LBXInventory";
            this.LBXInventory.Size = new System.Drawing.Size(308, 260);
            this.LBXInventory.TabIndex = 1;
            // 
            // BTNRefreshInventory
            // 
            this.BTNRefreshInventory.Location = new System.Drawing.Point(256, 395);
            this.BTNRefreshInventory.Name = "BTNRefreshInventory";
            this.BTNRefreshInventory.Size = new System.Drawing.Size(187, 43);
            this.BTNRefreshInventory.TabIndex = 2;
            this.BTNRefreshInventory.Text = "Refresh Inventory";
            this.BTNRefreshInventory.UseVisualStyleBackColor = true;
            this.BTNRefreshInventory.Click += new System.EventHandler(this.BTNRefreshInventory_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(467, 395);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(96, 43);
            this.BTNClose.TabIndex = 3;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // FRMInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNRefreshInventory);
            this.Controls.Add(this.LBXInventory);
            this.Controls.Add(this.label1);
            this.Name = "FRMInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FRMInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBXInventory;
        private System.Windows.Forms.Button BTNRefreshInventory;
        private System.Windows.Forms.Button BTNClose;
    }
}