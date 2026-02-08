using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagerDGV
{
    public partial class FrmPerson : Form
    {
        StudentManager studentManager;
        FrmShowMasters frmShowMasters;
        Action _action;
        public Student student { get; set; }
        public FrmPerson()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }
        public FrmPerson(Action action)
        {
            InitializeComponent();
            studentManager = new StudentManager();
            _action = action;
        }
        private void FrmPerson_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                btnSaveAndNew.Enabled = false;
                txtFName.Text = student.FirstName;
                txtLName.Text = student.LastName;
                txtNationalCode.Text = student.NationalCode;
                txtStudentCode.Text = student.StudentCode;
                txtGrade.Text = student.Grade.ToString();
                if (student.Gender == Genders.Male)
                    rBtnMale.Checked = true;
                else if (student.Gender == Genders.Female)
                    rBtnFemale.Checked = true;
                else
                    rBtnUnknown.Checked = true;
            }
        }
        public void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            bool isEdit = false;
            if (student == null)
            {
                student = new Student();
            }
            else
            {
                isEdit = true;
            }
            student.FirstName = txtFName.Text;
            student.LastName = txtLName.Text;
            student.NationalCode = txtNationalCode.Text;
            student.StudentCode = txtStudentCode.Text;
            student.Grade = int.Parse(txtGrade.Text);
            if (rBtnFemale.Checked)
                student.Gender = Genders.Female;
            else if (rBtnMale.Checked)
                student.Gender = Genders.Male;
            else
                student.Gender = Genders.Unknown;
            if (!isEdit)
            {
                Student student1 = new Student();
                student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.NationalCode = student.NationalCode;
                student1.Gender = student.Gender;
                student1.StudentCode = student.StudentCode;
                student1.Grade = int.Parse(this.txtGrade.Text);
            }
            OperationResult result;
            if (isEdit)
            {
                studentManager.Edit(student);
                result = OperationResult.Success(Messages.EditSuccessStudent);
            }
            else
            {
                result = studentManager.Add(student);
            }
            if (!result.IsSuccess)
            {
                AlertHelper.ShowError(result.Message!);
                return;
            }

            DialogResult = DialogResult.OK;
            _action?.Invoke();
            CleanForm();
        }
       
        public void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            bool isEdit = false;
            if (student == null)
            {
                student = new Student();
            }
            else
            {
                isEdit = true;
            }
            student.FirstName = txtFName.Text;
            student.LastName = txtLName.Text;
            student.NationalCode = txtNationalCode.Text;
            student.StudentCode = txtStudentCode.Text;
            student.Grade = int.Parse(txtGrade.Text);
            if (rBtnFemale.Checked)
                student.Gender = Genders.Female;
            else if (rBtnMale.Checked)
                student.Gender = Genders.Male;
            else
                student.Gender = Genders.Unknown;
            if (!isEdit)
            {
                Student student1 = new Student();
                student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.NationalCode = student.NationalCode;
                student1.Gender = student.Gender;
                student1.StudentCode = student.StudentCode;
                student1.Grade = int.Parse(this.txtGrade.Text);
            }
            OperationResult result;
            if (isEdit)
            {
                studentManager.Edit(student);
                result = OperationResult.Success(Messages.EditSuccessStudent);
            }
            else
            {
                result = studentManager.Add(student);
            }
            if (!result.IsSuccess)
            {
                AlertHelper.ShowError(result.Message!);
                return;
            }

           // DialogResult = DialogResult.OK;
           this.Close();
            _action?.Invoke();
            CleanForm();
            /* student.FirstName = txtFName.Text;
             student.LastName = txtLName.Text;
             student.NationalCode = txtNationalCode.Text;
             student.StudentCode = txtStudentCode.Text;
             student.Grade = int.Parse(txtGrade.Text);
             if (rBtnFemale.Checked)
                 student.Gender = Genders.Female;
             else if (rBtnMale.Checked)
                 student.Gender = Genders.Male;
             else
                 student.Gender = Genders.Unknown;*/
            /*if (!isEdit)
            {
                studentManager.Add(student);
                Student student1 = new Student();
                student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.NationalCode = student.NationalCode;
                student1.Gender = student.Gender;
                student1.StudentCode = student.StudentCode;
                student1.Grade = int.Parse(this.txtGrade.Text);
                /*  studentManager.Add(student);
                  Student student = new Student();*/

        }
        private void CleanForm()
        {
            txtFName.Text = null;
            txtLName.Text = null;
            txtNationalCode.Text = null;
            txtGrade.Text = null;
            txtStudentCode.Text = null;
            rBtnFemale.Checked = false;
            rBtnMale.Checked = false;
            rBtnFemale.Checked = true;
            rBtnMale.Checked = false;
            rBtnFemale.Checked = false;
            rBtnUnknown.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


