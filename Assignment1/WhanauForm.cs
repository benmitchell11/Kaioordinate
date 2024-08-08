using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class WhanauForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;
        private DataTable dataTable = new DataTable();
        public WhanauForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            BindControls();
        }

        
        

        public void BindControls()
        {
            
            txtWhanauID.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.WhanauID");
            txtFirstName.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.LastName");
            txtEmail.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Email");
            txtPhone.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Phone");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate, "Whanau.Address");
            DM.dsKaioordinate.Tables["Whanau"].Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName"); //Join First and Last Names together to display full name
            lstWhanau.DataSource = DM.dsKaioordinate;
            lstWhanau.DisplayMember = "Whanau.FullName";
            lstWhanau.ValueMember = "Whanau.WhanauID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu;
            mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void WhanauForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count)
            {
                ++currencyManager.Position;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newWhanauRow = DM.dtWhanau.NewRow();

            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtPhone.Text == "") || (txtEmail.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must enter a first name, last name, phone, email, and address", "Error");
            }
            else
            {
                newWhanauRow["FirstName"] = txtFirstName.Text;
                newWhanauRow["LastName"] = txtLastName.Text;
                newWhanauRow["Address"] = txtAddress.Text;
                newWhanauRow["Email"] = txtEmail.Text;
                newWhanauRow["Phone"] = txtPhone.Text;
                DM.dtWhanau.Rows.Add(newWhanauRow);
                MessageBox.Show("Whanau added successfully");
                DM.UpdateWhanau();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you wish to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteWhanauRow.Delete();
                DM.UpdateWhanau();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtPhone.Text == "") || (txtEmail.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must enter a first name, last name, phone, email, and address", "Error");
            }
            else
            {
                updateWhanauRow["FirstName"] = txtFirstName.Text;
                updateWhanauRow["LastName"] = txtLastName.Text;
                updateWhanauRow["Address"] = txtAddress.Text;
                updateWhanauRow["Email"] = txtEmail.Text;
                updateWhanauRow["Phone"] = txtPhone.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateWhanau();
                MessageBox.Show("Whanau updated successfully");
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            lblWhanuID.Visible = false;
            txtWhanauID.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            currencyManager.CancelCurrentEdit();
            this.BindingContext[DM.dsKaioordinate, "Whanau"].EndCurrentEdit();

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            lblWhanuID.Visible = true;
            txtWhanauID.Visible = true;

        }
    }
}
