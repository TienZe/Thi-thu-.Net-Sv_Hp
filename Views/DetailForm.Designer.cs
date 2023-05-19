namespace ThiThuSv_Hocphan.Views
{
    partial class DetailForm
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
            labelab = new Label();
            tbMSSV = new TextBox();
            tbTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbDiemBT = new TextBox();
            label5 = new Label();
            tbDiemGK = new TextBox();
            label6 = new Label();
            tbDiemCK = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            cbbLopSH = new ComboBox();
            btOK = new Button();
            btCancel = new Button();
            cbbHocPhan = new ComboBox();
            tbTongKet = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelab
            // 
            labelab.AutoSize = true;
            labelab.Location = new Point(40, 48);
            labelab.Name = "labelab";
            labelab.Size = new Size(59, 25);
            labelab.TabIndex = 0;
            labelab.Text = "MSSV";
            // 
            // tbMSSV
            // 
            tbMSSV.Location = new Point(136, 48);
            tbMSSV.Name = "tbMSSV";
            tbMSSV.Size = new Size(218, 31);
            tbMSSV.TabIndex = 1;
            // 
            // tbTen
            // 
            tbTen.Location = new Point(136, 115);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(218, 31);
            tbTen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 115);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 185);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "Lớp SH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 255);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Học phần";
            // 
            // tbDiemBT
            // 
            tbDiemBT.Location = new Point(504, 48);
            tbDiemBT.Name = "tbDiemBT";
            tbDiemBT.Size = new Size(218, 31);
            tbDiemBT.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 48);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 8;
            label5.Text = "Điểm BT";
            // 
            // tbDiemGK
            // 
            tbDiemGK.Location = new Point(504, 112);
            tbDiemGK.Name = "tbDiemGK";
            tbDiemGK.Size = new Size(218, 31);
            tbDiemGK.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 112);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 10;
            label6.Text = "Điểm GK";
            // 
            // tbDiemCK
            // 
            tbDiemCK.Location = new Point(504, 182);
            tbDiemCK.Name = "tbDiemCK";
            tbDiemCK.Size = new Size(218, 31);
            tbDiemCK.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 182);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 12;
            label7.Text = "Điểm CK";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Location = new Point(54, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 87);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(173, 43);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(93, 29);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(38, 43);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 29);
            radioButtonMale.TabIndex = 1;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // cbbLopSH
            // 
            cbbLopSH.FormattingEnabled = true;
            cbbLopSH.Location = new Point(136, 185);
            cbbLopSH.Name = "cbbLopSH";
            cbbLopSH.Size = new Size(218, 33);
            cbbLopSH.TabIndex = 3;
            // 
            // btOK
            // 
            btOK.Location = new Point(136, 443);
            btOK.Name = "btOK";
            btOK.Size = new Size(112, 34);
            btOK.TabIndex = 19;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(425, 443);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(112, 34);
            btCancel.TabIndex = 20;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // cbbHocPhan
            // 
            cbbHocPhan.FormattingEnabled = true;
            cbbHocPhan.Location = new Point(136, 255);
            cbbHocPhan.Name = "cbbHocPhan";
            cbbHocPhan.Size = new Size(218, 33);
            cbbHocPhan.TabIndex = 21;
            // 
            // tbTongKet
            // 
            tbTongKet.Location = new Point(504, 253);
            tbTongKet.Name = "tbTongKet";
            tbTongKet.ReadOnly = true;
            tbTongKet.Size = new Size(218, 31);
            tbTongKet.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(407, 253);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 22;
            label8.Text = "Tỗng kết";
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 505);
            Controls.Add(tbTongKet);
            Controls.Add(label8);
            Controls.Add(cbbHocPhan);
            Controls.Add(btCancel);
            Controls.Add(btOK);
            Controls.Add(cbbLopSH);
            Controls.Add(groupBox1);
            Controls.Add(tbDiemCK);
            Controls.Add(label7);
            Controls.Add(tbDiemGK);
            Controls.Add(label6);
            Controls.Add(tbDiemBT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbTen);
            Controls.Add(label2);
            Controls.Add(tbMSSV);
            Controls.Add(labelab);
            Name = "DetailForm";
            Text = "DetailForm";
            Load += DetailForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelab;
        private TextBox tbMSSV;
        private TextBox tbTen;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbDiemBT;
        private Label label5;
        private TextBox tbDiemGK;
        private Label label6;
        private TextBox tbDiemCK;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private ComboBox cbbLopSH;
        private Button btOK;
        private Button btCancel;
        private ComboBox cbbHocPhan;
        private TextBox tbTongKet;
        private Label label8;
    }
}