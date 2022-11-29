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
using WindowsAPI.DataBaseEditor;

namespace WindowsFormsApp1.DataBaseEditor
{
    public partial class FormEditorTable1 : Form
    {
        public FormEditorTable1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Auto_clienta auto_Clienta = new Auto_clienta();
            auto_Clienta.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Clients clients = new Clients();
            clients.Show();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Zapchasti zapchasti = new Zapchasti();
            zapchasti.Show();
        }
    }
}
