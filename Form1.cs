﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections.ObjectModel;

// Rhys Withey, 30015888
// 18/10/2022
// AT1. Wiki Application

namespace ComputerScienceWikiApplication
{
    #region Initialization
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Initialize items here
        // Esablish arary
        ArrayList Main = new ArrayList();
        static int row = 12;
        static int column = 4;
        int arrLen = 0;
        string[,] wikiArray = new string[row, column];

        // Add items to the ListView
        // Display items ListBox       
        private void DisplayArray()
        {
            try
            {
                for (int i = 0; i < row; i++)
                {
                    if (wikiArray[i, 0] != null)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = wikiArray[i, 0];
                        item.SubItems.Add(wikiArray[i, 1]);
                        item.SubItems.Add(wikiArray[i, 2]);
                        item.SubItems.Add(wikiArray[i, 3]);
                        wikiBox.Items.Add(item);
                        continue;
                    }
                    break;
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Error adding item to list";
            }
        }

        // Clear items functions - List and textbox
        private void ClearItems()
        {
            wikiBox.Items.Clear();
            dataBox.Clear();
            catBox.Clear();
            structureBox.Clear();
            defBox.Clear();
        }

        // Add the items from the text box to the array
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

        // Bubble sort items from A-Z
        // Use Compair function
        private void BubbleSort()
        {

        }

        // Add items to array and ListBox
        private void AddButton_Click(object sender, EventArgs e)
        {
            ArrayAdd();
            ClearItems();
            DisplayArray();
        }
        #endregion

        // Delete all selected items in the listbox only using delte key
        private void wikiBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    listViewItem.Remove();
                }
            }
        }

        //Clearing the 4 text boxes on left hand side
        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataBox.Clear();
            catBox.Clear();
            structureBox.Clear();
            defBox.Clear();
        }

        // Delete items drow listbox and array
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = wikiBox.SelectedIndices[0];
            DialogResult result = MessageBox.Show("Would you like to delete selected item?", "Delete Item", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                wikiBox.Items.RemoveAt(index);
                for (int i = 0; i < wikiArray.Length; i++)
                {
                    wikiArray[index, 0] = "";
                    wikiArray[index, 1] = "";
                    wikiArray[index, 2] = "";
                    wikiArray[index, 3] = "";
                    continue;
                }
            }
            else
            {

            }
            ClearItems();
            DisplayArray();
        }

        // Edit button that edits the array and ListBox
        private void button3_Click(object sender, EventArgs e)
        {
            int index = wikiBox.SelectedIndices[0];
            for (int i = 0; i < wikiArray.Length; i++)
            {
                wikiArray[index, 0] = dataBox.Text;
                wikiArray[index, 1] = catBox.Text;
                wikiArray[index, 2] = structureBox.Text;
                wikiArray[index, 3] = defBox.Text;
                break;
            }
            ClearItems();
            DisplayArray();
        }
        
        // Load button
        private void button6_Click(object sender, EventArgs e)
        {
            BubbleSort();
            DisplayArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Sort first
        }
    }
}
