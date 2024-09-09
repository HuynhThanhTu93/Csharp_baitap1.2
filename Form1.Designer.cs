namespace Csharp_baitap1._2
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
            txt_n = new TextBox();
            txt_kq = new TextBox();
            txt_sntN = new TextBox();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 33);
            label1.TabIndex = 0;
            label1.Text = "Tìm số Nguyên Tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(118, 33);
            label2.TabIndex = 0;
            label2.Text = "Nhập n: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(181, 33);
            label3.TabIndex = 0;
            label3.Text = "Số vừa nhập: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(288, 33);
            label4.TabIndex = 0;
            label4.Text = "Số nguyên tố nhỏ hơn:";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(136, 62);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 40);
            txt_n.TabIndex = 1;
            txt_n.TextChanged += txt_n_TextChanged;
            // 
            // txt_kq
            // 
            txt_kq.Location = new Point(209, 118);
            txt_kq.Name = "txt_kq";
            txt_kq.Size = new Size(209, 40);
            txt_kq.TabIndex = 2;
            // 
            // txt_sntN
            // 
            txt_sntN.Location = new Point(293, 183);
            txt_sntN.Name = "txt_sntN";
            txt_sntN.Size = new Size(267, 40);
            txt_sntN.TabIndex = 3;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(274, 62);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(184, 40);
            btn_thoat.TabIndex = 2;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 277);
            Controls.Add(btn_thoat);
            Controls.Add(txt_sntN);
            Controls.Add(txt_kq);
            Controls.Add(txt_n);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
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
        private TextBox txt_n;
        private TextBox txt_kq;
        private TextBox txt_sntN;
        private Button btn_thoat;
    }
}
