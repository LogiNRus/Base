using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLib;
using WindowsAPI.EditingMode;
using WindowsFormsApp1.DataBaseEditor;

namespace WindowsAPI.DataBaseEditor
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        string _tableName = "Продажи";
        private void button1_Click(object sender, EventArgs e)
        {
            string[] args = new string[3];
            args[0] = textBox1.Text;
            args[1] = textBox2.Text;
            args[2] = textBox3.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Insert(args, _tableName);

            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(number, _tableName);

            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditingModeSales editingModeSales = new EditingModeSales();
            editingModeSales.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditorTable1 formEditorTable1= new FormEditorTable1();
            formEditorTable1.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}