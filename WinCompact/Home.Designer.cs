﻿namespace WinCompact
{
    partial class Home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gridList = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Del = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStat1 = new System.Windows.Forms.Button();
            this.btnStat2 = new System.Windows.Forms.Button();
            this.btnStat3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabStat1 = new System.Windows.Forms.TabPage();
            this.tabStat2 = new System.Windows.Forms.TabPage();
            this.tabStat3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridList
            // 
            this.gridList.AllowUserToAddRows = false;
            this.gridList.AllowUserToDeleteRows = false;
            this.gridList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Del,
            this.Id,
            this.TypeName,
            this.TypeId,
            this.ItemName,
            this.ItemId,
            this.Number,
            this.Amount,
            this.CreateTime});
            this.gridList.Location = new System.Drawing.Point(3, 47);
            this.gridList.Name = "gridList";
            this.gridList.ReadOnly = true;
            this.gridList.RowTemplate.Height = 23;
            this.gridList.Size = new System.Drawing.Size(1098, 525);
            this.gridList.TabIndex = 0;
            this.gridList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewData_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "编辑";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "编辑";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 45;
            // 
            // Del
            // 
            this.Del.HeaderText = "删除";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Del.Text = "删除";
            this.Del.UseColumnTextForLinkValue = true;
            this.Del.Width = 45;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 54;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类别";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.Width = 250;
            // 
            // TypeId
            // 
            this.TypeId.DataPropertyName = "TypeId";
            this.TypeId.HeaderText = "类别Id";
            this.TypeId.Name = "TypeId";
            this.TypeId.ReadOnly = true;
            this.TypeId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "项目";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 300;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "项目Id";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "数量";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "金额";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "录入时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 175;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(473, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "录入";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "类别：";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(56, 6);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(237, 20);
            this.cbType.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(320, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(401, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(48, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStat1
            // 
            this.btnStat1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStat1.Location = new System.Drawing.Point(576, 4);
            this.btnStat1.Name = "btnStat1";
            this.btnStat1.Size = new System.Drawing.Size(75, 23);
            this.btnStat1.TabIndex = 10;
            this.btnStat1.Text = "表一";
            this.btnStat1.UseVisualStyleBackColor = false;
            this.btnStat1.Click += new System.EventHandler(this.btnStat1_Click);
            // 
            // btnStat2
            // 
            this.btnStat2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStat2.Location = new System.Drawing.Point(657, 4);
            this.btnStat2.Name = "btnStat2";
            this.btnStat2.Size = new System.Drawing.Size(75, 23);
            this.btnStat2.TabIndex = 11;
            this.btnStat2.Text = "表二";
            this.btnStat2.UseVisualStyleBackColor = false;
            this.btnStat2.Click += new System.EventHandler(this.btnStat2_Click);
            // 
            // btnStat3
            // 
            this.btnStat3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStat3.Location = new System.Drawing.Point(738, 3);
            this.btnStat3.Name = "btnStat3";
            this.btnStat3.Size = new System.Drawing.Size(75, 23);
            this.btnStat3.TabIndex = 12;
            this.btnStat3.Text = "表三";
            this.btnStat3.UseVisualStyleBackColor = false;
            this.btnStat3.Click += new System.EventHandler(this.btnStat3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabStat1);
            this.tabControl1.Controls.Add(this.tabStat2);
            this.tabControl1.Controls.Add(this.tabStat3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 598);
            this.tabControl1.TabIndex = 13;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cbType);
            this.tabMain.Controls.Add(this.gridList);
            this.tabMain.Controls.Add(this.btnStat3);
            this.tabMain.Controls.Add(this.btnAdd);
            this.tabMain.Controls.Add(this.btnStat2);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.btnStat1);
            this.tabMain.Controls.Add(this.btnSearch);
            this.tabMain.Controls.Add(this.btnReset);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1104, 572);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "主视图";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabStat1
            // 
            this.tabStat1.Location = new System.Drawing.Point(4, 22);
            this.tabStat1.Name = "tabStat1";
            this.tabStat1.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat1.Size = new System.Drawing.Size(1104, 572);
            this.tabStat1.TabIndex = 1;
            this.tabStat1.Text = "表一";
            this.tabStat1.UseVisualStyleBackColor = true;
            // 
            // tabStat2
            // 
            this.tabStat2.Location = new System.Drawing.Point(4, 22);
            this.tabStat2.Name = "tabStat2";
            this.tabStat2.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat2.Size = new System.Drawing.Size(1104, 572);
            this.tabStat2.TabIndex = 2;
            this.tabStat2.Text = "表二";
            this.tabStat2.UseVisualStyleBackColor = true;
            // 
            // tabStat3
            // 
            this.tabStat3.Location = new System.Drawing.Point(4, 22);
            this.tabStat3.Name = "tabStat3";
            this.tabStat3.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat3.Size = new System.Drawing.Size(1104, 572);
            this.tabStat3.TabIndex = 3;
            this.tabStat3.Text = "表三";
            this.tabStat3.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "铁路征地拆迁安置验工计价统计系统";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridList;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStat1;
        private System.Windows.Forms.Button btnStat2;
        private System.Windows.Forms.Button btnStat3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabStat1;
        private System.Windows.Forms.TabPage tabStat2;
        private System.Windows.Forms.TabPage tabStat3;
    }
}

