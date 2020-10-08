namespace IndkoebsSystem
{
    partial class CheckoutView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.ItemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 426);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(4, 53);
            this.lblPrice.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 30);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(2, 16);
            this.lblName.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // ItemBox
            // 
            this.ItemBox.Controls.Add(this.btnAddItem);
            this.ItemBox.Controls.Add(this.lblPrice);
            this.ItemBox.Controls.Add(this.lblName);
            this.ItemBox.Location = new System.Drawing.Point(12, 340);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(158, 182);
            this.ItemBox.TabIndex = 3;
            this.ItemBox.TabStop = false;
            this.ItemBox.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(0, 121);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(158, 61);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Tilføj Til Kurv";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(523, 379);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(265, 59);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "Opret Bestilling";
            this.btnCreateOrder.UseMnemonic = false;
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ItemBox);
            this.Name = "CheckoutView";
            this.Text = "CheckoutView";
            this.ItemBox.ResumeLayout(false);
            this.ItemBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox ItemBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}