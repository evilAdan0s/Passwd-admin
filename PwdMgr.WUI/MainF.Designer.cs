namespace PwdMgr.WUI
{
    partial class MainF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.密码管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增帐号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLTags = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRef = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码管理ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 密码管理ToolStripMenuItem
            // 
            this.密码管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码生成ToolStripMenuItem,
            this.新增帐号ToolStripMenuItem});
            this.密码管理ToolStripMenuItem.Name = "密码管理ToolStripMenuItem";
            this.密码管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.密码管理ToolStripMenuItem.Text = "密码管理";
            // 
            // 密码生成ToolStripMenuItem
            // 
            this.密码生成ToolStripMenuItem.Name = "密码生成ToolStripMenuItem";
            this.密码生成ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.密码生成ToolStripMenuItem.Text = "密码生成";
            this.密码生成ToolStripMenuItem.Click += new System.EventHandler(this.密码生成ToolStripMenuItem_Click);
            // 
            // 新增帐号ToolStripMenuItem
            // 
            this.新增帐号ToolStripMenuItem.Name = "新增帐号ToolStripMenuItem";
            this.新增帐号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增帐号ToolStripMenuItem.Text = "新增帐号";
            this.新增帐号ToolStripMenuItem.Click += new System.EventHandler(this.新增帐号ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(20, 26);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(714, 241);
            this.dgvData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "标签：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRef);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSelect2);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbLTags);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询栏";
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(654, 40);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(69, 21);
            this.btnSelect2.TabIndex = 8;
            this.btnSelect2.Text = "查询数据";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(201, 41);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(169, 21);
            this.txtRemark.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "简述";
            // 
            // cbLTags
            // 
            this.cbLTags.FormattingEnabled = true;
            this.cbLTags.Location = new System.Drawing.Point(53, 41);
            this.cbLTags.Name = "cbLTags";
            this.cbLTags.Size = new System.Drawing.Size(120, 68);
            this.cbLTags.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(23, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 289);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据栏";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(201, 84);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(169, 21);
            this.txtAccount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "帐号名称";
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(654, 83);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(69, 21);
            this.btnRef.TabIndex = 11;
            this.btnRef.Text = "刷新数据";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainF";
            this.Load += new System.EventHandler(this.MainF_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 密码管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增帐号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox cbLTags;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRef;
    }
}