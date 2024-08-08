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
    public partial class LocationsForm : Form
    {

        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;
        private DataTable dataTable = new DataTable();
        public LocationsForm(DataModule dm, MainMenu mnu)
        {

            //initialise and hide certain elements
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            BindControls();
        }
        //bind the bata
        public void BindControls()
        {
            txtLocationID.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaioordinate, "Location.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate, "Location.Address");
            lstLocations.DataSource = DM.dsKaioordinate;
            lstLocations.DisplayMember = "Location.LocationName";
            lstLocations.ValueMember = "LocationID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Location"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu;
            mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void LocationsForm_Load(object sender, EventArgs e)
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
            if (txtLocationName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("You must enter a location name and address", "Error");
                return;
            }

            DataRow newLocationRow = DM.dtLocations.NewRow();
            newLocationRow["LocationName"] = txtLocationName.Text;
            newLocationRow["Address"] = txtAddress.Text;
            DM.dtLocations.Rows.Add(newLocationRow);
            MessageBox.Show("Location added successfully");
            DM.UpdateLocations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteLocationRow = DM.dtLocations.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you wish to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteLocationRow.Delete();
                DM.UpdateLocations();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateLocationRow = DM.dtLocations.NewRow();

            if ((txtLocationName.Text == "") || (txtAddress.Text == ""))
            {
                MessageBox.Show("You must enter a location name and address", "Error");
            }
            else
            {
                updateLocationRow["LocationName"] = txtLocationName.Text;
                updateLocationRow["Address"] = txtAddress.Text;
                currencyManager.EndCurrentEdit();
                MessageBox.Show("Location updated successfully");
                DM.UpdateLocations();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currencyManager.CancelCurrentEdit();
            this.BindingContext[DM.dsKaioordinate, "Location"].EndCurrentEdit();

            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            lblLocationID.Visible = false;
            txtLocationID.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            currencyManager.CancelCurrentEdit();
            this.BindingContext[DM.dsKaioordinate, "Event"].EndCurrentEdit();

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            lblLocationID.Visible = true;
            txtLocationID.Visible = true;
        }
    }
}
