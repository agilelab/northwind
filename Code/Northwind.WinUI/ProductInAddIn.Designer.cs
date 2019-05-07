namespace Northwind.WinUI
{
    partial class ProductInAddIn
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
            EAS.Windows.UI.Controls.ValidEntity validEntity1 = new EAS.Windows.UI.Controls.ValidEntity();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInAddIn));
            EAS.Windows.UI.Controls.ValidEntity validEntity2 = new EAS.Windows.UI.Controls.ValidEntity();
            EAS.Windows.UI.Controls.ValidEntity validEntity3 = new EAS.Windows.UI.Controls.ValidEntity();
            EAS.Windows.UI.Controls.ValidEntity validEntity4 = new EAS.Windows.UI.Controls.ValidEntity();
            EAS.Windows.UI.Controls.ValidEntity validEntity5 = new EAS.Windows.UI.Controls.ValidEntity();
            EAS.Windows.UI.Controls.ValidEntity validEntity6 = new EAS.Windows.UI.Controls.ValidEntity();
            this.panMethod = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBillCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inBillDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.textBoxAutoComplete1 = new EAS.Windows.UI.Controls.TextBoxAutoComplete(this.components);
            this.textBoxValidator1 = new EAS.Windows.UI.Controls.TextBoxValidator(this.components);
            this.panMethod.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBillDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panMethod
            // 
            this.panMethod.Controls.Add(this.btnPrint);
            this.panMethod.Controls.Add(this.tbPrice);
            this.panMethod.Controls.Add(this.label11);
            this.panMethod.Controls.Add(this.tbNumber);
            this.panMethod.Controls.Add(this.label6);
            this.panMethod.Controls.Add(this.tbUnit);
            this.panMethod.Controls.Add(this.label7);
            this.panMethod.Controls.Add(this.btnClose);
            this.panMethod.Controls.Add(this.btnOK);
            this.panMethod.Controls.Add(this.tbSpec);
            this.panMethod.Controls.Add(this.label5);
            this.panMethod.Controls.Add(this.tbName);
            this.panMethod.Controls.Add(this.label3);
            this.panMethod.Controls.Add(this.tbBillCode);
            this.panMethod.Controls.Add(this.label1);
            this.panMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMethod.Location = new System.Drawing.Point(0, 30);
            this.panMethod.Name = "panMethod";
            this.panMethod.Size = new System.Drawing.Size(947, 68);
            this.panMethod.TabIndex = 1;
            this.panMethod.TabStop = true;
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, false);
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnPrint, true);
            this.btnPrint.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnPrint.Location = new System.Drawing.Point(790, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbPrice, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbPrice, false);
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbPrice, false);
            this.inputControlEnter1.SetFocus(this.tbPrice, true);
            this.tbPrice.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tbPrice.Location = new System.Drawing.Point(239, 37);
            this.textBoxAutoComplete1.SetMetadataID(this.tbPrice, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbPrice.Name = "tbPrice";
            this.textBoxAutoComplete1.SetNextControl(this.tbPrice, null);
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(83, 23);
            this.tbPrice.TabIndex = 9;
            validEntity1.CustomRule = null;
            validEntity1.Icon = ((System.Drawing.Icon)(resources.GetObject("validEntity1.Icon")));
            validEntity1.Name = null;
            this.textBoxValidator1.SetValid(this.tbPrice, validEntity1);
            // 
            // label11
            // 
            this.controlAutoFocus1.SetAllowNext(this.label11, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label11, false);
            this.label11.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label11, false);
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label11.Location = new System.Drawing.Point(166, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 8;
            this.label11.Text = "价    格：";
            // 
            // tbNumber
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbNumber, false);
            this.controlAutoFocus1.SetAllowPrevious(this.tbNumber, false);
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbNumber, false);
            this.inputControlEnter1.SetFocus(this.tbNumber, true);
            this.tbNumber.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tbNumber.Location = new System.Drawing.Point(407, 37);
            this.textBoxAutoComplete1.SetMetadataID(this.tbNumber, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbNumber.Name = "tbNumber";
            this.textBoxAutoComplete1.SetNextControl(this.tbNumber, null);
            this.tbNumber.Size = new System.Drawing.Size(108, 23);
            this.tbNumber.TabIndex = 11;
            validEntity2.CustomRule = null;
            validEntity2.Icon = ((System.Drawing.Icon)(resources.GetObject("validEntity2.Icon")));
            validEntity2.Name = "价格";
            validEntity2.Required = true;
            validEntity2.Rule = EAS.Windows.UI.Controls.ValidRule.Integer;
            this.textBoxValidator1.SetValid(this.tbNumber, validEntity2);
            this.tbNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumber_KeyDown);
            // 
            // label6
            // 
            this.controlAutoFocus1.SetAllowNext(this.label6, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label6, false);
            this.label6.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label6, false);
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label6.Location = new System.Drawing.Point(335, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "数    量：";
            // 
            // tbUnit
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbUnit, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbUnit, false);
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbUnit, false);
            this.tbUnit.BackColor = System.Drawing.Color.White;
            this.inputControlEnter1.SetFocus(this.tbUnit, true);
            this.tbUnit.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tbUnit.Location = new System.Drawing.Point(77, 36);
            this.textBoxAutoComplete1.SetMetadataID(this.tbUnit, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbUnit.Name = "tbUnit";
            this.textBoxAutoComplete1.SetNextControl(this.tbUnit, null);
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(83, 23);
            this.tbUnit.TabIndex = 7;
            validEntity3.CustomRule = null;
            validEntity3.Icon = ((System.Drawing.Icon)(resources.GetObject("validEntity3.Icon")));
            validEntity3.Name = null;
            this.textBoxValidator1.SetValid(this.tbUnit, validEntity3);
            // 
            // label7
            // 
            this.controlAutoFocus1.SetAllowNext(this.label7, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label7, false);
            this.label7.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label7, false);
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "单   位：";
            // 
            // btnClose
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnClose, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnClose, false);
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnClose, true);
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnClose.Location = new System.Drawing.Point(869, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnOK, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnOK, false);
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControlEnter1.SetFocus(this.btnOK, true);
            this.btnOK.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnOK.Location = new System.Drawing.Point(709, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "入库(&D)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbSpec
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbSpec, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbSpec, false);
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbSpec, false);
            this.tbSpec.BackColor = System.Drawing.Color.White;
            this.tbSpec.Enabled = false;
            this.inputControlEnter1.SetFocus(this.tbSpec, true);
            this.tbSpec.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tbSpec.Location = new System.Drawing.Point(584, 10);
            this.textBoxAutoComplete1.SetMetadataID(this.tbSpec, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbSpec.Name = "tbSpec";
            this.textBoxAutoComplete1.SetNextControl(this.tbSpec, null);
            this.tbSpec.Size = new System.Drawing.Size(108, 23);
            this.tbSpec.TabIndex = 5;
            validEntity4.CustomRule = null;
            validEntity4.Icon = ((System.Drawing.Icon)(resources.GetObject("validEntity4.Icon")));
            validEntity4.Name = null;
            this.textBoxValidator1.SetValid(this.tbSpec, validEntity4);
            // 
            // label5
            // 
            this.controlAutoFocus1.SetAllowNext(this.label5, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label5, false);
            this.label5.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label5, false);
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(511, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "规    格：";
            // 
            // tbName
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbName, false);
            this.controlAutoFocus1.SetAllowPrevious(this.tbName, false);
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbName, false);
            this.tbName.BackColor = System.Drawing.Color.White;
            this.inputControlEnter1.SetFocus(this.tbName, true);
            this.tbName.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tbName.Location = new System.Drawing.Point(239, 9);
            this.textBoxAutoComplete1.SetMetadataID(this.tbName, new System.Guid("1e314c3b-fd67-4452-86a6-0ece1955909f"));
            this.tbName.Name = "tbName";
            this.textBoxAutoComplete1.SetNextControl(this.tbName, null);
            this.tbName.Size = new System.Drawing.Size(257, 23);
            this.tbName.TabIndex = 3;
            validEntity5.CustomRule = null;
            validEntity5.Icon = ((System.Drawing.Icon)(resources.GetObject("validEntity5.Icon")));
            validEntity5.Name = null;
            this.textBoxValidator1.SetValid(this.tbName, validEntity5);
            // 
            // label3
            // 
            this.controlAutoFocus1.SetAllowNext(this.label3, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label3, false);
            this.label3.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label3, false);
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(166, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "名    称：";
            // 
            // tbBillCode
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbBillCode, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbBillCode, false);
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbBillCode, false);
            this.inputControlEnter1.SetFocus(this.tbBillCode, true);
            this.tbBillCode.Font = new System.Drawing.Font("宋体", 10.5F);
            this.tbBillCode.Location = new System.Drawing.Point(77, 9);
            this.textBoxAutoComplete1.SetMetadataID(this.tbBillCode, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbBillCode.Name = "tbBillCode";
            this.textBoxAutoComplete1.SetNextControl(this.tbBillCode, null);
            this.tbBillCode.ReadOnly = true;
            this.tbBillCode.Size = new System.Drawing.Size(83, 23);
            this.tbBillCode.TabIndex = 1;
            validEntity6.CustomRule = null;
            validEntity6.Icon = ((System.Drawing.Icon)(resources.GetObject("validEntity6.Icon")));
            validEntity6.Name = null;
            this.textBoxValidator1.SetValid(this.tbBillCode, validEntity6);
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "单据号：";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTop.Controls.Add(this.ledClock);
            this.pnTop.Controls.Add(this.label38);
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(947, 30);
            this.pnTop.TabIndex = 0;
            this.pnTop.TabStop = true;
            // 
            // ledClock
            // 
            this.controlAutoFocus1.SetAllowNext(this.ledClock, false);
            this.controlAutoFocus1.SetAllowPrevious(this.ledClock, false);
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2014, 4, 13, 17, 24, 22, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(780, 3);
            this.ledClock.Name = "ledClock";
            this.ledClock.Size = new System.Drawing.Size(144, 23);
            this.ledClock.TabIndex = 10;
            // 
            // label38
            // 
            this.controlAutoFocus1.SetAllowNext(this.label38, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label38, false);
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label38, false);
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(710, 8);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 14);
            this.label38.TabIndex = 9;
            this.label38.Text = "当前时间：";
            // 
            // lbTitle
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbTitle, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbTitle, false);
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.lbTitle, false);
            this.lbTitle.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(10, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(102, 21);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "采购入库";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.controlAutoFocus1.SetAllowNext(this.dataGridView1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.dataGridView1, false);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inBillDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.dataGridView1, false);
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(947, 434);
            this.dataGridView1.TabIndex = 2;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "商品";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "入库数量";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // inBillDetailBindingSource
            // 
            this.inBillDetailBindingSource.AllowNew = true;
            this.inBillDetailBindingSource.DataSource = typeof(Northwind.Entities.InBillDetail);
            // 
            // controlAutoFocus1
            // 
            this.controlAutoFocus1.NextKeys = null;
            this.controlAutoFocus1.PreviousKeys = null;
            // 
            // inputControlEnter1
            // 
            this.inputControlEnter1.DroppedDown = true;
            this.inputControlEnter1.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputControlEnter1.EnterForeColor = System.Drawing.Color.Red;
            // 
            // textBoxAutoComplete1
            // 
            this.textBoxAutoComplete1.Enabled = true;
            this.textBoxAutoComplete1.InputComplete += new System.EventHandler<EAS.Windows.UI.Controls.TextBoxInputEventAgrs>(this.textBoxAutoComplete1_InputComplete);
            // 
            // ProductInAddIn
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panMethod);
            this.Controls.Add(this.pnTop);
            this.inputControlEnter1.SetFocus(this, false);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ProductInAddIn";
            this.Size = new System.Drawing.Size(947, 532);
            this.panMethod.ResumeLayout(false);
            this.panMethod.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBillDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMethod;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbSpec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBillCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTop;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource inBillDetailBindingSource;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;
        private EAS.Windows.UI.Controls.TextBoxAutoComplete textBoxAutoComplete1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private EAS.Windows.UI.Controls.TextBoxValidator textBoxValidator1;
    }
}
