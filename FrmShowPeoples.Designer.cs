namespace PersonManagerDGV
{
    partial class FrmShowPeople
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
            txtSearch = new TextBox();
            label1 = new Label();
            dgvPeople = new DataGridView();
            ColEdit = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
            FirstNme = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            StudentCode = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            GenderText = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(txtSearch);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvPeople);
            splitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
            splitContainer1.Size = new Size(1052, 450);
            splitContainer1.SplitterDistance = 79;
            splitContainer1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(12, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "افزودن";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.Location = new Point(782, 21);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(182, 35);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(970, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "جستجو :";
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { ColEdit, ColDelete, FirstNme, LastName, FullName, NationalCode, StudentCode, Grade, Gender, GenderText });
            dgvPeople.Dock = DockStyle.Fill;
            dgvPeople.Location = new Point(0, 0);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.Size = new Size(1052, 367);
            dgvPeople.TabIndex = 0;
            dgvPeople.CellContentClick += dgvPeople_CellcontentClick;
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
            // FirstNme
            // 
            FirstNme.DataPropertyName = "FirstName";
            FirstNme.HeaderText = "نام";
            FirstNme.MinimumWidth = 6;
            FirstNme.Name = "FirstNme";
            FirstNme.ReadOnly = true;
            FirstNme.Visible = false;
            FirstNme.Width = 125;
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
            FullName.HeaderText = "نام شخص ";
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
            // StudentCode
            // 
            StudentCode.DataPropertyName = "StudentCode";
            StudentCode.HeaderText = "کد دانش آموزی";
            StudentCode.MinimumWidth = 6;
            StudentCode.Name = "StudentCode";
            StudentCode.ReadOnly = true;
            StudentCode.Width = 125;
            // 
            // Grade
            // 
            Grade.DataPropertyName = "Grade";
            Grade.HeaderText = "پایه تحصیلی";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            Grade.Width = 125;
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
            // FrmShowPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(splitContainer1);
            Name = "FrmShowPeople";
            RightToLeft = RightToLeft.Yes;
            Text = "نمایش اشخاص";
            Load += FrmShowPeople_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvPeople;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDelete;
        private DataGridViewTextBoxColumn FirstNme;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn StudentCode;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn GenderText;
    }
}