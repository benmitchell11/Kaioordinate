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
    public partial class ReportPreview : Form
    {
        public ReportPreview()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu;
            mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void ReportPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
