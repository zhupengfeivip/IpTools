
namespace IpTools
{
    partial class FrmMain
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
            this.btnGetInternetIp = new System.Windows.Forms.Button();
            this.txtInternetIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetInternetIp
            // 
            this.btnGetInternetIp.Location = new System.Drawing.Point(38, 21);
            this.btnGetInternetIp.Name = "btnGetInternetIp";
            this.btnGetInternetIp.Size = new System.Drawing.Size(102, 23);
            this.btnGetInternetIp.TabIndex = 0;
            this.btnGetInternetIp.Text = "获取外网IP";
            this.btnGetInternetIp.UseVisualStyleBackColor = true;
            this.btnGetInternetIp.Click += new System.EventHandler(this.btnGetInternetIp_Click);
            // 
            // txtInternetIp
            // 
            this.txtInternetIp.Location = new System.Drawing.Point(89, 57);
            this.txtInternetIp.Name = "txtInternetIp";
            this.txtInternetIp.Size = new System.Drawing.Size(120, 21);
            this.txtInternetIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "外网IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "国家:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(89, 84);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(120, 21);
            this.txtCountry.TabIndex = 4;
            // 
            // rtbxLog
            // 
            this.rtbxLog.Location = new System.Drawing.Point(29, 133);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(325, 60);
            this.rtbxLog.TabIndex = 6;
            this.rtbxLog.Text = "有其他需要增加的功能，请在博客联系我https://blog.csdn.net/zhupengfei";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 209);
            this.Controls.Add(this.rtbxLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInternetIp);
            this.Controls.Add(this.btnGetInternetIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.Text = "IP管理工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInternetIp;
        private System.Windows.Forms.TextBox txtInternetIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.RichTextBox rtbxLog;
    }
}

