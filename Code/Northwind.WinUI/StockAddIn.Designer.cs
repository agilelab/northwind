namespace Northwind.WinUI
{
    partial class StockAddIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gDisplayViewer1 = new EAS.GReport.Controls.GDisplayViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.tbKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(253, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(86, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(76, 15);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(160, 23);
            this.tbKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "检索：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gDisplayViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 400);
            this.panel2.TabIndex = 2;
            // 
            // gDisplayViewer1
            // 
            this.gDisplayViewer1.BackColor = System.Drawing.SystemColors.Control;
            this.gDisplayViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDisplayViewer1.Location = new System.Drawing.Point(0, 0);
            this.gDisplayViewer1.Name = "gDisplayViewer1";
            this.gDisplayViewer1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gDisplayViewer1.ShowClose = false;
            this.gDisplayViewer1.ShowFooter = true;
            this.gDisplayViewer1.ShowHeader = true;
            this.gDisplayViewer1.ShowLoad = false;
            this.gDisplayViewer1.Size = new System.Drawing.Size(1042, 400);
            this.gDisplayViewer1.TabIndex = 0;
            // 
            // StockAddIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "StockAddIn";
            this.Size = new System.Drawing.Size(1042, 454);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private EAS.GReport.Controls.GDisplayViewer gDisplayViewer1;
    }
}
