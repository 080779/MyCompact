namespace WinCompact
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
            this.tabcStat = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabStat1 = new System.Windows.Forms.TabPage();
            this.tabStat2 = new System.Windows.Forms.TabPage();
            this.tabStat3 = new System.Windows.Forms.TabPage();
            this.gridViewStats1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewStats2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewStats3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.tabcStat.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabStat1.SuspendLayout();
            this.tabStat2.SuspendLayout();
            this.tabStat3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats3)).BeginInit();
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
            // tabcStat
            // 
            this.tabcStat.Controls.Add(this.tabMain);
            this.tabcStat.Controls.Add(this.tabStat1);
            this.tabcStat.Controls.Add(this.tabStat2);
            this.tabcStat.Controls.Add(this.tabStat3);
            this.tabcStat.Location = new System.Drawing.Point(0, 0);
            this.tabcStat.Name = "tabcStat";
            this.tabcStat.SelectedIndex = 0;
            this.tabcStat.Size = new System.Drawing.Size(1112, 598);
            this.tabcStat.TabIndex = 13;
            this.tabcStat.SelectedIndexChanged += new System.EventHandler(this.tabcStat_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cbType);
            this.tabMain.Controls.Add(this.gridList);
            this.tabMain.Controls.Add(this.btnAdd);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.btnSearch);
            this.tabMain.Controls.Add(this.btnReset);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1104, 572);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "首页";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabStat1
            // 
            this.tabStat1.Controls.Add(this.gridViewStats1);
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
            this.tabStat2.Controls.Add(this.gridViewStats2);
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
            this.tabStat3.Controls.Add(this.gridViewStats3);
            this.tabStat3.Location = new System.Drawing.Point(4, 22);
            this.tabStat3.Name = "tabStat3";
            this.tabStat3.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat3.Size = new System.Drawing.Size(1104, 572);
            this.tabStat3.TabIndex = 3;
            this.tabStat3.Text = "表三";
            this.tabStat3.UseVisualStyleBackColor = true;
            // 
            // gridViewStats1
            // 
            this.gridViewStats1.AllowUserToAddRows = false;
            this.gridViewStats1.AllowUserToDeleteRows = false;
            this.gridViewStats1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewStats1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStats1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TypeId1,
            this.dataGridViewTextBoxColumn4,
            this.QuarterNumber,
            this.QuarterAmount,
            this.YearNumber,
            this.YearAmount,
            this.TotalNumber,
            this.TotalAmount});
            this.gridViewStats1.Location = new System.Drawing.Point(2, 16);
            this.gridViewStats1.Name = "gridViewStats1";
            this.gridViewStats1.ReadOnly = true;
            this.gridViewStats1.RowTemplate.Height = 23;
            this.gridViewStats1.Size = new System.Drawing.Size(1101, 540);
            this.gridViewStats1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "类别";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn3.HeaderText = "项目";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // TypeId1
            // 
            this.TypeId1.DataPropertyName = "TypeId";
            this.TypeId1.HeaderText = "类别Id";
            this.TypeId1.Name = "TypeId1";
            this.TypeId1.ReadOnly = true;
            this.TypeId1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemId";
            this.dataGridViewTextBoxColumn4.HeaderText = "项目Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // QuarterNumber
            // 
            this.QuarterNumber.DataPropertyName = "QuarterNumber";
            this.QuarterNumber.HeaderText = "本期完成数量";
            this.QuarterNumber.Name = "QuarterNumber";
            this.QuarterNumber.ReadOnly = true;
            // 
            // QuarterAmount
            // 
            this.QuarterAmount.DataPropertyName = "QuarterAmount";
            this.QuarterAmount.HeaderText = "本期完成金额";
            this.QuarterAmount.Name = "QuarterAmount";
            this.QuarterAmount.ReadOnly = true;
            // 
            // YearNumber
            // 
            this.YearNumber.DataPropertyName = "YearNumber";
            this.YearNumber.HeaderText = "本年完成数量";
            this.YearNumber.Name = "YearNumber";
            this.YearNumber.ReadOnly = true;
            // 
            // YearAmount
            // 
            this.YearAmount.DataPropertyName = "YearAmount";
            this.YearAmount.HeaderText = "本年完成金额";
            this.YearAmount.Name = "YearAmount";
            this.YearAmount.ReadOnly = true;
            // 
            // TotalNumber
            // 
            this.TotalNumber.DataPropertyName = "TotalNumber";
            this.TotalNumber.HeaderText = "开累完成数量";
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "开累完成金额";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // gridViewStats2
            // 
            this.gridViewStats2.AllowUserToAddRows = false;
            this.gridViewStats2.AllowUserToDeleteRows = false;
            this.gridViewStats2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewStats2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStats2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.gridViewStats2.Location = new System.Drawing.Point(2, 16);
            this.gridViewStats2.Name = "gridViewStats2";
            this.gridViewStats2.ReadOnly = true;
            this.gridViewStats2.RowTemplate.Height = 23;
            this.gridViewStats2.Size = new System.Drawing.Size(1101, 540);
            this.gridViewStats2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "序号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn6.HeaderText = "类别";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn7.HeaderText = "项目";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TypeId";
            this.dataGridViewTextBoxColumn8.HeaderText = "类别Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ItemId";
            this.dataGridViewTextBoxColumn9.HeaderText = "项目Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QuarterNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "本期完成数量";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "QuarterAmount";
            this.dataGridViewTextBoxColumn11.HeaderText = "本期完成金额";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "YearNumber";
            this.dataGridViewTextBoxColumn12.HeaderText = "本年完成数量";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "YearAmount";
            this.dataGridViewTextBoxColumn13.HeaderText = "本年完成金额";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TotalNumber";
            this.dataGridViewTextBoxColumn14.HeaderText = "开累完成数量";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn15.HeaderText = "开累完成金额";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // gridViewStats3
            // 
            this.gridViewStats3.AllowUserToAddRows = false;
            this.gridViewStats3.AllowUserToDeleteRows = false;
            this.gridViewStats3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewStats3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStats3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.gridViewStats3.Location = new System.Drawing.Point(2, 16);
            this.gridViewStats3.Name = "gridViewStats3";
            this.gridViewStats3.ReadOnly = true;
            this.gridViewStats3.RowTemplate.Height = 23;
            this.gridViewStats3.Size = new System.Drawing.Size(1101, 540);
            this.gridViewStats3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn16.HeaderText = "序号";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn17.HeaderText = "类别";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 250;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn18.HeaderText = "项目";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 200;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TypeId";
            this.dataGridViewTextBoxColumn19.HeaderText = "类别Id";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ItemId";
            this.dataGridViewTextBoxColumn20.HeaderText = "项目Id";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "QuarterNumber";
            this.dataGridViewTextBoxColumn21.HeaderText = "本期完成数量";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "QuarterAmount";
            this.dataGridViewTextBoxColumn22.HeaderText = "本期完成金额";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "YearNumber";
            this.dataGridViewTextBoxColumn23.HeaderText = "本年完成数量";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "YearAmount";
            this.dataGridViewTextBoxColumn24.HeaderText = "本年完成金额";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "TotalNumber";
            this.dataGridViewTextBoxColumn25.HeaderText = "开累完成数量";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn26.HeaderText = "开累完成金额";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 596);
            this.Controls.Add(this.tabcStat);
            this.Name = "Home";
            this.Text = "铁路征地拆迁安置验工计价统计系统";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.tabcStat.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabStat1.ResumeLayout(false);
            this.tabStat2.ResumeLayout(false);
            this.tabStat3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats3)).EndInit();
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
        private System.Windows.Forms.TabControl tabcStat;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabStat1;
        private System.Windows.Forms.TabPage tabStat2;
        private System.Windows.Forms.TabPage tabStat3;
        private System.Windows.Forms.DataGridView gridViewStats1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridView gridViewStats2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView gridViewStats3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
    }
}

