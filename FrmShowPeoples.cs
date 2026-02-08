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
    public partial class FrmShowPeople : Form
    {
        StudentManager studentManager;
        FrmMaster frmAdd;
        public bool IsSql = false;
        public bool IsList = false;

        public FrmShowPeople()
        {
            InitializeComponent();
            frmAdd= new FrmMaster(FillDGVStudent);
            studentManager = new StudentManager();
            
        }
       
        private void FrmShowPeople_Load(object sender, EventArgs e) 
        {
            FillDGVStudent();
        }
        private void FillDGVStudent()
        {
            
            dgvPeople.DataSource = studentManager.GetAll().ToList();
        }
       /* private void FillDgv() 
        {
            dgvPeople.DataSource = studentManager.GetAll().ToList();
        }*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPerson person = new FrmPerson(FillDGVStudent);
            person.Text = "شخص جدید";
            person.Show();
           
        }
        private void dgvPeople_CellcontentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvPeople.Columns[ColDelete.Name].Index && e.RowIndex >= 0) 
            {
                var result = AlertHelper.ShowQuestion("آیا میخواهید این فردا را حذف کنید؟");
                if (result == DialogResult.No)
                    return;

                var student = dgvPeople.Rows[e.RowIndex].DataBoundItem as Student;
                if(student != null)
                {
                    studentManager.Remove(student);
                    FillDGVStudent();
                    
                   // FillDgv();
                }
            }
            else if (e.ColumnIndex == dgvPeople.Columns[ColEdit.Name].Index && e.RowIndex >= 0) 
            {
                var student = dgvPeople.Rows[e.RowIndex ].DataBoundItem as Student;
                var frmNewPerson = new FrmPerson();
                {
                    frmNewPerson.Text = $"ویرایش {student.FullName}";
                    frmNewPerson.student = student;
                    //frmNewPerson.btnSaveAndNew.Enabled = false;
                    
                }
                if (frmNewPerson.ShowDialog() == DialogResult.OK)
                {
                    FillDGVStudent();
                }
               
            }
        }
    }
}
