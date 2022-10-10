namespace ComputerScienceWikiApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.defBox = new System.Windows.Forms.TextBox();
            this.structureBox = new System.Windows.Forms.TextBox();
            this.catBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wikiBox = new System.Windows.Forms.ListView();
            this.StruName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Def = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(295, 37);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 0;
            // 
            // defBox
            // 
            this.defBox.Location = new System.Drawing.Point(121, 224);
            this.defBox.Name = "defBox";
            this.defBox.Size = new System.Drawing.Size(108, 20);
            this.defBox.TabIndex = 1;
            // 
            // structureBox
            // 
            this.structureBox.Location = new System.Drawing.Point(121, 174);
            this.structureBox.Name = "structureBox";
            this.structureBox.Size = new System.Drawing.Size(108, 20);
            this.structureBox.TabIndex = 2;
            // 
            // catBox
            // 
            this.catBox.Location = new System.Drawing.Point(121, 114);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(108, 20);
            this.catBox.TabIndex = 3;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(121, 59);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(108, 20);
            this.dataBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(295, 131);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 29);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 47);
            this.button6.TabIndex = 11;
            this.button6.Text = "Load";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(197, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 47);
            this.button8.TabIndex = 13;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(295, 224);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 29);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(295, 270);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 29);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data Structure Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Structure: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Definition: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(458, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(144, 28);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "Status Box";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 23);
            this.toolStripStatusLabel1.Text = "Status Box";
            // 
            // wikiBox
            // 
            this.wikiBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.wikiBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StruName,
            this.Cat,
            this.Stru,
            this.Def});
            this.wikiBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.wikiBox.GridLines = true;
            this.wikiBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.wikiBox.HideSelection = false;
            this.wikiBox.LabelEdit = true;
            this.wikiBox.Location = new System.Drawing.Point(480, 50);
            this.wikiBox.Name = "wikiBox";
            this.wikiBox.Size = new System.Drawing.Size(600, 400);
            this.wikiBox.TabIndex = 12;
            this.wikiBox.UseCompatibleStateImageBehavior = false;
            this.wikiBox.View = System.Windows.Forms.View.Details;
            this.wikiBox.Click += new System.EventHandler(this.wikiBox_Click);
            this.wikiBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wikiBox_KeyDown);
            // 
            // StruName
            // 
            this.StruName.Text = "Structure Name";
            this.StruName.Width = 100;
            // 
            // Cat
            // 
            this.Cat.Text = "Category";
            this.Cat.Width = 100;
            // 
            // Stru
            // 
            this.Stru.Text = "Structure";
            this.Stru.Width = 100;
            // 
            // Def
            // 
            this.Def.Text = "Definition";
            this.Def.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 511);
            this.Controls.Add(this.wikiBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.catBox);
            this.Controls.Add(this.structureBox);
            this.Controls.Add(this.defBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox defBox;
        private System.Windows.Forms.TextBox structureBox;
        private System.Windows.Forms.TextBox catBox;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView wikiBox;
        private System.Windows.Forms.ColumnHeader StruName;
        private System.Windows.Forms.ColumnHeader Cat;
        private System.Windows.Forms.ColumnHeader Stru;
        private System.Windows.Forms.ColumnHeader Def;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

