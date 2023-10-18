namespace BurgerRestaurant
{
    partial class Form5
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
            gboxAddExtraMaterial = new GroupBox();
            btnAdd = new Button();
            nudMaterialCost = new NumericUpDown();
            txtMaterialName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gboxAddExtraMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaterialCost).BeginInit();
            SuspendLayout();
            // 
            // gboxAddExtraMaterial
            // 
            gboxAddExtraMaterial.Controls.Add(btnAdd);
            gboxAddExtraMaterial.Controls.Add(nudMaterialCost);
            gboxAddExtraMaterial.Controls.Add(txtMaterialName);
            gboxAddExtraMaterial.Controls.Add(label2);
            gboxAddExtraMaterial.Controls.Add(label1);
            gboxAddExtraMaterial.Location = new Point(35, 29);
            gboxAddExtraMaterial.Name = "gboxAddExtraMaterial";
            gboxAddExtraMaterial.Size = new Size(261, 182);
            gboxAddExtraMaterial.TabIndex = 0;
            gboxAddExtraMaterial.TabStop = false;
            gboxAddExtraMaterial.Text = "Ekstra Malzeme Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(121, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudMaterialCost
            // 
            nudMaterialCost.Location = new Point(90, 89);
            nudMaterialCost.Name = "nudMaterialCost";
            nudMaterialCost.Size = new Size(142, 27);
            nudMaterialCost.TabIndex = 7;
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(90, 44);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(142, 27);
            txtMaterialName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 247);
            Controls.Add(gboxAddExtraMaterial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            gboxAddExtraMaterial.ResumeLayout(false);
            gboxAddExtraMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaterialCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxAddExtraMaterial;
        private NumericUpDown nudMaterialCost;
        private TextBox txtMaterialName;
        private Label label2;
        private Label label1;
        private Button btnAdd;
    }
}