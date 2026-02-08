namespace PersonManagerDGV
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
            btnManagePeople = new Button();
            btnManageTeachers = new Button();
            SQL = new RadioButton();
            LIST = new RadioButton();
            SuspendLayout();
            // 
            // btnManagePeople
            // 
            btnManagePeople.Enabled = false;
            btnManagePeople.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagePeople.Location = new Point(82, 53);
            btnManagePeople.Name = "btnManagePeople";
            btnManagePeople.Size = new Size(174, 73);
            btnManagePeople.TabIndex = 0;
            btnManagePeople.Text = "مدیریت اشخاص";
            btnManagePeople.UseVisualStyleBackColor = true;
            btnManagePeople.Click += btnManagePeople_Click;
            // 
            // btnManageTeachers
            // 
            btnManageTeachers.Enabled = false;
            btnManageTeachers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageTeachers.Location = new Point(82, 151);
            btnManageTeachers.Name = "btnManageTeachers";
            btnManageTeachers.Size = new Size(174, 73);
            btnManageTeachers.TabIndex = 0;
            btnManageTeachers.Text = "مدیریت اساتید";
            btnManageTeachers.UseVisualStyleBackColor = true;
            btnManageTeachers.Click += btnManageTeachers_Click;
            // 
            // SQL
            // 
            SQL.AutoSize = true;
            SQL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SQL.Location = new Point(193, 260);
            SQL.Name = "SQL";
            SQL.Size = new Size(63, 27);
            SQL.TabIndex = 1;
            SQL.TabStop = true;
            SQL.Text = "SQL";
            SQL.UseVisualStyleBackColor = true;
            // 
            // LIST
            // 
            LIST.AutoSize = true;
            LIST.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LIST.Location = new Point(82, 260);
            LIST.Name = "LIST";
            LIST.Size = new Size(65, 27);
            LIST.TabIndex = 1;
            LIST.TabStop = true;
            LIST.Text = "LIST";
            LIST.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 338);
            Controls.Add(LIST);
            Controls.Add(SQL);
            Controls.Add(btnManageTeachers);
            Controls.Add(btnManagePeople);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManagePeople;
        private Button btnManageTeachers;
        private RadioButton SQL;
        private RadioButton LIST;
    }
}
