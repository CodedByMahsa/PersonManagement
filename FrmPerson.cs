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
        //PersonManager personManager;
        StudentManager studentManager;
        public Student student { get; set; }
        public FrmPerson()
        {
            InitializeComponent();
            //personManager = new PersonManager();
            studentManager = new StudentManager();
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
                studentManager.Add(student);
                Student student1 = new Student();
                student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.NationalCode = student.NationalCode;
                student1.Gender = student.Gender;
                student1.StudentCode = student.StudentCode;
                student1.Grade = int.Parse(this.txtGrade.Text);
            }
            OperationResult operation = student.Validate();
            if (!operation.IsSuccess)
            {
                AlertHelper.ShowError(operation.Message!);
                return;
            }
            else
                DialogResult = DialogResult.OK;

            txtFName.Text = null;
            txtLName.Text = null;
            txtNationalCode.Text = null;
            txtStudentCode.Text = null;
            txtGrade.Text = null;
            rBtnFemale.Checked = false;
            rBtnMale.Checked = false;
            rBtnFemale.Checked = true;

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
                btnSaveAndNew.Enabled = false;
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

            OperationResult result;

            if (isEdit == true)
            {
                result = studentManager.Edit(student);
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
            else
                DialogResult = DialogResult.OK;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*OperationResult operation = student.Validate();
if (!operation.IsSuccess)
{
   AlertHelper.ShowError(operation.Message!);
   return;
}
else
   DialogResult = DialogResult.OK;
}*/

    }
}


