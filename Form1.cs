namespace PersonManagerDGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            new FrmShowPeople().Show();
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            new FrmShowMasters().Show();
        }
    }
}
