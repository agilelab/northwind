namespace Northwind.WinUI 
{ 
  partial class CustomerEditor 
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

       this.lbCustomerID = new System.Windows.Forms.Label();  
       this.tbCustomerID = new System.Windows.Forms.TextBox();  
       this.lbName = new System.Windows.Forms.Label();  
       this.tbName = new System.Windows.Forms.TextBox();  
       this.lbAddress = new System.Windows.Forms.Label();  
       this.tbAddress = new System.Windows.Forms.TextBox();  
       this.lbMail = new System.Windows.Forms.Label();  
       this.tbMail = new System.Windows.Forms.TextBox();  
       this.lbPhone = new System.Windows.Forms.Label();  
       this.tbPhone = new System.Windows.Forms.TextBox();  
       this.lbFax = new System.Windows.Forms.Label();  
       this.tbFax = new System.Windows.Forms.TextBox();  
       this.btnSave = new System.Windows.Forms.Button();  
       this.btnClose = new System.Windows.Forms.Button();  
      this.SuspendLayout(); 
       //  
       // Controls  
       //   
       //  
       // Label  
       //   
       this.lbCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbCustomerID.Text = "CustomerID：";  
       this.lbCustomerID.Location=new System.Drawing.Point(25, 30); 
       this.lbCustomerID.Name = "lbCustomerID";  
       this.lbCustomerID.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 0; 
       //  
       // TextBox  
       //   
       this.tbCustomerID.Location=new System.Drawing.Point(110, 30); 
       this.tbCustomerID.Name = "tbCustomerID";  
       this.tbCustomerID.Size = new System.Drawing.Size(200, 21); 
       this.TabIndex = 1; 
       //  
       // Label  
       //   
       this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbName.Text = "Name：";  
       this.lbName.Location=new System.Drawing.Point(25, 60); 
       this.lbName.Name = "lbName";  
       this.lbName.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 2; 
       //  
       // TextBox  
       //   
       this.tbName.Location=new System.Drawing.Point(110, 60); 
       this.tbName.Name = "tbName";  
       this.tbName.Size = new System.Drawing.Size(200, 21); 
       this.TabIndex = 3; 
       //  
       // Label  
       //   
       this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbAddress.Text = "地址：";  
       this.lbAddress.Location=new System.Drawing.Point(25, 90); 
       this.lbAddress.Name = "lbAddress";  
       this.lbAddress.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 4; 
       //  
       // TextBox  
       //   
       this.tbAddress.Location=new System.Drawing.Point(110, 90); 
       this.tbAddress.Name = "tbAddress";  
       this.tbAddress.Size = new System.Drawing.Size(200, 21); 
       this.TabIndex = 5; 
       //  
       // Label  
       //   
       this.lbMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbMail.Text = "邮件：";  
       this.lbMail.Location=new System.Drawing.Point(25, 120); 
       this.lbMail.Name = "lbMail";  
       this.lbMail.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 6; 
       //  
       // TextBox  
       //   
       this.tbMail.Location=new System.Drawing.Point(110, 120); 
       this.tbMail.Name = "tbMail";  
       this.tbMail.Size = new System.Drawing.Size(200, 21); 
       this.TabIndex = 7; 
       //  
       // Label  
       //   
       this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbPhone.Text = "电话：";  
       this.lbPhone.Location=new System.Drawing.Point(25, 150); 
       this.lbPhone.Name = "lbPhone";  
       this.lbPhone.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 8; 
       //  
       // TextBox  
       //   
       this.tbPhone.Location=new System.Drawing.Point(110, 150); 
       this.tbPhone.Name = "tbPhone";  
       this.tbPhone.Size = new System.Drawing.Size(200, 21); 
       this.TabIndex = 9; 
       //  
       // Label  
       //   
       this.lbFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;  
       this.lbFax.Text = "传真：";  
       this.lbFax.Location=new System.Drawing.Point(25, 180); 
       this.lbFax.Name = "lbFax";  
       this.lbFax.Size = new System.Drawing.Size(80, 20); 
       this.TabIndex = 10; 
       //  
       // TextBox  
       //   
       this.tbFax.Location=new System.Drawing.Point(110, 180); 
       this.tbFax.Name = "tbFax";  
       this.tbFax.Size = new System.Drawing.Size(200, 21); 
       this.TabIndex = 11; 
       //  
       // Button  
       //   
       this.btnSave.Text = "保存(&S)";  
       this.btnSave.UseVisualStyleBackColor = true; 
       this.btnSave.Location=new System.Drawing.Point(135, 230); 
       this.btnSave.Name = "btnSave";  
       this.btnSave.Size = new System.Drawing.Size(85, 30); 
       this.TabIndex = 12; 
       this.btnSave.Click+=new System.EventHandler(this.btnSave_Click);
       //  
       // Button  
       //   
       this.btnClose.Text = "关闭(&C)";  
       this.btnClose.UseVisualStyleBackColor = true; 
       this.btnClose.Location=new System.Drawing.Point(225, 230); 
       this.btnClose.Name = "btnClose";  
       this.btnClose.Size = new System.Drawing.Size(85, 30); 
       this.TabIndex = 13; 
       this.btnClose.Click+=new System.EventHandler(this.btnClose_Click);
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F); 
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;  
      this.Controls.Add(this.lbCustomerID);  
      this.Controls.Add(this.tbCustomerID);  
      this.Controls.Add(this.lbName);  
      this.Controls.Add(this.tbName);  
      this.Controls.Add(this.lbAddress);  
      this.Controls.Add(this.tbAddress);  
      this.Controls.Add(this.lbMail);  
      this.Controls.Add(this.tbMail);  
      this.Controls.Add(this.lbPhone);  
      this.Controls.Add(this.tbPhone);  
      this.Controls.Add(this.lbFax);  
      this.Controls.Add(this.tbFax);  
      this.Controls.Add(this.btnSave);  
      this.Controls.Add(this.btnClose);  
            this.ClientSize = new System.Drawing.Size(394, 291); 
            this.Text = "客户"; 
            this.Name = "CustomerEditor"; 
      this.ResumeLayout(false); 
    } 
    
    #endregion 
    
    private System.Windows.Forms.Label lbCustomerID; 
    private System.Windows.Forms.TextBox tbCustomerID; 
    private System.Windows.Forms.Label lbName; 
    private System.Windows.Forms.TextBox tbName; 
    private System.Windows.Forms.Label lbAddress; 
    private System.Windows.Forms.TextBox tbAddress; 
    private System.Windows.Forms.Label lbMail; 
    private System.Windows.Forms.TextBox tbMail; 
    private System.Windows.Forms.Label lbPhone; 
    private System.Windows.Forms.TextBox tbPhone; 
    private System.Windows.Forms.Label lbFax; 
    private System.Windows.Forms.TextBox tbFax; 
    private System.Windows.Forms.Button btnSave; 
    private System.Windows.Forms.Button btnClose; 
  } 
}
