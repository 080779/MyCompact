using Service;
using Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCompact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                PersonEntity person = new PersonEntity();
                person.Name = "aa";
                dbc.Persons.Add(person);
                dbc.SaveChanges();
                MessageBox.Show(person.Id.ToString());
            }
        }
    }
}
