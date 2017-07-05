using System;
using System.Windows.Forms;
using ExcelImproter.Framework.BehaviourTree.Editor;
using ExcelImproter.Framework.BehaviourTree.Editor.View;

namespace ExcelImproter
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {           
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string log = LogQueue.Instance.Dequeue();
            if (log == null)
            {
                return;
            }
            this.richTextBox1.AppendText(log);
            this.richTextBox1.Focus();
            this.richTextBox1.Select(this.richTextBox1.Text.Length, 0);
            this.richTextBox1.ScrollToCaret();
        }
        private void aI编辑器ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCollection coll = Application.OpenForms;
            foreach (Form form in coll)
            {
                if (form is AIEditorForm)
                {
                    form.Focus();
                    return;
                }
            }
            AIEditorForm aiForm = new AIEditorForm();
            aiForm.Show();
        }
        private void aI编辑器设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection coll = Application.OpenForms;
            foreach (Form form in coll)
            {
                if (form is AINodeTypeEditor)
                {
                    form.Focus();
                    return;
                }
            }
            AINodeTypeEditor aiForm = new AINodeTypeEditor();
            aiForm.Show();
        }
    }
}
