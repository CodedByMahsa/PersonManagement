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
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvTeachers);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
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
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.Location = new Point(0, 0);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.Size = new Size(800, 360);
            dgvTeachers.TabIndex = 0;
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
    }
}