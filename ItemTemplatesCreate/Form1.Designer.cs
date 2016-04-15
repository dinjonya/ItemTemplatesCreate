namespace ItemTemplatesCreate
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkAuther = new System.Windows.Forms.CheckBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.chkDesc = new System.Windows.Forms.CheckBox();
            this.txtAuther = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtItemtemplatesPath = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(520, 348);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkAuther
            // 
            this.chkAuther.AutoSize = true;
            this.chkAuther.Location = new System.Drawing.Point(27, 14);
            this.chkAuther.Name = "chkAuther";
            this.chkAuther.Size = new System.Drawing.Size(48, 16);
            this.chkAuther.TabIndex = 1;
            this.chkAuther.Text = "作者";
            this.chkAuther.UseVisualStyleBackColor = true;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Location = new System.Drawing.Point(325, 14);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(48, 16);
            this.chkCompany.TabIndex = 1;
            this.chkCompany.Text = "公司";
            this.chkCompany.UseVisualStyleBackColor = true;
            // 
            // chkDesc
            // 
            this.chkDesc.AutoSize = true;
            this.chkDesc.Location = new System.Drawing.Point(27, 48);
            this.chkDesc.Name = "chkDesc";
            this.chkDesc.Size = new System.Drawing.Size(48, 16);
            this.chkDesc.TabIndex = 1;
            this.chkDesc.Text = "说明";
            this.chkDesc.UseVisualStyleBackColor = true;
            // 
            // txtAuther
            // 
            this.txtAuther.Location = new System.Drawing.Point(81, 12);
            this.txtAuther.Name = "txtAuther";
            this.txtAuther.Size = new System.Drawing.Size(216, 21);
            this.txtAuther.TabIndex = 2;
            this.txtAuther.Text = "Odin";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(379, 12);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(216, 21);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.Text = "Odin";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(81, 46);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(514, 21);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.Text = "本代码版权归Odin所有，使用时必须带上Odin的网址(http://www.imvc.me),切注释不得删除";
            // 
            // txtItemtemplatesPath
            // 
            this.txtItemtemplatesPath.Location = new System.Drawing.Point(81, 82);
            this.txtItemtemplatesPath.Name = "txtItemtemplatesPath";
            this.txtItemtemplatesPath.Size = new System.Drawing.Size(223, 21);
            this.txtItemtemplatesPath.TabIndex = 2;
            this.txtItemtemplatesPath.Text = "C:\\Users\\3c-dinjonya\\Desktop\\CSharp";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(27, 123);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(568, 219);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "模版路径";
            // 
            // txtOutpath
            // 
            this.txtOutpath.Location = new System.Drawing.Point(372, 82);
            this.txtOutpath.Name = "txtOutpath";
            this.txtOutpath.Size = new System.Drawing.Size(223, 21);
            this.txtOutpath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输出路径";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtOutpath);
            this.Controls.Add(this.txtItemtemplatesPath);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtAuther);
            this.Controls.Add(this.chkDesc);
            this.Controls.Add(this.chkCompany);
            this.Controls.Add(this.chkAuther);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "模版生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkAuther;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.CheckBox chkDesc;
        private System.Windows.Forms.TextBox txtAuther;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtItemtemplatesPath;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutpath;
        private System.Windows.Forms.Label label2;
    }
}

