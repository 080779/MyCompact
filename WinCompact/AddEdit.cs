using IMS.Service.Service;
using Service.Enums;
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
    public partial class AddEdit : Form
    {
        private readonly CheckWorkService checkWorkService = new CheckWorkService();
        private string action;
        private long id;
        public AddEdit(string action, long id = 0)
        {
            this.action = action;
            this.id = id;
            InitializeComponent();
        }

        private void AddEdit_Load(object sender, EventArgs e)
        {
            cbType.DataSource = MyEnumHelper.GetEnumList<TypeEnum>();
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.SelectedIndex = 0;
            cbItem.DataSource = MyEnumHelper.GetEnumList<ItemEnum>().Where(i => i.Id < 10).ToList();
            cbItem.DisplayMember = "Name";
            cbItem.ValueMember = "Id";
            cbItem.SelectedIndex = 0;

            if (action=="Edit")
            {
                var res = checkWorkService.GetModel(id);
                if(res==null)
                {
                    return;
                }
                cbType.SelectedValue = res.TypeId;
                cbItem.SelectedValue = res.ItemId;
                txtNumber.Text = res.Number.ToString();
                txtAmount.Text = res.Amount.ToString();
            }
        }

        protected void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(cbType.SelectedValue.ToString(), out id);
            if (id < 4)
            {
                cbItem.DataSource = MyEnumHelper.GetEnumList<ItemEnum>().Where(i => i.Id < 10).ToList();
                cbItem.DisplayMember = "Name";
                cbItem.ValueMember = "Id";
                cbItem.SelectedIndex = 0;
            }
            if(id == 4)
            {
                cbItem.DataSource = MyEnumHelper.GetEnumList<ItemEnum>().Where(i => i.Id >= 10 && i.Id < 20).ToList();
                cbItem.DisplayMember = "Name";
                cbItem.ValueMember = "Id";
                cbItem.SelectedIndex = 0;
            }
            if (id == 5)
            {
                cbItem.DataSource = MyEnumHelper.GetEnumList<ItemEnum>().Where(i => i.Id >= 20).ToList();
                cbItem.DisplayMember = "Name";
                cbItem.ValueMember = "Id";
                cbItem.SelectedIndex = 0;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int typeId;
            int itemId;
            decimal number;
            decimal amount;
            int.TryParse(cbType.SelectedValue.ToString(),out typeId);
            int.TryParse(cbItem.SelectedValue.ToString(), out itemId);
            decimal.TryParse(txtNumber.Text,out number);
            decimal.TryParse(txtAmount.Text, out amount);
            long res = checkWorkService.Add(typeId,itemId,number,amount);
            if (res <= 0)
            {
                MessageBox.Show("录入失败");
                return;
            }
            MessageBox.Show("录入成功");
            Home home;
            home = (Home)this.Owner;
            home.Bind();
            Close();
        }
    }
}
