namespace Northwind.WinUI 
{ 
  partial class EmployeeEditor 
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

       this.lbEmployeeID = new System.Windows.Forms.Label();  
       this.tbEmployeeID = new System.Windows.Forms.TextBox();  
       this.lbName = new System.Windows.Forms.Label();  
       this.tbName = new System.Windows.Forms.TextBox();  
       this.lbTitle = new System.Windows.Forms.Label();  
       this.tbTitle = new System.Windows.Forms.TextBox();  
       this.lbBirthDate = new System.Windows.Forms.Label();  
       this.tbBirthDate = new System.Windows.Forms.TextBox();  
       this.lbHireDate = new System.Windows.Forms.Label();  
       this.tbHireDate = new System.Windows.Forms.TextBox();  
       this.lbAddress = new System.Windows.Forms.Label();  
       this.tbAddress = new System.Windows.Forms.TextBox();  
       this.lbMail = new System.Windows.Forms.Label();  
       this.tbMail = new System.Windows.Forms.TextBox();  
       this.lbPhone = new System.Windows.Forms.Label();  
       this.tbPhone = new System.Windows.Forms.TextBox();  
       this.lbLMTime = new System.Windows.Forms.Label();  
       this.tbLMTime = new System.Windows.Forms.TextBox();  
       this.btnSave = new System.Windows.Forms.Button();  
       this.btnClose = new System.Windows.Forms.Button();  
      this.SuspendLayout(); 
       //  
       // Controls  
       //   
       //  
       // Label  
       //   
       this.lbEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbEmployeeID.Text = "员工ID：";  
       this.lbEmployeeID.Location=new System.Drawing.Point(25, 30); 
       this.lbEmployeeID.Name = "lbEmployeeID";  
       this.lbEmployeeID.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 0; 
       //  
       // TextBox  
       //   
       this.tbEmployeeID.Location=new System.Drawing.Point(110, 30); 
       this.tbEmployeeID.Name = "tbEmployeeID";  
       this.tbEmployeeID.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 1; 
       //  
       // Label  
       //   
       this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbName.Text = "姓名：";  
       this.lbName.Location=new System.Drawing.Point(25, 60); 
       this.lbName.Name = "lbName";  
       this.lbName.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 2; 
       //  
       // TextBox  
       //   
       this.tbName.Location=new System.Drawing.Point(110, 60); 
       this.tbName.Name = "tbName";  
       this.tbName.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 3; 
       //  
       // Label  
       //   
       this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbTitle.Text = "头衔：";  
       this.lbTitle.Location=new System.Drawing.Point(25, 90); 
       this.lbTitle.Name = "lbTitle";  
       this.lbTitle.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 4; 
       //  
       // TextBox  
       //   
       this.tbTitle.Location=new System.Drawing.Point(110, 90); 
       this.tbTitle.Name = "tbTitle";  
       this.tbTitle.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 5; 
       //  
       // Label  
       //   
       this.lbBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbBirthDate.Text = "生日：";  
       this.lbBirthDate.Location=new System.Drawing.Point(25, 120); 
       this.lbBirthDate.Name = "lbBirthDate";  
       this.lbBirthDate.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 6; 
       //  
       // TextBox  
       //   
       this.tbBirthDate.Location=new System.Drawing.Point(110, 120); 
       this.tbBirthDate.Name = "tbBirthDate";  
       this.tbBirthDate.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 7; 
       //  
       // Label  
       //   
       this.lbHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbHireDate.Text = "雇佣日期：";  
       this.lbHireDate.Location=new System.Drawing.Point(25, 150); 
       this.lbHireDate.Name = "lbHireDate";  
       this.lbHireDate.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 8; 
       //  
       // TextBox  
       //   
       this.tbHireDate.Location=new System.Drawing.Point(110, 150); 
       this.tbHireDate.Name = "tbHireDate";  
       this.tbHireDate.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 9; 
       //  
       // Label  
       //   
       this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbAddress.Text = "地址：";  
       this.lbAddress.Location=new System.Drawing.Point(25, 180); 
       this.lbAddress.Name = "lbAddress";  
       this.lbAddress.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 10; 
       //  
       // TextBox  
       //   
       this.tbAddress.Location=new System.Drawing.Point(110, 180); 
       this.tbAddress.Name = "tbAddress";  
       this.tbAddress.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 11; 
       //  
       // Label  
       //   
       this.lbMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbMail.Text = "邮件：";  
       this.lbMail.Location=new System.Drawing.Point(25, 210); 
       this.lbMail.Name = "lbMail";  
       this.lbMail.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 12; 
       //  
       // TextBox  
       //   
       this.tbMail.Location=new System.Drawing.Point(110, 210); 
       this.tbMail.Name = "tbMail";  
       this.tbMail.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 13; 
       //  
       // Label  
       //   
       this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbPhone.Text = "电话：";  
       this.lbPhone.Location=new System.Drawing.Point(25, 240); 
       this.lbPhone.Name = "lbPhone";  
       this.lbPhone.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 14; 
       //  
       // TextBox  
       //   
       this.tbPhone.Location=new System.Drawing.Point(110, 240); 
       this.tbPhone.Name = "tbPhone";  
       this.tbPhone.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 15; 
       //  
       // Label  
       //   
       this.lbLMTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbLMTime.Text = "最后更新时间：";  
       this.lbLMTime.Location=new System.Drawing.Point(25, 270); 
       this.lbLMTime.Name = "lbLMTime";  
       this.lbLMTime.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 16; 
       //  
       // TextBox  
       //   
       this.tbLMTime.Location=new System.Drawing.Point(110, 270); 
       this.tbLMTime.Name = "tbLMTime";  
       this.tbLMTime.Size = new System.Drawing.Size(200, 23); 
       this.TabIndex = 17; 
       //  
       // Button  
       //   
       this.btnSave.Text = "保存(&S)";  
       this.btnSave.UseVisualStyleBackColor = true; 
       this.btnSave.Location=new System.Drawing.Point(96, 324); 
       this.btnSave.Name = "btnSave";  
       this.btnSave.Size = new System.Drawing.Size(85, 30); 
       this.TabIndex = 18; 
       this.btnSave.Click+=new System.EventHandler(this.btnSave_Click);
       //  
       // Button  
       //   
       this.btnClose.Text = "关闭(&C)";  
       this.btnClose.UseVisualStyleBackColor = true; 
       this.btnClose.Location=new System.Drawing.Point(242, 324); 
       this.btnClose.Name = "btnClose";  
       this.btnClose.Size = new System.Drawing.Size(85, 30); 
       this.TabIndex = 19; 
       this.btnClose.Click+=new System.EventHandler(this.btnClose_Click);
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F); 
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;  
      this.Controls.Add(this.lbEmployeeID);  
      this.Controls.Add(this.tbEmployeeID);  
      this.Controls.Add(this.lbName);  
      this.Controls.Add(this.tbName);  
      this.Controls.Add(this.lbTitle);  
      this.Controls.Add(this.tbTitle);  
      this.Controls.Add(this.lbBirthDate);  
      this.Controls.Add(this.tbBirthDate);  
      this.Controls.Add(this.lbHireDate);  
      this.Controls.Add(this.tbHireDate);  
      this.Controls.Add(this.lbAddress);  
      this.Controls.Add(this.tbAddress);  
      this.Controls.Add(this.lbMail);  
      this.Controls.Add(this.tbMail);  
      this.Controls.Add(this.lbPhone);  
      this.Controls.Add(this.tbPhone);  
      this.Controls.Add(this.lbLMTime);  
      this.Controls.Add(this.tbLMTime);  
      this.Controls.Add(this.btnSave);  
      this.Controls.Add(this.btnClose);  
            this.ClientSize = new System.Drawing.Size(394, 381); 
            this.Text = "员工"; 
            this.Name = "EmployeeEditor"; 
      this.ResumeLayout(false); 
    } 
    
    #endregion 
    
    private System.Windows.Forms.Label lbEmployeeID; 
    private System.Windows.Forms.TextBox tbEmployeeID; 
    private System.Windows.Forms.Label lbName; 
    private System.Windows.Forms.TextBox tbName; 
    private System.Windows.Forms.Label lbTitle; 
    private System.Windows.Forms.TextBox tbTitle; 
    private System.Windows.Forms.Label lbBirthDate; 
    private System.Windows.Forms.TextBox tbBirthDate; 
    private System.Windows.Forms.Label lbHireDate; 
    private System.Windows.Forms.TextBox tbHireDate; 
    private System.Windows.Forms.Label lbAddress; 
    private System.Windows.Forms.TextBox tbAddress; 
    private System.Windows.Forms.Label lbMail; 
    private System.Windows.Forms.TextBox tbMail; 
    private System.Windows.Forms.Label lbPhone; 
    private System.Windows.Forms.TextBox tbPhone; 
    private System.Windows.Forms.Label lbLMTime; 
    private System.Windows.Forms.TextBox tbLMTime; 
    private System.Windows.Forms.Button btnSave; 
    private System.Windows.Forms.Button btnClose; 
  } 
}
