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
    public partial class EditingModeZapchasti : Form
    {
        public EditingModeZapchasti()
        {
            InitializeComponent();
        }

        string _tableName = "Запчасти";

        private void EditingModeZapchasti_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void Exite_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Zapchasti zapchasti = new Zapchasti();
            zapchasti.Show();
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код клиента"].Value);
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            EditingModeZapchasti editingModeZapchasti = new EditingModeZapchasti();
            editingModeZapchasti.Show();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Zapchasti zapchasti = new Zapchasti();
            zapchasti.Show();
        }

        private void BtnInsert_Click_1(object sender, EventArgs e)
        {
            Zapchasti zapchasti = new Zapchasti();
            zapchasti.Show();
        }
    }
}