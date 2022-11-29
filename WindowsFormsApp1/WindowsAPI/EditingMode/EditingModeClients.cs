using DataBaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAPI.DataBaseEditor;

namespace WindowsAPI.EditingMode
{
    public partial class EditingModeClients : Form
    {
        public EditingModeClients()
        {
            InitializeComponent();
        }

        string _tableName = "Клиенты";



        private void Delete_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код клиента"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);


            this.Hide();
            EditingModeClients editingModeClients = new EditingModeClients();
            editingModeClients.Show();
        }



        private void BtnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void EditingModeClients_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

  

        private void Exite_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void BtnInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click_1(object sender, EventArgs e)
        {

        }
    }
}