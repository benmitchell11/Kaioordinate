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
    public partial class DataModule : Form
    {
        public DataTable dtKai;
        public DataTable dtEvents;
        public DataTable dtLocations;
        public DataTable dtEventRegistration;
        public DataTable dtWhanau;
        public DataModule()
        {

            //initialise the adapters and tables
            InitializeComponent();
            dsKaioordinate.EnforceConstraints = false;
            daKai.Fill(dsKaioordinate);
            daEventRegistration.Fill(dsKaioordinate);
            daEvents.Fill(dsKaioordinate);
            daLocations.Fill(dsKaioordinate);
            daWhanau.Fill(dsKaioordinate);
            dtKai = dsKaioordinate.Tables["Kai"];
            dtEvents = dsKaioordinate.Tables["Event"];
            dtEventRegistration = dsKaioordinate.Tables["EventRegister"];
            dtLocations = dsKaioordinate.Tables["Location"];
            dtWhanau = dsKaioordinate.Tables["Whanau"];
            dsKaioordinate.EnforceConstraints = true;
        }

        public void UpdateKai()
        {
            daKai.Update(dtKai);
        }

        public void UpdateEvents()
        {
            daEvents.Update(dtEvents);
        }

        public void UpdateWhanau()
        {
            daWhanau.Update(dtWhanau);
        }

        public void UpdateLocations()
        {
            daLocations.Update(dtLocations);
        }

        public void UpdateRegister()
        {
            daEventRegistration.Update(dtEventRegistration);
        }


        private void DataModule_Load(object sender, EventArgs e)
        {

        }
    }
}
