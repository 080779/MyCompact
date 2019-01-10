using IMS.Service.Service;
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
    public partial class Stat : Form
    {
        private readonly StatService statService = new StatService();
        private int typeId;
        public Stat(int typeId)
        {
            this.typeId = typeId;
            InitializeComponent();
        }

        private void Stat_Load(object sender, EventArgs e)
        {
            gridViewStats.DataSource = statService.GetModelList(typeId, null,1,20).List;
        }
    }
}
