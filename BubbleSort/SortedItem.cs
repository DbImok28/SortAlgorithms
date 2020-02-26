using System;
using System.Windows.Forms;
using VerticalProgressBar;

namespace Sort
{
    public class SortedItem
    {
        public VerticalProgressBar.VerticalProgressBar ItemVerticalProgressBar { get; private set; }
        public Label ItemLabel { get; private set; }
        public int Value { get; set; }
        public SortedItem(int value)
        {
            Value = value;
            ItemVerticalProgressBar = new VerticalProgressBar.VerticalProgressBar();
            ItemLabel = new Label();
            // 
            // ItemVerticalProgressBar
            // 
            ItemVerticalProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ItemVerticalProgressBar.Color = System.Drawing.Color.Blue;
            ItemVerticalProgressBar.Location = new System.Drawing.Point(3, 3);
            ItemVerticalProgressBar.Maximum = 100;
            ItemVerticalProgressBar.Minimum = 0;
            ItemVerticalProgressBar.Name = "ItemVerticalProgressBar";
            ItemVerticalProgressBar.Size = new System.Drawing.Size(18, 96);
            ItemVerticalProgressBar.Step = 1;
            ItemVerticalProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ItemVerticalProgressBar.TabIndex = 13;
            ItemVerticalProgressBar.Value = Value;
            // 
            // ItemLabel
            // 
            ItemLabel.AutoSize = true;
            ItemLabel.Location = new System.Drawing.Point(2, 102);
            ItemLabel.Name = "ItemLabel";
            ItemLabel.Size = new System.Drawing.Size(19, 13);
            ItemLabel.TabIndex = 14;
            ItemLabel.Text = Value.ToString();
            ItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        }
    }
}
