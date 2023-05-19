namespace ThiThuSv_Hocphan.Views
{
    partial class MainForm
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
            cbbSortType = new ComboBox();
            tbSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btAdd = new Button();
            btUpdate = new Button();
            btDel = new Button();
            btSort = new Button();
            cbbHocPhan = new ComboBox();
            btSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Học phần";
            // 
            // cbbSortType
            // 
            cbbSortType.FormattingEnabled = true;
            cbbSortType.Items.AddRange(new object[] { "Mssv", "Tong ket" });
            cbbSortType.Location = new Point(700, 500);
            cbbSortType.Name = "cbbSortType";
            cbbSortType.Size = new Size(182, 33);
            cbbSortType.TabIndex = 1;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(485, 39);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(279, 31);
            tbSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(835, 342);
            dataGridView1.TabIndex = 4;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(47, 500);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(112, 34);
            btAdd.TabIndex = 5;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(208, 500);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(112, 34);
            btUpdate.TabIndex = 5;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDel
            // 
            btDel.Location = new Point(364, 500);
            btDel.Name = "btDel";
            btDel.Size = new Size(112, 34);
            btDel.TabIndex = 5;
            btDel.Text = "Delete";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += btDel_Click;
            // 
            // btSort
            // 
            btSort.Location = new Point(543, 498);
            btSort.Name = "btSort";
            btSort.Size = new Size(112, 34);
            btSort.TabIndex = 5;
            btSort.Text = "Sort";
            btSort.UseVisualStyleBackColor = true;
            btSort.Click += btSort_Click;
            // 
            // cbbHocPhan
            // 
            cbbHocPhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHocPhan.FormattingEnabled = true;
            cbbHocPhan.Location = new Point(160, 42);
            cbbHocPhan.Name = "cbbHocPhan";
            cbbHocPhan.Size = new Size(243, 33);
            cbbHocPhan.TabIndex = 1;
            cbbHocPhan.SelectedIndexChanged += cbbHocPhan_SelectedIndexChanged;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(770, 37);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(112, 34);
            btSearch.TabIndex = 6;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 575);
            Controls.Add(btSearch);
            Controls.Add(btSort);
            Controls.Add(btDel);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(dataGridView1);
            Controls.Add(tbSearch);
            Controls.Add(cbbHocPhan);
            Controls.Add(cbbSortType);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbSortType;
        private TextBox tbSearch;
        private DataGridView dataGridView1;
        private Button btAdd;
        private Button btUpdate;
        private Button btDel;
        private Button btSort;
        private ComboBox cbbHocPhan;
        private Button btSearch;
    }
}