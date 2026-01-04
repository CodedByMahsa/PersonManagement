using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagerDGV
{
    public partial class FrmMaster : Form
    {
        TeacherManager teacherManager;
        public Teacher teacher { get; set; }
        public FrmMaster(TeacherManager manager)
        {
            InitializeComponent();
            teacherManager = new TeacherManager();
            
        }
        
        private void FrmMaster_Load(object sender, EventArgs e)
        {
            if (teacher != null)
            {
                btnSaveAndNew.Enabled = false;
                txtFName.Text = teacher.FirstName;
                txtLName.Text = teacher.LastName;
                txtNationalCode.Text = teacher.NationalCode;
                txtPhoneNum.Text = teacher.PhoneNumber;
                txtAddress.Text = teacher.Address;
                txtMajor.Text = teacher.Major;
                if (teacher.Gender == Genders.Male)
                    rBtnMale.Checked = true;
                else if (teacher.Gender == Genders.Female)
                    rBtnFemale.Checked = true;
                else
                    rBtnUnknown.Checked = true;
            }
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            bool isEdit = teacher != null;

            if (!isEdit)
                teacher = new Teacher();
           
             teacher.FirstName = txtFName.Text;
             teacher.LastName = txtLName.Text;
             teacher.NationalCode = txtNationalCode.Text;
             teacher.PhoneNumber = txtPhoneNum.Text;
             teacher.Address = txtAddress.Text;
             teacher.Major = txtMajor.Text;

            if (rBtnFemale.Checked)
                teacher.Gender = Genders.Female;
            else if (rBtnMale.Checked)
                teacher.Gender = Genders.Male;
            else
                teacher.Gender = Genders.Unknown;

            //teacherManager.AddTeacher(teacher);
          //  DialogResult = DialogResult.OK;
            /* bool isEdit = teacher != null;
             if (teacher == null)
             {
                 teacher = new Teacher();
             }
             else
             {
                 isEdit = true;
             }
             teacher.FirstName = txtFName.Text;
             teacher.LastName = txtLName.Text;

             teacher.NationalCode = txtNationalCode.Text;
             teacher.PhoneNumber = txtPhoneNum.Text;
             teacher.Address = txtAddress.Text;
             teacher.Major= txtMajor.Text;
             if (rBtnFemale.Checked)
                 teacher.Gender = Genders.Female;
             else if (rBtnMale.Checked)
                 teacher.Gender = Genders.Male;
             else
                 teacher.Gender = Genders.Unknown;*/
            OperationResult result;
            if (isEdit)
            {
                teacherManager.Edit(teacher);
                result = OperationResult.Success(Messages.EditSuccessTeacher);
            }
            else
            {
                result = teacherManager.Add(teacher);
            }

            if (!result.IsSuccess)
            {
                AlertHelper.ShowError(result.Message!);
                return;
            }

            DialogResult = DialogResult.OK;
            CleanForm();
            /* if (!isEdit)
             {
                 teacherManager.Add(teacher);
                 Teacher teacher1 = new Teacher();
                 teacher1.FirstName = teacher.FirstName;
                 teacher1.LastName = teacher.LastName;
                 teacher1.NationalCode = teacher.NationalCode;
                 teacher1.Gender = teacher.Gender;
                 teacher1.PhoneNumber = txtPhoneNum.Text;
                 teacher1.Address = txtAddress.Text;
                 teacher1.Major = txtMajor.Text;
             }*/
            //TeacherCreated?.Invoke(teacher);
           /* OperationResult operation = teacher.Validate();
            if (!operation.IsSuccess)
            {
                AlertHelper.ShowError(operation.Message!);
                return;
            }
            else
            {
               // teacherManager.AddTeacher(teacher);
                DialogResult = DialogResult.OK;
            }

            CleanForm();*/
        }
        private void CleanForm()
        {
            txtFName.Text = null;
            txtLName.Text = null;
            txtNationalCode.Text = null;
            txtPhoneNum.Text = null;
            txtAddress.Text = null;
            txtMajor.Text = null;
            rBtnFemale.Checked = false;
            rBtnMale.Checked = false;
            rBtnFemale.Checked = true;
            rBtnMale.Checked = false;
            rBtnFemale.Checked = false;
            rBtnUnknown.Checked = true;
        }
    }
}
