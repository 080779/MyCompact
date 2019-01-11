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
        private readonly StatService statService = new StatService();
        private int pageSize = 20;
        private int pageIndex = 1;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var typeList= MyEnumHelper.GetEnumList<TypeEnum>();
            cbType.DataSource = typeList;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.SelectedIndex = 0;
            statService.Add();
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

        private void tabcStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabcStat.SelectedIndex==1)
            {
                gridViewStats1.DataSource = statService.GetModelList((int)TypeEnum.三改用地1道路0水利设施改移1建2用地2, null,1,pageSize).List;
            }
            if (tabcStat.SelectedIndex == 2)
            {
                gridViewStats2.DataSource = statService.GetModelList((int)TypeEnum.红线内用地1含边角地2, null, 1, pageSize).List;
            }
            if (tabcStat.SelectedIndex == 3)
            {
                gridViewStats3.DataSource = statService.GetModelList((int)TypeEnum.回建地, null, 1, pageSize).List;
            }
        }
    }
}
