using System;
using System.Collections;
using System.Windows.Forms;


namespace ComputerScienceWikiApplication
{
    #region Initialization
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            

        }

        ArrayList Main = new ArrayList();
        static int row = 12;
        static int column = 4;        
        int arrLen = 0;
        string[,] wikiArray = new string[row, column];

        private void DisplayArray()
        {               
            for (int i = 0; i < row; i++)
            {
                foreach (string s in wikiArray)
                {                    
                    if (wikiBox.ToString().Contains(wikiArray[i, 0]))
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = wikiArray[i, 0];
                        item.SubItems.Add(wikiArray[i, 1]);
                        item.SubItems.Add(wikiArray[i, 2]);
                        item.SubItems.Add(wikiArray[i, 3]);
                        wikiBox.Items.Add(item);
                        break;
                    }
                    else
                    {
                        statusStrip1.Text = "Duplicate Item";
                    }
                    
                }
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
