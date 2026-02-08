namespace PersonManagerDGV
{
    public partial class Form1 : Form
    {
        private TeacherManager teacherManager = new TeacherManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            var frmStudent = new FrmPerson();
            var frmShowStudent = new FrmShowPeople();

            frmStudent.Show();

        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            var frmMaster = new FrmMaster();
            var frmShowMaster = new FrmShowMasters();

            frmShowMaster.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL.Checked = false;
            LIST.Checked = false;
        }
    }
}
