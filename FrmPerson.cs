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
        PersonManager personManager;
        public Person person { get; set; }
        public FrmPerson()
        {
            InitializeComponent();
            personManager = new PersonManager();
        }
        private void FrmPerson_Load(object sender, EventArgs e) 
        {
            if (person != null) 
            {
                txtFName.Text = person.FirstName;
                txtLName.Text = person.LastName;
                txtNationalCode.Text = person.NationalCode;
                if(person.Gender == Genders.Male) 
                    rBtnMale.Checked = true;
                else if(person.Gender == Genders.Female)
                    rBtnFemale.Checked = true;
                else 
                    rBtnUnknown.Checked = true;
            }
        }
       // public static int iD = 0;
        public void btnSave_Click (object sender, EventArgs e) 
        {  
            bool isEdit = false;
            if (person == null) 
            {
                person = new Person();
            }
            else 
            {
                isEdit = true;
            }
             person.FirstName = txtFName.Text;
             person.LastName = txtLName.Text;
             person.NationalCode = txtNationalCode.Text;
          //   Person.ID++;
            if (rBtnFemale.Checked)
                person.Gender = Genders.Female;
            else if (rBtnMale.Checked)
                person.Gender = Genders.Male;
            else
                person.Gender = Genders.Unknown;
            if (!isEdit)
            {
              //  Person.ID = +1;
                personManager.Add(person);
            }
           // OperationResult result1 = OperationResult.ValidateInput(person);
            OperationResult operation = person.Validate();
            if (!operation.IsSuccess) 
            {
                AlertHelper.ShowError(operation.Message!);  
                return;
            }
            else
            DialogResult = DialogResult.OK;
            
        }
        
    }
   
}
