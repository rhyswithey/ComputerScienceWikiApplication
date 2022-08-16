using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComputerScienceWikiApplication
{
    #region Initialization
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int row = 12;
        static int collum = 4;
        int arrLen = 0;
        string[,] wikiArray = new string[row, collum];

        private void DisplayArray()
        {
            wikiBox.Items.Clear();
            string str = "";
            for (int x = 0; x < row; x++)
            {
                str = wikiArray[x, 0] + "\t |" + wikiArray[x, 1] + "\t |" + wikiArray[x, 2] + "\t |" + wikiArray[x, 3];
                wikiBox.Items.Add(str);
            }
        }
        private void ArrayAdd()
        {
            if (row > arrLen)
            {
                try
                {
                    wikiArray[arrLen, 0] = dataBox.Text;
                    wikiArray[arrLen, 1] = catBox.Text;
                    wikiArray[arrLen, 2] = structureBox.Text;
                    wikiArray[arrLen, 3] = defBox.Text;
                    arrLen++;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                statusStrip1.Text = "Wiki Array list is full!!";
            }            
        }
        
        #endregion
        private void AddButton_Click(object sender, EventArgs e)
        {
            ArrayAdd();
            dataBox.Clear();
            catBox.Clear();
            structureBox.Clear();
            defBox.Clear();            
            DisplayArray();
        }
    }
}
