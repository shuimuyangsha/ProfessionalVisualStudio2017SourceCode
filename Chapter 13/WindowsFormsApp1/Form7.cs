using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("C:\\");
            treeView1.Nodes[0].Nodes.Add("Program Data");
            treeView1.Nodes[0].Nodes.Add("Program Files");
            treeView1.Nodes[0].Nodes.Add("Users");
            treeView1.Nodes[0].Nodes.Add("Windows");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Grandchild");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("Grandchild");
            treeView1.Nodes[0].Nodes[3].Nodes.Add("Grandchild");
            treeView1.Nodes.Add("D:\\");
            treeView1.Nodes[1].Nodes.Add("Program Data");
            treeView1.Nodes.Add("E:\\");
            treeView1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
