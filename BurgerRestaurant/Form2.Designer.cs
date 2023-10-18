namespace BurgerRestaurant
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalCost = new Label();
            cboxMenu = new ComboBox();
            gboxSize = new GroupBox();
            rbtnBig = new RadioButton();
            rbtnMiddle = new RadioButton();
            rbtnSmall = new RadioButton();
            nudPiece = new NumericUpDown();
            btnAddOrder = new Button();
            btnConfirmOrder = new Button();
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gboxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPiece).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 169);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Menü Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 237);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 2;
            label2.Text = "Ekstra Malzeme Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 514);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(267, 514);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "Toplam";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCost.ForeColor = Color.Red;
            lblTotalCost.Location = new Point(369, 514);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(40, 20);
            lblTotalCost.TabIndex = 5;
            lblTotalCost.Text = "0.00";
            // 
            // cboxMenu
            // 
            cboxMenu.FormattingEnabled = true;
            cboxMenu.Location = new Point(26, 192);
            cboxMenu.Name = "cboxMenu";
            cboxMenu.Size = new Size(215, 28);
            cboxMenu.TabIndex = 6;
            // 
            // gboxSize
            // 
            gboxSize.Controls.Add(rbtnBig);
            gboxSize.Controls.Add(rbtnMiddle);
            gboxSize.Controls.Add(rbtnSmall);
            gboxSize.Location = new Point(26, 416);
            gboxSize.Name = "gboxSize";
            gboxSize.Size = new Size(222, 76);
            gboxSize.TabIndex = 9;
            gboxSize.TabStop = false;
            gboxSize.Text = "Boyut Seçiniz";
            // 
            // rbtnBig
            // 
            rbtnBig.AutoSize = true;
            rbtnBig.Location = new Point(146, 32);
            rbtnBig.Name = "rbtnBig";
            rbtnBig.Size = new Size(69, 24);
            rbtnBig.TabIndex = 2;
            rbtnBig.TabStop = true;
            rbtnBig.Text = "Büyük";
            rbtnBig.UseVisualStyleBackColor = true;
            // 
            // rbtnMiddle
            // 
            rbtnMiddle.AutoSize = true;
            rbtnMiddle.Location = new Point(81, 32);
            rbtnMiddle.Name = "rbtnMiddle";
            rbtnMiddle.Size = new Size(59, 24);
            rbtnMiddle.TabIndex = 1;
            rbtnMiddle.TabStop = true;
            rbtnMiddle.Text = "Orta";
            rbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rbtnSmall
            // 
            rbtnSmall.AutoSize = true;
            rbtnSmall.Location = new Point(6, 32);
            rbtnSmall.Name = "rbtnSmall";
            rbtnSmall.Size = new Size(69, 24);
            rbtnSmall.TabIndex = 0;
            rbtnSmall.TabStop = true;
            rbtnSmall.Text = "Küçük";
            rbtnSmall.UseVisualStyleBackColor = true;
            // 
            // nudPiece
            // 
            nudPiece.Location = new Point(86, 512);
            nudPiece.Name = "nudPiece";
            nudPiece.Size = new Size(162, 27);
            nudPiece.TabIndex = 10;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(26, 555);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(222, 38);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "Sipariş Ekle";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(621, 514);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(217, 79);
            btnConfirmOrder.TabIndex = 12;
            btnConfirmOrder.Text = "Siparişi Onayla";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(267, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(571, 464);
            listBox1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(24, 260);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(217, 150);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 610);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(listBox1);
            Controls.Add(btnConfirmOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(nudPiece);
            Controls.Add(gboxSize);
            Controls.Add(cboxMenu);
            Controls.Add(lblTotalCost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gboxSize.ResumeLayout(false);
            gboxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalCost;
        private ComboBox cboxMenu;
        private GroupBox gboxSize;
        private RadioButton rbtnBig;
        private RadioButton rbtnMiddle;
        private RadioButton rbtnSmall;
        private NumericUpDown nudPiece;
        private Button btnAddOrder;
        private Button btnConfirmOrder;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}