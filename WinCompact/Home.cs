using IMS.Service.Service;
using Service;
using Service.Enums;
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
    public partial class Home : Form
    {
        private readonly CheckWorkService checkWorkService = new CheckWorkService();
        private int pageSize = 20;
        private int pageIndex = 1;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbType.DataSource = MyEnumHelper.GetEnumList<TypeEnum>();
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.SelectedIndex = 0;
            Bind();
        }
        public void Bind()
        {
            gridList.DataSource = checkWorkService.GetModelList(null, null, null, null, pageIndex, pageSize).List;
        }

        private void GridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long id;
            string str =this.gridList.CurrentRow.Cells["Id"].Value.ToString();
            long.TryParse(str, out id);
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("确定要删除这条数据吗", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                bool res = checkWorkService.Del(id);
                if(!res)
                {
                    MessageBox.Show("删除失败");
                    return;
                }
                MessageBox.Show("删除成功");
                Bind();
            }
            else if (e.ColumnIndex == 0)
            {
                AddEdit form = new AddEdit("Edit",id);
                form.Owner = this;
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEdit form = new AddEdit("Add");
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int typeId;
            int.TryParse(cbType.SelectedValue.ToString(), out typeId);
            gridList.DataSource = checkWorkService.GetModelList(typeId, null, null, null, pageIndex, pageSize).List;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
