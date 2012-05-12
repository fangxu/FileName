namespace FileName
{
    partial class FileName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileName));
            this.textBolxPath = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxTop = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBolxPath
            // 
            this.textBolxPath.Enabled = false;
            this.textBolxPath.Location = new System.Drawing.Point(55, 8);
            this.textBolxPath.Name = "textBolxPath";
            this.textBolxPath.Size = new System.Drawing.Size(404, 21);
            this.textBolxPath.TabIndex = 0;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(68, 217);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(391, 21);
            this.textBoxNewName.TabIndex = 8;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(117, 274);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(12, 274);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 10;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Location = new System.Drawing.Point(13, 35);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(446, 176);
            this.listViewFiles.TabIndex = 6;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "NewName:";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(68, 245);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(391, 21);
            this.textBoxReplace.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Replace:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Path:";
            // 
            // checkBoxTop
            // 
            this.checkBoxTop.AutoSize = true;
            this.checkBoxTop.Checked = true;
            this.checkBoxTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTop.Location = new System.Drawing.Point(375, 279);
            this.checkBoxTop.Name = "checkBoxTop";
            this.checkBoxTop.Size = new System.Drawing.Size(84, 16);
            this.checkBoxTop.TabIndex = 13;
            this.checkBoxTop.Text = "Top Always";
            this.checkBoxTop.UseVisualStyleBackColor = true;
            this.checkBoxTop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(222, 274);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FileName
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 307);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkBoxTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.textBolxPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileName";
            this.Text = "FileName";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileName_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileName_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBolxPath;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxTop;
        private System.Windows.Forms.Button buttonExit;
    }
}

