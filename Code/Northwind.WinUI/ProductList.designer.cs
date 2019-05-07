namespace Northwind.WinUI 
{ 
  partial class ProductList 
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
    
    #region 组件设计器生成的代码 
    
    /// <summary>  
    /// 设计器支持所需的方法 - 不要 
    /// 使用代码编辑器修改此方法的内容。 
    /// </summary> 
    private void InitializeComponent() 
    { 
            this.components = new System.ComponentModel.Container();
            this.datasourcedataGridView1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.dataPager = new EAS.Windows.UI.Controls.DataPager();
            this.panDataPager = new System.Windows.Forms.Panel();
            this.lbProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSplitButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.columnProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLMTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datasourcedataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.panDataPager.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductID,
            this.columnProductName,
            this.columnCategoryID,
            this.columnSpec,
            this.columnUnit,
            this.columnUnitPrice,
            this.columnInputCode,
            this.columnLMTime});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.dataGridView1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 70);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(784, 266);
            this.Panel2.TabIndex = 0;
            // 
            // dataPager
            // 
            this.dataPager.CurrentPage = 1;
            this.dataPager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPager.Location = new System.Drawing.Point(0, 0);
            this.dataPager.Name = "dataPager";
            this.dataPager.RecordCount = 0;
            this.dataPager.Size = new System.Drawing.Size(784, 25);
            this.dataPager.TabIndex = 0;
            this.dataPager.PageChanged += new System.EventHandler(this.dataPager_PageChanged);
            // 
            // panDataPager
            // 
            this.panDataPager.Controls.Add(this.dataPager);
            this.panDataPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDataPager.Location = new System.Drawing.Point(0, 336);
            this.panDataPager.Name = "panDataPager";
            this.panDataPager.Size = new System.Drawing.Size(784, 25);
            this.panDataPager.TabIndex = 1;
            // 
            // lbProductName
            // 
            this.lbProductName.Location = new System.Drawing.Point(15, 10);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(80, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "检索：";
            this.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(100, 10);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(200, 21);
            this.tbProductName.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lbProductName);
            this.Panel1.Controls.Add(this.tbProductName);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(784, 40);
            this.Panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 22);
            this.btnEdit.Text = "编辑(&E)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ToolStripSplitButton2
            // 
            this.ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            this.ToolStripSplitButton2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 22);
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ToolStripSplitButton3
            // 
            this.ToolStripSplitButton3.Name = "ToolStripSplitButton3";
            this.ToolStripSplitButton3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnQuery
            // 
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(54, 22);
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // ToolStripSplitButton4
            // 
            this.ToolStripSplitButton4.Name = "ToolStripSplitButton4";
            this.ToolStripSplitButton4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(51, 22);
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ToolStripSplitButton5
            // 
            this.ToolStripSplitButton5.Name = "ToolStripSplitButton5";
            this.ToolStripSplitButton5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 22);
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ToolStripSplitButton6
            // 
            this.ToolStripSplitButton6.Name = "ToolStripSplitButton6";
            this.ToolStripSplitButton6.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.ToolStripSplitButton1,
            this.btnEdit,
            this.ToolStripSplitButton2,
            this.btnDelete,
            this.ToolStripSplitButton3,
            this.btnQuery,
            this.ToolStripSplitButton4,
            this.btnPrint,
            this.ToolStripSplitButton5,
            this.btnClose,
            this.ToolStripSplitButton6});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(784, 25);
            this.ToolStrip1.TabIndex = 0;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.ToolStrip1);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(784, 30);
            this.Panel3.TabIndex = 3;
            // 
            // columnProductID
            // 
            this.columnProductID.DataPropertyName = "ProductID";
            this.columnProductID.HeaderText = "产品ID";
            this.columnProductID.Name = "columnProductID";
            this.columnProductID.ReadOnly = true;
            // 
            // columnProductName
            // 
            this.columnProductName.DataPropertyName = "ProductName";
            this.columnProductName.HeaderText = "产品名称";
            this.columnProductName.Name = "columnProductName";
            this.columnProductName.ReadOnly = true;
            // 
            // columnCategoryID
            // 
            this.columnCategoryID.DataPropertyName = "Category";
            this.columnCategoryID.HeaderText = "产品种类";
            this.columnCategoryID.Name = "columnCategoryID";
            this.columnCategoryID.ReadOnly = true;
            // 
            // columnSpec
            // 
            this.columnSpec.DataPropertyName = "Spec";
            this.columnSpec.HeaderText = "规格";
            this.columnSpec.Name = "columnSpec";
            this.columnSpec.ReadOnly = true;
            // 
            // columnUnit
            // 
            this.columnUnit.DataPropertyName = "Unit";
            this.columnUnit.HeaderText = "单位";
            this.columnUnit.Name = "columnUnit";
            this.columnUnit.ReadOnly = true;
            // 
            // columnUnitPrice
            // 
            this.columnUnitPrice.DataPropertyName = "UnitPrice";
            this.columnUnitPrice.HeaderText = "价格";
            this.columnUnitPrice.Name = "columnUnitPrice";
            this.columnUnitPrice.ReadOnly = true;
            // 
            // columnInputCode
            // 
            this.columnInputCode.DataPropertyName = "InputCode";
            this.columnInputCode.HeaderText = "输入码";
            this.columnInputCode.Name = "columnInputCode";
            this.columnInputCode.ReadOnly = true;
            // 
            // columnLMTime
            // 
            this.columnLMTime.DataPropertyName = "LMTime";
            this.columnLMTime.HeaderText = "最后更新时间";
            this.columnLMTime.Name = "columnLMTime";
            this.columnLMTime.ReadOnly = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panDataPager);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(784, 361);
            ((System.ComponentModel.ISupportInitialize)(this.datasourcedataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.panDataPager.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

    } 
    
    #endregion 
 
    private System.Windows.Forms.DataGridView dataGridView1; 
    private System.Windows.Forms.BindingSource datasourcedataGridView1; 
    private System.Windows.Forms.Panel Panel2; 
    private EAS.Windows.UI.Controls.DataPager dataPager; 
    private System.Windows.Forms.Panel panDataPager; 
    private System.Windows.Forms.Label lbProductName; 
    private System.Windows.Forms.TextBox tbProductName; 
    private System.Windows.Forms.Panel Panel1; 
    private System.Windows.Forms.ToolStripButton btnAdd; 
    private System.Windows.Forms.ToolStripSeparator ToolStripSplitButton1; 
    private System.Windows.Forms.ToolStripButton btnEdit; 
    private System.Windows.Forms.ToolStripSeparator ToolStripSplitButton2; 
    private System.Windows.Forms.ToolStripButton btnDelete; 
    private System.Windows.Forms.ToolStripSeparator ToolStripSplitButton3; 
    private System.Windows.Forms.ToolStripButton btnQuery; 
    private System.Windows.Forms.ToolStripSeparator ToolStripSplitButton4; 
    private System.Windows.Forms.ToolStripButton btnPrint; 
    private System.Windows.Forms.ToolStripSeparator ToolStripSplitButton5; 
    private System.Windows.Forms.ToolStripButton btnClose; 
    private System.Windows.Forms.ToolStripSeparator ToolStripSplitButton6; 
    private System.Windows.Forms.ToolStrip ToolStrip1; 
    private System.Windows.Forms.Panel Panel3;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnProductID;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoryID;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnSpec;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUnit;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnInputCode;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnLMTime; 
  } 
}
