namespace Sort
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelToSort = new System.Windows.Forms.Label();
            this.labelSorted = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.TypeSortListBox = new System.Windows.Forms.ListBox();
            this.rndMinLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddRandom = new System.Windows.Forms.Button();
            this.textBoxRandomCount = new System.Windows.Forms.TextBox();
            this.rndCountLabel = new System.Windows.Forms.Label();
            this.textBoxRandomMax = new System.Windows.Forms.TextBox();
            this.rndMaxLabel = new System.Windows.Forms.Label();
            this.textBoxRandomMin = new System.Windows.Forms.TextBox();
            this.randomAddLable = new System.Windows.Forms.Label();
            this.checkBoxVisualize = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelItemSorted = new System.Windows.Forms.Panel();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.Speedlabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.comparisonsLabel = new System.Windows.Forms.Label();
            this.swopLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.patternLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(231, 18);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 21);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(3, 19);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(222, 20);
            this.textBoxAdd.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSort.Location = new System.Drawing.Point(0, 0);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(193, 25);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelToSort
            // 
            this.labelToSort.AutoSize = true;
            this.labelToSort.Location = new System.Drawing.Point(3, 28);
            this.labelToSort.Name = "labelToSort";
            this.labelToSort.Size = new System.Drawing.Size(35, 13);
            this.labelToSort.TabIndex = 3;
            this.labelToSort.Text = "toSort";
            // 
            // labelSorted
            // 
            this.labelSorted.AutoSize = true;
            this.labelSorted.Location = new System.Drawing.Point(3, 41);
            this.labelSorted.Name = "labelSorted";
            this.labelSorted.Size = new System.Drawing.Size(38, 13);
            this.labelSorted.TabIndex = 4;
            this.labelSorted.Text = "Sorted";
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.Location = new System.Drawing.Point(0, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 25);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TypeSortListBox
            // 
            this.TypeSortListBox.FormattingEnabled = true;
            this.TypeSortListBox.Location = new System.Drawing.Point(308, 12);
            this.TypeSortListBox.Name = "TypeSortListBox";
            this.TypeSortListBox.Size = new System.Drawing.Size(90, 225);
            this.TypeSortListBox.TabIndex = 6;
            // 
            // rndMinLabel
            // 
            this.rndMinLabel.AutoSize = true;
            this.rndMinLabel.Location = new System.Drawing.Point(4, 23);
            this.rndMinLabel.Name = "rndMinLabel";
            this.rndMinLabel.Size = new System.Drawing.Size(24, 13);
            this.rndMinLabel.TabIndex = 8;
            this.rndMinLabel.Text = "Min";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.patternLabel);
            this.panel1.Controls.Add(this.addLable);
            this.panel1.Controls.Add(this.textBoxAdd);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 69);
            this.panel1.TabIndex = 9;
            // 
            // addLable
            // 
            this.addLable.AutoSize = true;
            this.addLable.Location = new System.Drawing.Point(4, 3);
            this.addLable.Name = "addLable";
            this.addLable.Size = new System.Drawing.Size(26, 13);
            this.addLable.TabIndex = 6;
            this.addLable.Text = "Add";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonAddRandom);
            this.panel2.Controls.Add(this.textBoxRandomCount);
            this.panel2.Controls.Add(this.rndCountLabel);
            this.panel2.Controls.Add(this.textBoxRandomMax);
            this.panel2.Controls.Add(this.rndMaxLabel);
            this.panel2.Controls.Add(this.textBoxRandomMin);
            this.panel2.Controls.Add(this.randomAddLable);
            this.panel2.Controls.Add(this.rndMinLabel);
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 65);
            this.panel2.TabIndex = 10;
            // 
            // buttonAddRandom
            // 
            this.buttonAddRandom.Location = new System.Drawing.Point(231, 20);
            this.buttonAddRandom.Name = "buttonAddRandom";
            this.buttonAddRandom.Size = new System.Drawing.Size(44, 20);
            this.buttonAddRandom.TabIndex = 15;
            this.buttonAddRandom.Text = "Add";
            this.buttonAddRandom.UseVisualStyleBackColor = true;
            this.buttonAddRandom.Click += new System.EventHandler(this.buttonAddRandom_Click);
            // 
            // textBoxRandomCount
            // 
            this.textBoxRandomCount.Location = new System.Drawing.Point(179, 20);
            this.textBoxRandomCount.Name = "textBoxRandomCount";
            this.textBoxRandomCount.Size = new System.Drawing.Size(46, 20);
            this.textBoxRandomCount.TabIndex = 14;
            this.textBoxRandomCount.Text = "10";
            // 
            // rndCountLabel
            // 
            this.rndCountLabel.AutoSize = true;
            this.rndCountLabel.Location = new System.Drawing.Point(147, 23);
            this.rndCountLabel.Name = "rndCountLabel";
            this.rndCountLabel.Size = new System.Drawing.Size(35, 13);
            this.rndCountLabel.TabIndex = 13;
            this.rndCountLabel.Text = "Count";
            // 
            // textBoxRandomMax
            // 
            this.textBoxRandomMax.Location = new System.Drawing.Point(98, 20);
            this.textBoxRandomMax.Name = "textBoxRandomMax";
            this.textBoxRandomMax.Size = new System.Drawing.Size(46, 20);
            this.textBoxRandomMax.TabIndex = 12;
            this.textBoxRandomMax.Text = "100";
            // 
            // rndMaxLabel
            // 
            this.rndMaxLabel.AutoSize = true;
            this.rndMaxLabel.Location = new System.Drawing.Point(74, 23);
            this.rndMaxLabel.Name = "rndMaxLabel";
            this.rndMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.rndMaxLabel.TabIndex = 11;
            this.rndMaxLabel.Text = "Max";
            // 
            // textBoxRandomMin
            // 
            this.textBoxRandomMin.Location = new System.Drawing.Point(26, 20);
            this.textBoxRandomMin.Name = "textBoxRandomMin";
            this.textBoxRandomMin.Size = new System.Drawing.Size(46, 20);
            this.textBoxRandomMin.TabIndex = 10;
            this.textBoxRandomMin.Text = "0";
            // 
            // randomAddLable
            // 
            this.randomAddLable.AutoSize = true;
            this.randomAddLable.Location = new System.Drawing.Point(4, 4);
            this.randomAddLable.Name = "randomAddLable";
            this.randomAddLable.Size = new System.Drawing.Size(68, 13);
            this.randomAddLable.TabIndex = 9;
            this.randomAddLable.Text = "Random add";
            // 
            // checkBoxVisualize
            // 
            this.checkBoxVisualize.AutoSize = true;
            this.checkBoxVisualize.Checked = true;
            this.checkBoxVisualize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisualize.Location = new System.Drawing.Point(492, 135);
            this.checkBoxVisualize.Name = "checkBoxVisualize";
            this.checkBoxVisualize.Size = new System.Drawing.Size(67, 17);
            this.checkBoxVisualize.TabIndex = 11;
            this.checkBoxVisualize.Text = "Visualize";
            this.checkBoxVisualize.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelSorted);
            this.panel3.Controls.Add(this.labelToSort);
            this.panel3.Location = new System.Drawing.Point(12, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 69);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 25);
            this.panel4.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSort);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer1.Size = new System.Drawing.Size(286, 25);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelItemSorted
            // 
            this.panelItemSorted.AutoSize = true;
            this.panelItemSorted.Location = new System.Drawing.Point(404, 12);
            this.panelItemSorted.Name = "panelItemSorted";
            this.panelItemSorted.Size = new System.Drawing.Size(438, 115);
            this.panelItemSorted.TabIndex = 15;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(440, 133);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(46, 20);
            this.textBoxSpeed.TabIndex = 19;
            this.textBoxSpeed.Text = "0";
            // 
            // Speedlabel
            // 
            this.Speedlabel.AutoSize = true;
            this.Speedlabel.Location = new System.Drawing.Point(403, 136);
            this.Speedlabel.Name = "Speedlabel";
            this.Speedlabel.Size = new System.Drawing.Size(38, 13);
            this.Speedlabel.TabIndex = 18;
            this.Speedlabel.Text = "Speed";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(3, 3);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            // 
            // comparisonsLabel
            // 
            this.comparisonsLabel.AutoSize = true;
            this.comparisonsLabel.Location = new System.Drawing.Point(3, 20);
            this.comparisonsLabel.Name = "comparisonsLabel";
            this.comparisonsLabel.Size = new System.Drawing.Size(67, 13);
            this.comparisonsLabel.TabIndex = 1;
            this.comparisonsLabel.Text = "Comparisons";
            // 
            // swopLabel
            // 
            this.swopLabel.AutoSize = true;
            this.swopLabel.Location = new System.Drawing.Point(3, 37);
            this.swopLabel.Name = "swopLabel";
            this.swopLabel.Size = new System.Drawing.Size(39, 13);
            this.swopLabel.TabIndex = 2;
            this.swopLabel.Text = "Swops";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.comparisonsLabel);
            this.panel5.Controls.Add(this.swopLabel);
            this.panel5.Controls.Add(this.timeLabel);
            this.panel5.Location = new System.Drawing.Point(406, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 58);
            this.panel5.TabIndex = 20;
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(4, 46);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(74, 13);
            this.patternLabel.TabIndex = 7;
            this.patternLabel.Text = "Pattern(# # #)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(852, 250);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.Speedlabel);
            this.Controls.Add(this.panelItemSorted);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.checkBoxVisualize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TypeSortListBox);
            this.Name = "Form1";
            this.Text = "Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelToSort;
        private System.Windows.Forms.Label labelSorted;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox TypeSortListBox;
        private System.Windows.Forms.Label rndMinLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label addLable;
        private System.Windows.Forms.CheckBox checkBoxVisualize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxRandomMax;
        private System.Windows.Forms.Label rndMaxLabel;
        private System.Windows.Forms.TextBox textBoxRandomMin;
        private System.Windows.Forms.Label randomAddLable;
        private System.Windows.Forms.TextBox textBoxRandomCount;
        private System.Windows.Forms.Label rndCountLabel;
        private System.Windows.Forms.Button buttonAddRandom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelItemSorted;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label Speedlabel;
        private System.Windows.Forms.Label comparisonsLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label swopLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label patternLabel;
    }
}

