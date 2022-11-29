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
    public partial class EditingModeAuto_clienta : Form
    {
        public EditingModeAuto_clienta()
        {
            InitializeComponent();
        }

        string _tableName = "Автомобиль клиента";

  

        private void Delete_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код клиента"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            EditingModeAuto_clienta editingModeAuto_clienta = new EditingModeAuto_clienta();
            editingModeAuto_clienta.Show();
        }

        private void Exite_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auto_clienta auto_Clienta1 = new Auto_clienta();
            auto_Clienta1.Show();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {


            this.Hide();
            Auto_clienta auto_Clienta1 = new Auto_clienta();
            auto_Clienta1.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            this.Hide();
            Auto_clienta auto_Clienta1 = new Auto_clienta();
            auto_Clienta1.Show();
        }
        private void EditingModeAuto_clienta_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }
    }
}