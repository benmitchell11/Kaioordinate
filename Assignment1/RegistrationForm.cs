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

    public partial class RegistrationForm : Form
    {
        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistration;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public RegistrationForm(DataModule dm, MainMenu mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Event"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "Whanau"];
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EventRegister"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            BindControls();
        }

        public void BindControls()
        {
            dgvEvents.DataSource = DM.dsKaioordinate;
            dgvEvents.DataMember = "Event";

            dgvWhanau.DataSource = DM.dsKaioordinate;
            dgvWhanau.DataMember = "Whanau";

            dgvRegistrations.DataSource = DM.dsKaioordinate;
            dgvRegistrations.DataMember = "EventRegister";
        }

       

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu;
            mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }


        //Set up the adding registration function
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                //select the neccessary ids
                int selectedEventID = Convert.ToInt32(dgvEvents.CurrentRow.Cells["EventID"].Value);
                int selectedWhanauID = Convert.ToInt32(dgvWhanau.CurrentRow.Cells["WhanauID"].Value);

                DataRow[] currentRegistration = DM.dsKaioordinate.Tables["EVENTREGISTER"].Select($"WhanauID = {selectedWhanauID} AND EventID = {selectedEventID}");
                if (currentRegistration.Length > 0) //check if the id is already registered and warn
                {
                    MessageBox.Show("Whanau is already registered for this event", "Registration Error");
                }
                else
                {
                    try
                    {
                        //assign the whanau id to event
                        DataRow newEventRegister = DM.dtEventRegistration.NewRow();

                        newEventRegister["EventID"] = selectedEventID;
                        newEventRegister["WhanauID"] = selectedWhanauID;
                        newEventRegister["KaiPreparation"] = checkKaiPrepAssist.Checked;

                        DM.dsKaioordinate.Tables["EventRegister"].Rows.Add(newEventRegister);
                        DM.UpdateRegister();
                        MessageBox.Show("Entry added successfully", "Success");
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("System Error, Please go to Main Menu", "Error");
                    }
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("System Error, Please retry correct values", "Error");
            }
        
    }

        //Set up the delete function
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow deleteEventRegister = DM.dtEventRegistration.Rows[cmRegistration.Position];
                deleteEventRegister.Delete();
                DM.UpdateRegister(); 
            }
        }
    }
}
