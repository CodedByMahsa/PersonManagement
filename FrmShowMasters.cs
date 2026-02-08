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
    public partial class FrmShowMasters : Form
    {
        TeacherManager teacherManager;
        FrmMaster frmAdd;

        public FrmShowMasters()
        {
            InitializeComponent();
            frmAdd = new FrmMaster(FillDGVTeacher);
            teacherManager = new TeacherManager();
        }
        private void FillDGVTeacher()
        {
            dgvTeachers.DataSource = teacherManager.GetAll().ToList();
        }

        private void FrmShowMasters_Load(object sender, EventArgs e)
        {
            FillDGVTeacher();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                foreach (var item in dgvTeachers.Rows)
                {
                    if (dgvTeachers.SelectedRows.Equals(item))
                    {

                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmMaster master = new FrmMaster(FillDGVTeacher);
            master.Text = "شخص جدید";
            master.Show();
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvTeachers.Columns[ColDelete.Name].Index && e.RowIndex >= 0)
            {
                var result = AlertHelper.ShowQuestion("آیا میخواهید این فردا را حذف کنید؟");
                if (result == DialogResult.No)
                    return;

                var teacher = dgvTeachers.Rows[e.RowIndex].DataBoundItem as Teacher;
                if (teacher != null)
                {
                    teacherManager.Remove(teacher);
                    FillDGVTeacher();

                    // FillDgv();
                }
            }
            else if (e.ColumnIndex == dgvTeachers.Columns[ColEdit.Name].Index && e.RowIndex >= 0)
            {
                var teacher = dgvTeachers.Rows[e.RowIndex].DataBoundItem as Teacher;
                var frmNewTeacher = new FrmMaster();
                {
                    frmNewTeacher.Text = $"ویرایش {teacher.FullName}";
                    frmNewTeacher.teacher = teacher;
                    //frmNewPerson.btnSaveAndNew.Enabled = false;

                }
                if (frmNewTeacher.ShowDialog() == DialogResult.OK)
                {
                    FillDGVTeacher();
                }
            }
        }
    }
}
