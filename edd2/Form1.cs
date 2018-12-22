using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edd2
{
    public partial class Form1 : Form
    {


        string recorrido = "";
        int tt = 0;
        int x = 1;
        int ConG = 0;
        int C1 = 0;
        int A1 = 0;
        int G1 = 2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            C1 = 0;

            int GenTT = Convert.ToInt32(textBox1.Text);
            treeView1.Nodes.Add("Jesus Mendez");
            button3.Visible = false;
           

            C1++;
            if (GenTT > 0 && GenTT < 11)
            {
                Genod(treeView1.Nodes[0], A1, GenTT);
            }
            else
            {
                MessageBox.Show("no cumple con los requisitos");
            }

            textBox3.Text = C1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            {
                MessageBox.Show("" + treeView1.SelectedNode.Text);
                comboBox1.Text = treeView1.SelectedNode.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CalCG = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < CalCG; i++)
            {
                tt = x * 2;
                x = x * 2;
                ConG = ConG + tt;
            }
            textBox2.Text = ConG.ToString();
        }

        public void Genod(TreeNode node, int A11, int GenT)
        {
            C1++;
            A11++;

            node.Nodes.Add("Padre " + G1.ToString());
            comboBox1.Items.Add("Padre" + G1.ToString());
            recorrido += node.Text + ",";
            G1++;
            if (A11 < GenT)
            {
                Genod(node.Nodes[0], A11, GenT);
            }

            node.Nodes.Add("Madre " + G1.ToString());
            comboBox1.Items.Add("Padre " + G1.ToString());
            recorrido += node.Text + ",";
            G1++;
            if (A11 < GenT)
            {
                Genod(node.Nodes[1], A11, GenT);
            }

            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(textBox4.Text);
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string hijo;
                hijo = textBox5.Text;
                treeView1.SelectedNode.Nodes.Add(hijo);
                treeView1.ExpandAll();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(recorrido);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
