using System;
using System.Windows.Forms;
using VerticalProgressBar;

namespace Sort
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ItemVerticalProgressBar { get; private set; }
        public Label ItemLabel { get; private set; }
        public int Value { get; private set; }
        public SortedItem(int value,int number)
        {
            Value = value;
            ItemVerticalProgressBar = new VerticalProgressBar.VerticalProgressBar();
            ItemLabel = new Label();
            int x = number * 20;
            // 
            // ItemVerticalProgressBar
            // 
            ItemVerticalProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ItemVerticalProgressBar.Color = System.Drawing.Color.Blue;
            ItemVerticalProgressBar.Location = new System.Drawing.Point(x, 0);
            ItemVerticalProgressBar.Maximum = 100;
            ItemVerticalProgressBar.Minimum = 0;
            ItemVerticalProgressBar.Name = "ItemVerticalProgressBar_" + number;
            ItemVerticalProgressBar.Size = new System.Drawing.Size(19, 96);
            ItemVerticalProgressBar.Step = 1;
            ItemVerticalProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ItemVerticalProgressBar.TabIndex = number;
            ItemVerticalProgressBar.Value = Value;
            // 
            // ItemLabel
            // 
            ItemLabel.AutoSize = true;
            ItemLabel.Location = new System.Drawing.Point(x, 100);
            ItemLabel.Name = "ItemLabel_" + number;
            ItemLabel.Size = new System.Drawing.Size(19, 13);
            ItemLabel.TabIndex = number;
            ItemLabel.Text = Value.ToString();
            ItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        }
        public void SetValue(int value)
        {
            Value = value;
            ItemVerticalProgressBar.Value = Value;
            ItemLabel.Text = Value.ToString();

        }
        public void SetColor(System.Drawing.Color color)
        {
            ItemVerticalProgressBar.Color = color;
        }
        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            throw new ArgumentException("obj is not "+nameof(obj));
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
