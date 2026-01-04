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

        public FrmShowMasters()
        {
            InitializeComponent();
            teacherManager = new TeacherManager();
            teacherManager.TeachersChanged += TeacherManager_TeachersChanged;
        }
        /*  private void FillDgv()
        {
            dgvTeachers.DataSource = teacherManager.GetAll().ToList();
        }*/
        private void FrmShowMasters_Load(object sender, EventArgs e)
        {
            dgvTeachers.AutoGenerateColumns = true;
            dgvTeachers.DataSource = teacherManager.GetAll().ToList();
        }
        private void TeacherManager_TeachersChanged(IReadOnlyList<Teacher> teachers)
        {
            dgvTeachers.DataSource = null;
            dgvTeachers.DataSource = teachers.ToList();
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
            var frmNewTeacher = new FrmMaster(teacherManager);
            frmNewTeacher.Text = "شخص جدید";
            frmNewTeacher.ShowDialog();
        }

       
    }
}
