﻿namespace ExcelImproter
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aI编辑器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aI编辑器ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aI编辑器设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(963, 514);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aI编辑器ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aI编辑器ToolStripMenuItem
            // 
            this.aI编辑器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aI编辑器ToolStripMenuItem1,
            this.aI编辑器设置ToolStripMenuItem});
            this.aI编辑器ToolStripMenuItem.Name = "aI编辑器ToolStripMenuItem";
            this.aI编辑器ToolStripMenuItem.Size = new System.Drawing.Size(32, 21);
            this.aI编辑器ToolStripMenuItem.Text = "AI";
            // 
            // aI编辑器ToolStripMenuItem1
            // 
            this.aI编辑器ToolStripMenuItem1.Name = "aI编辑器ToolStripMenuItem1";
            this.aI编辑器ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aI编辑器ToolStripMenuItem1.Text = "AI编辑器";
            this.aI编辑器ToolStripMenuItem1.Click += new System.EventHandler(this.aI编辑器ToolStripMenuItem1_Click);
            // 
            // aI编辑器设置ToolStripMenuItem
            // 
            this.aI编辑器设置ToolStripMenuItem.Name = "aI编辑器设置ToolStripMenuItem";
            this.aI编辑器设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aI编辑器设置ToolStripMenuItem.Text = "AI编辑器设置";
            this.aI编辑器设置ToolStripMenuItem.Click += new System.EventHandler(this.aI编辑器设置ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 596);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aI编辑器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aI编辑器ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aI编辑器设置ToolStripMenuItem;
    }
}

