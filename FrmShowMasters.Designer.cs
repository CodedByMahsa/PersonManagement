namespace PersonManagerDGV
{
    partial class FrmShowMasters
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
            splitContainer1 = new SplitContainer();
            btnAdd = new Button();
            btnCompare = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvTeachers = new DataGridView();
            ColEdit = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            GenderText = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(btnCompare);
            splitContainer1.Panel1.Controls.Add(txtSearch);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvTeachers);
            splitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
            splitContainer1.RightToLeft = RightToLeft.Yes;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 86;
            splitContainer1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 54);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "افزودن";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCompare
            // 
            btnCompare.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompare.Location = new Point(95, 12);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(82, 54);
            btnCompare.TabIndex = 4;
            btnCompare.Text = "مقایسه";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Location = new Point(527, 29);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(182, 35);
            txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(715, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 2;
            label1.Text = ": جستجو";
            // 
            // dgvTeachers
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] { ColEdit, ColDelete, FirstName, LastName, FullName, NationalCode, PhoneNumber, Address, Gender, GenderText });
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.Location = new Point(0, 0);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.Size = new Size(800, 360);
            dgvTeachers.TabIndex = 0;
            dgvTeachers.CellContentClick += dgvTeachers_CellContentClick;
            // 
            // ColEdit
            // 
            ColEdit.HeaderText = "ویرایش";
            ColEdit.MinimumWidth = 6;
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Width = 125;
            // 
            // ColDelete
            // 
            ColDelete.HeaderText = "حذف";
            ColDelete.MinimumWidth = 6;
            ColDelete.Name = "ColDelete";
            ColDelete.ReadOnly = true;
            ColDelete.Width = 125;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Visible = false;
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "نام خانوادگی";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Visible = false;
            LastName.Width = 125;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "نام شخص";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 125;
            // 
            // NationalCode
            // 
            NationalCode.DataPropertyName = "NationalCode";
            NationalCode.HeaderText = "کد ملی";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            NationalCode.ReadOnly = true;
            NationalCode.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "شماره تلفن";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "نشانی";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "نوع جنسیت";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Visible = false;
            Gender.Width = 125;
            // 
            // GenderText
            // 
            GenderText.DataPropertyName = "GenderText";
            GenderText.HeaderText = "جنسیت";
            GenderText.MinimumWidth = 6;
            GenderText.Name = "GenderText";
            GenderText.ReadOnly = true;
            GenderText.Width = 125;
            // 
            // FrmShowMasters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmShowMasters";
            Text = "FrmShowMasters";
            Load += FrmShowMasters_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvTeachers;
        private TextBox txtSearch;
        private Label label1;
        private Button btnCompare;
        private Button btnAdd;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDelete;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn GenderText;
    }
}