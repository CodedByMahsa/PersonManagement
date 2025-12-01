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
            btnSave = new Button();
            btnCancel = new Button();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 47);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 99);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 154);
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
            gbGender.Location = new Point(175, 211);
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
            txtFName.Location = new Point(133, 48);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(146, 27);
            txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(54, 100);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(161, 27);
            txtLName.TabIndex = 1;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(102, 155);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(154, 27);
            txtNationalCode.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(198, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 53);
            btnSave.TabIndex = 4;
            btnSave.Text = "ذخیره ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(75, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 53);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "انصراف ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmPerson
            // 
            AcceptButton = btnCancel;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(366, 493);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNationalCode);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(gbGender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPerson";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmPerson";
            Load += this.FrmPerson_Load;
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
        private Button btnSave;
        private Button btnCancel;
    }
}