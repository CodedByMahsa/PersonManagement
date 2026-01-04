namespace PersonManagerDGV
{
    partial class FrmMaster
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
            txtNationalCode = new TextBox();
            txtLName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNum = new TextBox();
            txtFName = new TextBox();
            gbGender = new GroupBox();
            rBtnUnknown = new RadioButton();
            rBtnFemale = new RadioButton();
            rBtnMale = new RadioButton();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSaveAndNew = new Button();
            btnSaveAndReturn = new Button();
            label6 = new Label();
            txtMajor = new TextBox();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(132, 120);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(154, 27);
            txtNationalCode.TabIndex = 13;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(88, 72);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(161, 27);
            txtLName.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 222);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(158, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(77, 167);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(158, 27);
            txtPhoneNum.TabIndex = 5;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(174, 30);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(146, 27);
            txtFName.TabIndex = 6;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rBtnUnknown);
            gbGender.Controls.Add(rBtnFemale);
            gbGender.Controls.Add(rBtnMale);
            gbGender.Location = new Point(213, 325);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(163, 158);
            gbGender.TabIndex = 14;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 119);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 7;
            label3.Text = "کد ملی :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 221);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 8;
            label5.Text = "آدرس :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(255, 166);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 9;
            label4.Text = "شماره موبایل :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 71);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 10;
            label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 11;
            label1.Text = "نام :";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(31, 497);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 70);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "انصراف ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndNew
            // 
            btnSaveAndNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAndNew.ForeColor = Color.Green;
            btnSaveAndNew.Location = new Point(153, 497);
            btnSaveAndNew.Name = "btnSaveAndNew";
            btnSaveAndNew.Size = new Size(96, 70);
            btnSaveAndNew.TabIndex = 15;
            btnSaveAndNew.Text = "ذخیره و ثبت جدید";
            btnSaveAndNew.UseVisualStyleBackColor = true;
            btnSaveAndNew.Click += btnSaveAndNew_Click;
            // 
            // btnSaveAndReturn
            // 
            btnSaveAndReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAndReturn.ForeColor = Color.Green;
            btnSaveAndReturn.Location = new Point(275, 497);
            btnSaveAndReturn.Name = "btnSaveAndReturn";
            btnSaveAndReturn.Size = new Size(96, 70);
            btnSaveAndReturn.TabIndex = 16;
            btnSaveAndReturn.Text = "ذخیره و بازگشت";
            btnSaveAndReturn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(317, 269);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 8;
            label6.Text = "رشته :";
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(136, 270);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(158, 27);
            txtMajor.TabIndex = 4;
            // 
            // FrmMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 588);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveAndNew);
            Controls.Add(btnSaveAndReturn);
            Controls.Add(txtNationalCode);
            Controls.Add(txtLName);
            Controls.Add(txtMajor);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtFName);
            Controls.Add(gbGender);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMaster";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmMaster";
            Load += FrmMaster_Load;
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNationalCode;
        private TextBox txtLName;
        private TextBox txtAddress;
        private TextBox txtPhoneNum;
        private TextBox txtFName;
        private GroupBox gbGender;
        private RadioButton rBtnUnknown;
        private RadioButton rBtnFemale;
        private RadioButton rBtnMale;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSaveAndNew;
        private Button btnSaveAndReturn;
        private Label label6;
        private TextBox txtMajor;
    }
}