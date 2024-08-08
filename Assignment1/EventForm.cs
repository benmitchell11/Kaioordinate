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
    public partial class EventForm : Form
    {

        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;
        public EventForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            BindControls();
        }
        //bind the data
        public void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventName");
            txtLocation.DataBindings.Add("Text", DM.dsKaioordinate, "Event.LocationID");
            txtEventDate.DataBindings.Add("Text", DM.dsKaioordinate, "Event.EventDate");
            lstEvent.DataSource = DM.dsKaioordinate;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }
        //return to home
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu;
            mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        //move up the list
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

        //add new event
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow newEventRow = DM.dtEvents.NewRow();

            if ((txtEventName.Text == "") || (txtLocation.Text == "") || (txtEventDate.Text == ""))
            {
                MessageBox.Show("You must enter a event name, event date and location", "Warning");
            }
            else
            {
                newEventRow["EventName"] = txtEventName.Text;
                newEventRow["LocationID"] = txtLocation.Text;
                newEventRow["EventDate"] = txtEventDate.Text;
                DM.dtEvents.Rows.Add(newEventRow);
                MessageBox.Show("Event added successfully", "Success");
                DM.UpdateEvents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvents.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you wish to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteEventRow.Delete();
                DM.UpdateEvents();
            }
        }
        //update events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            DataRow updateEventRow = DM.dtEvents.Rows[currencyManager.Position];

            if ((txtEventName.Text == "") || (txtLocation.Text == "") || (txtEventDate.Text == ""))
            {
                MessageBox.Show("You must enter an event name, event date, and location", "Error");
            }
            else
            {
                
                updateEventRow["EventName"] = txtEventName.Text;
                updateEventRow["LocationID"] = txtLocation.Text;
                updateEventRow["EventDate"] = txtEventDate.Text;
                currencyManager.EndCurrentEdit();
                MessageBox.Show("Event updated successfully", "Success");
                DM.UpdateEvents();
            }
        }

        //show needed buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtEventID.Visible = false;
            lblEventID.Visible = false;
        }
        //hide certain elements
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            
            
            btnSave.Visible = false;
            btnCancel.Visible = false;

            lblEventID.Visible = true;
            txtEventID.Visible = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
