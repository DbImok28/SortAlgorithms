using System;
using System.Windows.Forms;
using VerticalProgressBar;
using System.Drawing;

namespace Sort
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ItemVerticalProgressBar { get; private set; }
        public Label ItemLabel { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;

            ItemVerticalProgressBar = new VerticalProgressBar.VerticalProgressBar();
            ItemLabel = new Label();

            SetPosition(number);

            ItemVerticalProgressBar.BorderStyle = BorderStyles.Classic;
            ItemVerticalProgressBar.Color = Color.Blue;
            ItemVerticalProgressBar.Maximum = 100;
            ItemVerticalProgressBar.Minimum = 0;
            ItemVerticalProgressBar.Size = new Size(19, 96);
            ItemVerticalProgressBar.Step = 1;
            ItemVerticalProgressBar.Style = Styles.Solid;
            ItemVerticalProgressBar.Value = Value;

            ItemLabel.AutoSize = true;
            ItemLabel.Size = new Size(19, 13);
            ItemLabel.Text = Value.ToString();
            ItemLabel.TextAlign = ContentAlignment.TopCenter;
        }
        public void SetPosition(int number)
        {
            Number = number;
            int x = number * 20;
            ItemVerticalProgressBar.Location = new Point(x, 0);           
            ItemVerticalProgressBar.Name = "ItemVerticalProgressBar_" + number;           
            ItemVerticalProgressBar.TabIndex = number;         
            ItemLabel.Location = new Point(x, 100);
            ItemLabel.Name = "ItemLabel_" + number;
            ItemLabel.TabIndex = number;
        }
        public void SetColor(Color color)
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
