namespace WinCompact
{
    partial class Stat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewStats = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewStats
            // 
            this.gridViewStats.AllowUserToAddRows = false;
            this.gridViewStats.AllowUserToDeleteRows = false;
            this.gridViewStats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TypeName,
            this.ItemName,
            this.TypeId1,
            this.ItemId,
            this.QuarterNumber,
            this.QuarterAmount,
            this.YearNumber,
            this.YearAmount,
            this.TotalNumber,
            this.TotalAmount});
            this.gridViewStats.Location = new System.Drawing.Point(1, 1);
            this.gridViewStats.Name = "gridViewStats";
            this.gridViewStats.ReadOnly = true;
            this.gridViewStats.RowTemplate.Height = 23;
            this.gridViewStats.Size = new System.Drawing.Size(1101, 540);
            this.gridViewStats.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类别";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.Width = 250;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "项目";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 200;
            // 
            // TypeId1
            // 
            this.TypeId1.DataPropertyName = "TypeId";
            this.TypeId1.HeaderText = "类别Id";
            this.TypeId1.Name = "TypeId1";
            this.TypeId1.ReadOnly = true;
            this.TypeId1.Visible = false;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "项目Id";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
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
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 542);
            this.Controls.Add(this.gridViewStats);
            this.Name = "Stat";
            this.Text = "Stat";
            this.Load += new System.EventHandler(this.Stat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}