namespace PersonManagerDGV
{
    partial class FrmPerson
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gbGender = new GroupBox();
            rBtnUnknown = new RadioButton();
            rBtnFemale = new RadioButton();
            rBtnMale = new RadioButton();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtNationalCode = new TextBox();
            btnSaveAndReturn = new Button();
            btnCancel = new Button();
            label4 = new Label();
            txtStudentCode = new TextBox();
            label5 = new Label();
            txtGrade = new TextBox();
            btnSaveAndNew = new Button();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 69);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 117);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 0;
            label3.Text = "کد ملی :";
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rBtnUnknown);
            gbGender.Controls.Add(rBtnFemale);
            gbGender.Controls.Add(rBtnMale);
            gbGender.Location = new Point(125, 281);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(163, 158);
            gbGender.TabIndex = 3;
            gbGender.TabStop = false;
            gbGender.Text = "جنسیت";
            // 
            // rBtnUnknown
            // 
            rBtnUnknown.AutoSize = true;
            rBtnUnknown.Location = new Point(35, 109);
            rBtnUnknown.Name = "rBtnUnknown";
            rBtnUnknown.Size = new Size(90, 24);
            rBtnUnknown.TabIndex = 2;
            rBtnUnknown.TabStop = true;
            rBtnUnknown.Text = "نامشخص";
            rBtnUnknown.UseVisualStyleBackColor = true;
            // 
            // rBtnFemale
            // 
            rBtnFemale.AutoSize = true;
            rBtnFemale.Location = new Point(79, 73);
            rBtnFemale.Name = "rBtnFemale";
            rBtnFemale.Size = new Size(46, 24);
            rBtnFemale.TabIndex = 1;
            rBtnFemale.TabStop = true;
            rBtnFemale.Text = "زن";
            rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            rBtnMale.AutoSize = true;
            rBtnMale.Location = new Point(73, 37);
            rBtnMale.Name = "rBtnMale";
            rBtnMale.Size = new Size(52, 24);
            rBtnMale.TabIndex = 0;
            rBtnMale.TabStop = true;
            rBtnMale.Text = "مرد";
            rBtnMale.UseVisualStyleBackColor = true;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(142, 28);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(146, 27);
            txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(56, 70);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(161, 27);
            txtLName.TabIndex = 1;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(100, 118);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(154, 27);
            txtNationalCode.TabIndex = 2;
            // 
            // btnSaveAndReturn
            // 
            btnSaveAndReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAndReturn.ForeColor = Color.Green;
            btnSaveAndReturn.Location = new Point(269, 461);
            btnSaveAndReturn.Name = "btnSaveAndReturn";
            btnSaveAndReturn.Size = new Size(96, 70);
            btnSaveAndReturn.TabIndex = 4;
            btnSaveAndReturn.Text = "ذخیره و بازگشت";
            btnSaveAndReturn.UseVisualStyleBackColor = true;
            btnSaveAndReturn.Click += btnSaveAndReturn_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(25, 461);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 70);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "انصراف ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 164);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 0;
            label4.Text = "کد دانش آموزی:";
            // 
            // txtStudentCode
            // 
            txtStudentCode.Location = new Point(45, 165);
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(158, 27);
            txtStudentCode.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(230, 219);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 0;
            label5.Text = "پایه تحصیلی :";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(58, 220);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(158, 27);
            txtGrade.TabIndex = 0;
            // 
            // btnSaveAndNew
            // 
            btnSaveAndNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAndNew.ForeColor = Color.Green;
            btnSaveAndNew.Location = new Point(147, 461);
            btnSaveAndNew.Name = "btnSaveAndNew";
            btnSaveAndNew.Size = new Size(96, 70);
            btnSaveAndNew.TabIndex = 4;
            btnSaveAndNew.Text = "ذخیره و ثبت جدید";
            btnSaveAndNew.UseVisualStyleBackColor = true;
            btnSaveAndNew.Click += btnSaveAndNew_Click;
            // 
            // FrmPerson
            // 
            AcceptButton = btnCancel;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(397, 543);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveAndNew);
            Controls.Add(btnSaveAndReturn);
            Controls.Add(txtNationalCode);
            Controls.Add(txtLName);
            Controls.Add(txtGrade);
            Controls.Add(txtStudentCode);
            Controls.Add(txtFName);
            Controls.Add(gbGender);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPerson";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmPerson";
            Load += FrmPerson_Load;
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox gbGender;
        private RadioButton rBtnUnknown;
        private RadioButton rBtnFemale;
        private RadioButton rBtnMale;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtNationalCode;
        private Button btnSaveAndReturn;
        private Button btnCancel;
        private Label label4;
        private TextBox txtStudentCode;
        private Label label5;
        private TextBox txtGrade;
        private Button btnSaveAndNew;
    }
}