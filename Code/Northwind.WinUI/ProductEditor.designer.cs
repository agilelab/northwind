namespace Northwind.WinUI 
{ 
  partial class ProductEditor 
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
            this.lbProductID = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.tbCategoryID = new System.Windows.Forms.TextBox();
            this.lbSpec = new System.Windows.Forms.Label();
            this.tbSpec = new System.Windows.Forms.TextBox();
            this.lbUnit = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.lbInputCode = new System.Windows.Forms.Label();
            this.tbInputCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.textBoxAutoComplete1 = new EAS.Windows.UI.Controls.TextBoxAutoComplete(this.components);
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.inputControlEnter1.SetFocus(this.lbProductID, false);
            this.lbProductID.Location = new System.Drawing.Point(25, 30);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(80, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "产品ID：";
            this.lbProductID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProductID
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbProductID, false);
            this.inputControlEnter1.SetFocus(this.tbProductID, true);
            this.tbProductID.Location = new System.Drawing.Point(110, 30);
            this.textBoxAutoComplete1.SetMetadataID(this.tbProductID, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbProductID.Name = "tbProductID";
            this.textBoxAutoComplete1.SetNextControl(this.tbProductID, null);
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(200, 21);
            this.tbProductID.TabIndex = 1;
            // 
            // lbProductName
            // 
            this.inputControlEnter1.SetFocus(this.lbProductName, false);
            this.lbProductName.Location = new System.Drawing.Point(25, 60);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(80, 20);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "产品名称：";
            this.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProductName
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbProductName, false);
            this.inputControlEnter1.SetFocus(this.tbProductName, true);
            this.tbProductName.Location = new System.Drawing.Point(110, 60);
            this.textBoxAutoComplete1.SetMetadataID(this.tbProductName, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbProductName.Name = "tbProductName";
            this.textBoxAutoComplete1.SetNextControl(this.tbProductName, null);
            this.tbProductName.Size = new System.Drawing.Size(200, 21);
            this.tbProductName.TabIndex = 3;
            this.tbProductName.TextChanged += new System.EventHandler(this.tbProductName_TextChanged);
            // 
            // lbCategoryID
            // 
            this.inputControlEnter1.SetFocus(this.lbCategoryID, false);
            this.lbCategoryID.Location = new System.Drawing.Point(25, 90);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(80, 20);
            this.lbCategoryID.TabIndex = 4;
            this.lbCategoryID.Text = "产品种类：";
            this.lbCategoryID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCategoryID
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbCategoryID, false);
            this.inputControlEnter1.SetFocus(this.tbCategoryID, true);
            this.tbCategoryID.Location = new System.Drawing.Point(110, 90);
            this.textBoxAutoComplete1.SetMetadataID(this.tbCategoryID, new System.Guid("02722875-ef9a-49cb-a522-0c0687ff4d02"));
            this.tbCategoryID.Name = "tbCategoryID";
            this.textBoxAutoComplete1.SetNextControl(this.tbCategoryID, null);
            this.tbCategoryID.Size = new System.Drawing.Size(200, 21);
            this.tbCategoryID.TabIndex = 5;
            // 
            // lbSpec
            // 
            this.inputControlEnter1.SetFocus(this.lbSpec, false);
            this.lbSpec.Location = new System.Drawing.Point(25, 120);
            this.lbSpec.Name = "lbSpec";
            this.lbSpec.Size = new System.Drawing.Size(80, 20);
            this.lbSpec.TabIndex = 6;
            this.lbSpec.Text = "规格：";
            this.lbSpec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSpec
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbSpec, false);
            this.inputControlEnter1.SetFocus(this.tbSpec, true);
            this.tbSpec.Location = new System.Drawing.Point(110, 120);
            this.textBoxAutoComplete1.SetMetadataID(this.tbSpec, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbSpec.Name = "tbSpec";
            this.textBoxAutoComplete1.SetNextControl(this.tbSpec, null);
            this.tbSpec.Size = new System.Drawing.Size(200, 21);
            this.tbSpec.TabIndex = 7;
            // 
            // lbUnit
            // 
            this.inputControlEnter1.SetFocus(this.lbUnit, false);
            this.lbUnit.Location = new System.Drawing.Point(25, 150);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(80, 20);
            this.lbUnit.TabIndex = 8;
            this.lbUnit.Text = "单位：";
            this.lbUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUnit
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbUnit, false);
            this.inputControlEnter1.SetFocus(this.tbUnit, true);
            this.tbUnit.Location = new System.Drawing.Point(110, 150);
            this.textBoxAutoComplete1.SetMetadataID(this.tbUnit, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbUnit.Name = "tbUnit";
            this.textBoxAutoComplete1.SetNextControl(this.tbUnit, null);
            this.tbUnit.Size = new System.Drawing.Size(200, 21);
            this.tbUnit.TabIndex = 9;
            // 
            // lbUnitPrice
            // 
            this.inputControlEnter1.SetFocus(this.lbUnitPrice, false);
            this.lbUnitPrice.Location = new System.Drawing.Point(25, 180);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(80, 20);
            this.lbUnitPrice.TabIndex = 10;
            this.lbUnitPrice.Text = "价格：";
            this.lbUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUnitPrice
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbUnitPrice, false);
            this.inputControlEnter1.SetFocus(this.tbUnitPrice, true);
            this.tbUnitPrice.Location = new System.Drawing.Point(110, 180);
            this.textBoxAutoComplete1.SetMetadataID(this.tbUnitPrice, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.textBoxAutoComplete1.SetNextControl(this.tbUnitPrice, null);
            this.tbUnitPrice.Size = new System.Drawing.Size(200, 21);
            this.tbUnitPrice.TabIndex = 11;
            // 
            // lbInputCode
            // 
            this.inputControlEnter1.SetFocus(this.lbInputCode, false);
            this.lbInputCode.Location = new System.Drawing.Point(25, 210);
            this.lbInputCode.Name = "lbInputCode";
            this.lbInputCode.Size = new System.Drawing.Size(80, 20);
            this.lbInputCode.TabIndex = 12;
            this.lbInputCode.Text = "输入码：";
            this.lbInputCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbInputCode
            // 
            this.textBoxAutoComplete1.SetAutoDropDown(this.tbInputCode, false);
            this.inputControlEnter1.SetFocus(this.tbInputCode, true);
            this.tbInputCode.Location = new System.Drawing.Point(110, 210);
            this.textBoxAutoComplete1.SetMetadataID(this.tbInputCode, new System.Guid("00000000-0000-0000-0000-000000000000"));
            this.tbInputCode.Name = "tbInputCode";
            this.textBoxAutoComplete1.SetNextControl(this.tbInputCode, null);
            this.tbInputCode.Size = new System.Drawing.Size(200, 21);
            this.tbInputCode.TabIndex = 13;
            // 
            // btnSave
            // 
            this.inputControlEnter1.SetFocus(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(110, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.inputControlEnter1.SetFocus(this.btnClose, true);
            this.btnClose.Location = new System.Drawing.Point(267, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // 
            // ProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.tbCategoryID);
            this.Controls.Add(this.lbSpec);
            this.Controls.Add(this.tbSpec);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.lbInputCode);
            this.Controls.Add(this.tbInputCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "ProductEditor";
            this.Text = "产品字典";
            this.ResumeLayout(false);
            this.PerformLayout();

    } 
    
    #endregion 
    
    private System.Windows.Forms.Label lbProductID; 
    private System.Windows.Forms.TextBox tbProductID; 
    private System.Windows.Forms.Label lbProductName; 
    private System.Windows.Forms.TextBox tbProductName; 
    private System.Windows.Forms.Label lbCategoryID; 
    private System.Windows.Forms.TextBox tbCategoryID; 
    private System.Windows.Forms.Label lbSpec; 
    private System.Windows.Forms.TextBox tbSpec; 
    private System.Windows.Forms.Label lbUnit; 
    private System.Windows.Forms.TextBox tbUnit; 
    private System.Windows.Forms.Label lbUnitPrice; 
    private System.Windows.Forms.TextBox tbUnitPrice; 
    private System.Windows.Forms.Label lbInputCode;
    private System.Windows.Forms.TextBox tbInputCode; 
    private System.Windows.Forms.Button btnSave; 
    private System.Windows.Forms.Button btnClose;
    private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;
    private EAS.Windows.UI.Controls.TextBoxAutoComplete textBoxAutoComplete1; 
  } 
}
