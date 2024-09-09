namespace HaHuyHung_Buoi1_Bai3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtn = new TextBox();
            txtkt = new TextBox();
            txtnhn = new TextBox();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 24);
            label1.Name = "label1";
            label1.Size = new Size(300, 27);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra và Tìm số nguyên tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(94, 85);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(94, 142);
            label3.Name = "label3";
            label3.Size = new Size(149, 27);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(94, 201);
            label4.Name = "label4";
            label4.Size = new Size(209, 27);
            label4.TabIndex = 3;
            label4.Text = "Tên SNT nhỏ hơn n:";
            // 
            // txtn
            // 
            txtn.Location = new Point(266, 85);
            txtn.Name = "txtn";
            txtn.Size = new Size(231, 27);
            txtn.TabIndex = 4;
            txtn.TextChanged += txtn_TextChanged;
            // 
            // txtkt
            // 
            txtkt.Location = new Point(266, 142);
            txtkt.Name = "txtkt";
            txtkt.Size = new Size(231, 27);
            txtkt.TabIndex = 5;
            txtkt.TextChanged += txtkt_TextChanged;
            // 
            // txtnhn
            // 
            txtnhn.Location = new Point(314, 201);
            txtnhn.Name = "txtnhn";
            txtnhn.Size = new Size(231, 27);
            txtnhn.TabIndex = 6;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(587, 83);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(147, 42);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(btnthoat);
            Controls.Add(txtnhn);
            Controls.Add(txtkt);
            Controls.Add(txtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtn;
        private TextBox txtkt;
        private TextBox txtnhn;
        private Button btnthoat;
    }
}
