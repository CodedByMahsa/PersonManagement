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
            SuspendLayout();
            // 
            // btnManagePeople
            // 
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
            btnManageTeachers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageTeachers.Location = new Point(82, 151);
            btnManageTeachers.Name = "btnManageTeachers";
            btnManageTeachers.Size = new Size(174, 73);
            btnManageTeachers.TabIndex = 0;
            btnManageTeachers.Text = "مدیریت اساتید";
            btnManageTeachers.UseVisualStyleBackColor = true;
            btnManageTeachers.Click += btnManageTeachers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 268);
            Controls.Add(btnManageTeachers);
            Controls.Add(btnManagePeople);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManagePeople;
        private Button btnManageTeachers;
    }
}
