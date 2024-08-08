using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class KaiForm : Form
    {

        private DataModule DM;
        private MainMenu frmMenu;
        private CurrencyManager currencyManager;

        public KaiForm(DataModule dm, MainMenu mnu)
        {

            //initialise the page and hide certain elements
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            checkPreperation.Visible = false;
            numPreperation.Visible = false;
            numServing.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            BindControls();

        }

        public void BindControls()
        {
            
            txtKaiID.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiID");
            txtKaiName.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.KaiName");
            txtPreperation.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationRequired");
            txtPreperationTime.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.ServeQuantity");
            txtEvent.DataBindings.Add("Text", DM.dsKaioordinate, "Kai.EventID");
            lstKai.DataSource = DM.dsKaioordinate;
            lstKai.DisplayMember = "Kai.KaiName";
            lstKai.ValueMember = "Kai.KaiName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "KAI"];

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu;
            mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Hide and deactivate the unneccesary elements, and show the ones needed.
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnUpdate.Enabled = false;
            txtPreperation.Visible = false;
            checkPreperation.Visible = true;
            txtServingQuantity.Visible = false;
            numPreperation.Visible = true;
            numServing.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            lblKaiID.Visible = false;
            txtKaiID.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Reactivate the neccessary elements and disable the uneeded ones

            currencyManager.CancelCurrentEdit();
            this.BindingContext[DM.dsKaioordinate, "Kai"].EndCurrentEdit();

            checkPreperation.Visible = false;
            numPreperation.Visible = false;
            numServing.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            lblKaiID.Visible = true;
            txtKaiID.Visible = true;
            txtPreperation.Visible = true;
            txtServingQuantity.Visible=true;

            
            btnAdd.Enabled = true;  
            btnDelete.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnUpdate.Enabled = true;
            

            
            
        }

        private void KaiForm_Load(object sender, EventArgs e)
        {

        }

        //move up the list
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        //move down the list
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count)
            {
                ++currencyManager.Position;
            }
        }

        //add the new item
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblKaiID.Text = null;
            
            DataRow newKaiRow = DM.dtKai.NewRow();
            if ((txtEvent.Text == "") || (txtKaiName.Text == ""))
            {
                MessageBox.Show("You must enter a event id and a kai name");
            } else
            {
                newKaiRow["KaiName"] = txtKaiName.Text;
                newKaiRow["EventID"] = txtEvent.Text;
                if (checkPreperation.Checked)
                {
                    newKaiRow["PreparationRequired"] = true;
                }
                else
                {
                    newKaiRow["PreparationRequired"] = false;
                }
                newKaiRow["PreparationMinutes"] = txtPreperationTime.Text;
                newKaiRow["ServeQuantity"] = txtServingQuantity.Text;
                DM.dtKai.Rows.Add(newKaiRow);
                MessageBox.Show("Kai Added Successfully");
                DM.UpdateKai();
            }
        }
        //delete the selected item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[currencyManager.Position];
            if(MessageBox.Show("Are you sure you wish to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteKaiRow.Delete();
                DM.UpdateKai();
            }
        }

        //update the selected item
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
            if ((txtEvent.Text == "") || (txtKaiName.Text == "") || (txtPreperationTime.Text == "") || (txtServingQuantity.Text == ""))
            {
                MessageBox.Show("You must enter a event id, preperation time, serving quantity and a kai name", "");
            }
            else
            {
                updateKaiRow["KaiName"] = txtKaiName.Text;
                updateKaiRow["EventID"] = txtEvent.Text;
                updateKaiRow["PreparationMinutes"] = txtPreperationTime.Text;
                updateKaiRow["ServeQuantity"] = txtServingQuantity.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateKai();
                MessageBox.Show("Kai Updated Successfully", "Success");
            }

        }
    }
}
