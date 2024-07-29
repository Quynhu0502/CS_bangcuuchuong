namespace CS_bangcuuchuong
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
            txtchon = new TextBox();
            label1 = new Label();
            lblKQ = new Label();
            NumericUpdown1 = new NumericUpDown();
            btTinh = new Button();
            trackBar1 = new TrackBar();
            groupBox1 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton5 = new RadioButton();
            rdo2 = new RadioButton();
            listBox1 = new ListBox();
            btnTinhlai = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericUpdown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtchon
            // 
            txtchon.Font = new Font("Segoe UI", 20F);
            txtchon.Location = new Point(237, 82);
            txtchon.Name = "txtchon";
            txtchon.Size = new Size(199, 43);
            txtchon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 1;
            label1.Text = "Chọn bảng cửu chương";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Segoe UI", 15F);
            lblKQ.Location = new Point(22, 161);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(79, 28);
            lblKQ.TabIndex = 2;
            lblKQ.Text = "Kết quả";
            lblKQ.Click += lblKQ_Click;
            // 
            // NumericUpdown1
            // 
            NumericUpdown1.Font = new Font("Segoe UI", 20F);
            NumericUpdown1.Location = new Point(491, 82);
            NumericUpdown1.Margin = new Padding(2);
            NumericUpdown1.Name = "NumericUpdown1";
            NumericUpdown1.Size = new Size(91, 43);
            NumericUpdown1.TabIndex = 3;
            NumericUpdown1.ValueChanged += NumericUpdown1_ValueChanged;
            // 
            // btTinh
            // 
            btTinh.Font = new Font("Segoe UI", 20F);
            btTinh.Location = new Point(606, 78);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(118, 48);
            btTinh.TabIndex = 5;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(485, 161);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(252, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton9);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(rdo2);
            groupBox1.Location = new Point(491, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 105);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn số ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(166, 64);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(31, 19);
            radioButton9.TabIndex = 11;
            radioButton9.TabStop = true;
            radioButton9.Text = "9";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += kiemtrardo;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(115, 64);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(31, 19);
            radioButton6.TabIndex = 10;
            radioButton6.TabStop = true;
            radioButton6.Text = "8";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += kiemtrardo;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(60, 64);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "7";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += kiemtrardo;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 64);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(31, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "6";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += kiemtrardo;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(166, 22);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(31, 19);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "5";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += kiemtrardo;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(115, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(31, 19);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "4";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += kiemtrardo;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(60, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(31, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "3";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += kiemtrardo;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(6, 22);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(31, 19);
            rdo2.TabIndex = 1;
            rdo2.TabStop = true;
            rdo2.Text = "2";
            rdo2.UseVisualStyleBackColor = true;
            rdo2.CheckedChanged += kiemtrardo;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(237, 186);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(199, 284);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnTinhlai
            // 
            btnTinhlai.Font = new Font("Segoe UI", 20F);
            btnTinhlai.Location = new Point(491, 358);
            btnTinhlai.Name = "btnTinhlai";
            btnTinhlai.Size = new Size(118, 48);
            btnTinhlai.TabIndex = 9;
            btnTinhlai.Text = "Tính lại";
            btnTinhlai.UseVisualStyleBackColor = true;
            btnTinhlai.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 584);
            Controls.Add(btnTinhlai);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(trackBar1);
            Controls.Add(btTinh);
            Controls.Add(NumericUpdown1);
            Controls.Add(lblKQ);
            Controls.Add(label1);
            Controls.Add(txtchon);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumericUpdown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtchon;
        private Label label1;
        private Label lblKQ;
        private NumericUpDown NumericUpdown1;
        private Button btTinh;
        private TrackBar trackBar1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton5;
        private RadioButton rdo2;
        private RadioButton radioButton9;
        private RadioButton radioButton6;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Button btnTinhlai;
    }
}
