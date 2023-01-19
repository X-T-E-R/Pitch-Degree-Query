
namespace key
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.cboKey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstNotes
            // 
            this.lstNotes.Font = new System.Drawing.Font("等线", 13.875F);
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.ItemHeight = 39;
            this.lstNotes.Location = new System.Drawing.Point(52, 127);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(508, 667);
            this.lstNotes.TabIndex = 0;
            // 
            // cboKey
            // 
            this.cboKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboKey.Font = new System.Drawing.Font("等线", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboKey.FormattingEnabled = true;
            this.cboKey.Location = new System.Drawing.Point(52, 43);
            this.cboKey.Name = "cboKey";
            this.cboKey.Size = new System.Drawing.Size(508, 47);
            this.cboKey.TabIndex = 1;
            this.cboKey.SelectedValueChanged += new System.EventHandler(this.cboKey_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 896);
            this.Controls.Add(this.cboKey);
            this.Controls.Add(this.lstNotes);
            this.Name = "Form1";
            this.Text = "大调音名-级数查询器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.ComboBox cboKey;
    }
}

