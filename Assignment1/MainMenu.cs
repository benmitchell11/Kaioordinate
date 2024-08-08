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
    public partial class MainMenu : Form
    {
        private DataModule DM;
        private KaiForm kaiForm;
        private EventForm eventForm;
        private LocationsForm locationsForm;
        private WhanauForm whanauForm;
        private RegistrationForm registrationForm;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnKai_Click(object sender, EventArgs e)
        {
            if (kaiForm == null)
            {
                this.Hide();
                KaiForm kaiForm;
                kaiForm = new KaiForm(DM, this);
                kaiForm.ShowDialog();
            }
            
            
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventForm eventForm;
            eventForm = new EventForm(DM, this);
            eventForm.ShowDialog();
        }

        private void btnWhanau_Click(object sender, EventArgs e)
        {
            this.Hide();
            WhanauForm whanauForm;
            whanauForm = new WhanauForm(DM, this);
            whanauForm.ShowDialog();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationsForm locationsForm;
            locationsForm = new LocationsForm(DM, this);
            locationsForm.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm;
            registrationForm = new RegistrationForm(DM, this);
            registrationForm.ShowDialog();
        }
    }
}
