using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuongkientrucContext;
using ExWeek.BLL;

namespace ExWeek.PL
{
    public partial class RamForm : Form
    {
        public RamForm()
        {
            InitializeComponent();
        }

        private void RamForm_Load(object sender, EventArgs e)
        {
            List<Ram> rams = new RamBUS().getAll();
            drvRam.DataSource = rams;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String nameSearch = txtSearch.Text.Trim();
            List<Ram> rams = new RamBUS().NameSearch(nameSearch);
            drvRam.DataSource = rams;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ram newRam = new Ram()
            {

                Name = txtName.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Bus = int.Parse(txtBus.Text.Trim()),
                Type = txtType.Text.Trim()
            };



            bool result = new RamBUS().Insert(newRam);
            if (result)
            {
                List<Ram> rams = new RamBUS().getAll();
                drvRam.DataSource = rams;


            }
            else
                MessageBox.Show("Sorry! You can't Insert it");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtCode.Text.Trim());
            String name = (txtName.Text.Trim());
            int price = int.Parse(txtPrice.Text.Trim());
            int bus = int.Parse(txtBus.Text.Trim());
            String type = (txtType.Text.Trim());
            Ram newRam = new Ram()
            {
                Code = code,
                Name = name,
                Price = price,
                Bus = bus,
                Type = type
            };
            bool result = new RamBUS().Update(newRam);
            if (result)
            {
                List<Ram> rams = new RamBUS().getAll();
                drvRam.DataSource = rams;
            }
            else
            {
                MessageBox.Show("Sorry! You can't update it");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int code = int.Parse(txtCode.Text.Trim());

            DialogResult dialogResult = MessageBox.Show("Are you sure? It could be important data.", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = new RamBUS().DeleteProd(code);
                if (result)
                {
                    List<Ram> rams = new RamBUS().getAll();
                    drvRam.DataSource = rams;
                }
                else
                {

                    MessageBox.Show("Sorry! You can't delete it");
                }
            }
        }

        private void drvRam_SelectionChanged(object sender, EventArgs e)
        {
            if (drvRam.SelectedRows.Count > 0)
            {
                int code = int.Parse(drvRam.SelectedRows[0].Cells["Code"].Value.ToString());
                Ram ram = new RamBUS().GetDetails(code);
                if (ram != null)
                {
                    txtCode.Text = ram.Code.ToString();
                    txtName.Text = ram.Name;
                    txtPrice.Text = ram.Price.ToString();
                    txtBus.Text = ram.Bus.ToString();
                    txtType.Text = ram.Type;
                }

            }
        }
    }
}
