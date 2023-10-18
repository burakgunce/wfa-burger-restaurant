namespace BurgerRestaurant
{
    partial class Form3
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
            label1 = new Label();
            lstOrders = new ListBox();
            gboxGiro = new GroupBox();
            lblGiro = new Label();
            gboxTotalOrders = new GroupBox();
            lblTotalOrders = new Label();
            gboxExtraMaterialRevenue = new GroupBox();
            lblExtraMaterial = new Label();
            gboxTotalProductSold = new GroupBox();
            lblTotalProduct = new Label();
            gboxGiro.SuspendLayout();
            gboxTotalOrders.SuspendLayout();
            gboxExtraMaterialRevenue.SuspendLayout();
            gboxTotalProductSold.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 20;
            lstOrders.Location = new Point(38, 67);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(275, 344);
            lstOrders.TabIndex = 1;
            // 
            // gboxGiro
            // 
            gboxGiro.Controls.Add(lblGiro);
            gboxGiro.Location = new Point(372, 67);
            gboxGiro.Name = "gboxGiro";
            gboxGiro.Size = new Size(245, 75);
            gboxGiro.TabIndex = 2;
            gboxGiro.TabStop = false;
            gboxGiro.Text = "Ciro";
            // 
            // lblGiro
            // 
            lblGiro.AutoSize = true;
            lblGiro.BackColor = SystemColors.Control;
            lblGiro.ForeColor = Color.Red;
            lblGiro.Location = new Point(54, 33);
            lblGiro.Name = "lblGiro";
            lblGiro.Size = new Size(50, 20);
            lblGiro.TabIndex = 0;
            lblGiro.Text = "label2";
            // 
            // gboxTotalOrders
            // 
            gboxTotalOrders.Controls.Add(lblTotalOrders);
            gboxTotalOrders.Location = new Point(372, 157);
            gboxTotalOrders.Name = "gboxTotalOrders";
            gboxTotalOrders.Size = new Size(245, 75);
            gboxTotalOrders.TabIndex = 3;
            gboxTotalOrders.TabStop = false;
            gboxTotalOrders.Text = "Tüm Siparişler";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.ForeColor = Color.Red;
            lblTotalOrders.Location = new Point(54, 32);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(50, 20);
            lblTotalOrders.TabIndex = 1;
            lblTotalOrders.Text = "label3";
            // 
            // gboxExtraMaterialRevenue
            // 
            gboxExtraMaterialRevenue.Controls.Add(lblExtraMaterial);
            gboxExtraMaterialRevenue.Location = new Point(372, 251);
            gboxExtraMaterialRevenue.Name = "gboxExtraMaterialRevenue";
            gboxExtraMaterialRevenue.Size = new Size(245, 75);
            gboxExtraMaterialRevenue.TabIndex = 3;
            gboxExtraMaterialRevenue.TabStop = false;
            gboxExtraMaterialRevenue.Text = "Ekstra Malzeme Geliri";
            // 
            // lblExtraMaterial
            // 
            lblExtraMaterial.AutoSize = true;
            lblExtraMaterial.ForeColor = Color.Red;
            lblExtraMaterial.Location = new Point(54, 35);
            lblExtraMaterial.Name = "lblExtraMaterial";
            lblExtraMaterial.Size = new Size(50, 20);
            lblExtraMaterial.TabIndex = 2;
            lblExtraMaterial.Text = "label4";
            // 
            // gboxTotalProductSold
            // 
            gboxTotalProductSold.Controls.Add(lblTotalProduct);
            gboxTotalProductSold.Location = new Point(372, 336);
            gboxTotalProductSold.Name = "gboxTotalProductSold";
            gboxTotalProductSold.Size = new Size(245, 75);
            gboxTotalProductSold.TabIndex = 3;
            gboxTotalProductSold.TabStop = false;
            gboxTotalProductSold.Text = "Satılan Ürün Adedi";
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.AutoSize = true;
            lblTotalProduct.ForeColor = Color.Red;
            lblTotalProduct.Location = new Point(54, 35);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(50, 20);
            lblTotalProduct.TabIndex = 3;
            lblTotalProduct.Text = "label5";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gboxTotalOrders);
            Controls.Add(gboxExtraMaterialRevenue);
            Controls.Add(gboxTotalProductSold);
            Controls.Add(gboxGiro);
            Controls.Add(lstOrders);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            gboxGiro.ResumeLayout(false);
            gboxGiro.PerformLayout();
            gboxTotalOrders.ResumeLayout(false);
            gboxTotalOrders.PerformLayout();
            gboxExtraMaterialRevenue.ResumeLayout(false);
            gboxExtraMaterialRevenue.PerformLayout();
            gboxTotalProductSold.ResumeLayout(false);
            gboxTotalProductSold.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOrders;
        private GroupBox gboxGiro;
        private GroupBox gboxTotalOrders;
        private GroupBox gboxExtraMaterialRevenue;
        private GroupBox gboxTotalProductSold;
        private Label lblGiro;
        private Label lblTotalOrders;
        private Label lblExtraMaterial;
        private Label lblTotalProduct;
    }
}