namespace BurgerRestaurant
{
    partial class Form4
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
            gboxAddMenu = new GroupBox();
            btnAdd = new Button();
            nudMenuCost = new NumericUpDown();
            txtMenuName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gboxAddMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuCost).BeginInit();
            SuspendLayout();
            // 
            // gboxAddMenu
            // 
            gboxAddMenu.Controls.Add(btnAdd);
            gboxAddMenu.Controls.Add(nudMenuCost);
            gboxAddMenu.Controls.Add(txtMenuName);
            gboxAddMenu.Controls.Add(label2);
            gboxAddMenu.Controls.Add(label1);
            gboxAddMenu.Location = new Point(25, 27);
            gboxAddMenu.Name = "gboxAddMenu";
            gboxAddMenu.Size = new Size(272, 185);
            gboxAddMenu.TabIndex = 0;
            gboxAddMenu.TabStop = false;
            gboxAddMenu.Text = "Menu Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(121, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudMenuCost
            // 
            nudMenuCost.Location = new Point(90, 92);
            nudMenuCost.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudMenuCost.Name = "nudMenuCost";
            nudMenuCost.Size = new Size(142, 27);
            nudMenuCost.TabIndex = 3;
            // 
            // txtMenuName
            // 
            txtMenuName.Location = new Point(90, 47);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new Size(142, 27);
            txtMenuName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 92);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 240);
            Controls.Add(gboxAddMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            gboxAddMenu.ResumeLayout(false);
            gboxAddMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxAddMenu;
        private Label label2;
        private Label label1;
        private NumericUpDown nudMenuCost;
        private TextBox txtMenuName;
        private Button btnAdd;
    }
}