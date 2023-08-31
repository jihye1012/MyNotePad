using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt";
            openFileDialog1.ShowDialog(this);
            textBox1.Text=File.ReadAllText(openFileDialog1.FileName);
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            saveFileDialog1.ShowDialog(this);
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작자 : 양지혜\n제작일 : 2023.08.31 목 ",
                "메모장 정보", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
