namespace TestNLog
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
            this.Tex01 = new System.Windows.Forms.TextBox();
            this.But01 = new System.Windows.Forms.Button();
            this.But02 = new System.Windows.Forms.Button();
            this.Tex03 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tex02 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tex01
            // 
            this.Tex01.Location = new System.Drawing.Point(132, 37);
            this.Tex01.Name = "Tex01";
            this.Tex01.Size = new System.Drawing.Size(100, 21);
            this.Tex01.TabIndex = 0;
            this.Tex01.TextChanged += new System.EventHandler(this.Tex01_TextChanged);
            // 
            // But01
            // 
            this.But01.Location = new System.Drawing.Point(303, 34);
            this.But01.Name = "But01";
            this.But01.Size = new System.Drawing.Size(75, 23);
            this.But01.TabIndex = 1;
            this.But01.Text = "纪录信息";
            this.But01.UseVisualStyleBackColor = true;
            this.But01.Click += new System.EventHandler(this.But01_Click);
            // 
            // But02
            // 
            this.But02.Location = new System.Drawing.Point(303, 206);
            this.But02.Name = "But02";
            this.But02.Size = new System.Drawing.Size(75, 23);
            this.But02.TabIndex = 3;
            this.But02.Text = "纪录错误";
            this.But02.UseVisualStyleBackColor = true;
            this.But02.Click += new System.EventHandler(this.But02_Click);
            // 
            // Tex03
            // 
            this.Tex03.Location = new System.Drawing.Point(132, 209);
            this.Tex03.Name = "Tex03";
            this.Tex03.Size = new System.Drawing.Size(100, 21);
            this.Tex03.TabIndex = 2;
            this.Tex03.TextChanged += new System.EventHandler(this.Tex02_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "纪录Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tex02
            // 
            this.Tex02.Location = new System.Drawing.Point(132, 125);
            this.Tex02.Name = "Tex02";
            this.Tex02.Size = new System.Drawing.Size(100, 21);
            this.Tex02.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tex02);
            this.Controls.Add(this.But02);
            this.Controls.Add(this.Tex03);
            this.Controls.Add(this.But01);
            this.Controls.Add(this.Tex01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tex01;
        private System.Windows.Forms.Button But01;
        private System.Windows.Forms.Button But02;
        private System.Windows.Forms.TextBox Tex03;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tex02;
    }
}

