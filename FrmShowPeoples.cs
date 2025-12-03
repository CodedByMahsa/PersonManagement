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
        PersonManager personManager;
        public FrmShowPeople()
        {
            InitializeComponent();
            personManager = new PersonManager();
        }
        private void FrmShowPeople_Load(object sender, EventArgs e) 
        {
            FillDgv();
        }
        private void FillDgv() 
        {
            dgvPeople.DataSource = personManager.GetPeople().ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e) 
        {   
           
            var frmNewPerson=new FrmPerson();
            {
                frmNewPerson.Text = "شخص جدید";
            }
            
            if(frmNewPerson.ShowDialog()==DialogResult.OK) 
            {
              
                FillDgv();
            }
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

                var person = dgvPeople.Rows[e.RowIndex].DataBoundItem as Person;
                if (person != null) 
                {
                    personManager.RemovePerson(person);
                    FillDgv();
                }
            }
            else if (e.ColumnIndex == dgvPeople.Columns[ColEdit.Name].Index && e.RowIndex >= 0) 
            {
                var person = dgvPeople.Rows[e.RowIndex].DataBoundItem as Person;
                var frmNewPerson = new FrmPerson();
                {
                    frmNewPerson.Text = $"ویرایش {person.FullName}";
                    frmNewPerson.person = person;
                    
                }
                if (frmNewPerson.ShowDialog() == DialogResult.OK)
                {
                    FillDgv();
                }
            }
        }
    }
}
