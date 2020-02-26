using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;

namespace Sort
{
    public partial class Form1 : Form
    {
        List<SortedItem> sortedItems = new List<SortedItem>();
        Random rnd = new Random();
        AlgorithmsBase<int> toSort = new AlgorithmsBase<int>();
        List<AlgorithmsBase<int>> TypeSort = new List<AlgorithmsBase<int>>()
        {
            new BubbleSort<int>(),
            new CocktailSort<int>(),
            new InsertionSort<int>()
        };
        public Form1()
        {
            InitializeComponent();
            labelToSort.Text = labelSorted.Text = "";
            foreach (var item in TypeSort)
            {
                TypeSortListBox.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MatchCollection matchCollection = Regex.Matches(textBoxAdd.Text, @"(\d*)", RegexOptions.Singleline);
            foreach (var item in matchCollection)
            {
                if (int.TryParse(item.ToString(),out int value))
                {                    
                    textBoxAdd.Clear();
                    toSort.Items.Add(value);
                    DisplayItems(labelToSort, toSort.Items);
                    DisplayPanelItemSorted(toSort.Items);
                }
            }
        }

        private void buttonAddRandom_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRandomMin.Text, out int min))
            {
                if (int.TryParse(textBoxRandomMax.Text, out int max))
                {
                    if (int.TryParse(textBoxRandomCount.Text, out int count))
                    {
                        for (int i = 0; i < count + 1; i++)
                        {
                            int value = rnd.Next(min, max);
                            toSort.Items.Add(value);
                            DisplayPanelItemSorted(toSort.Items);
                        }
                        DisplayItems(labelToSort, toSort.Items);
                    }
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            labelSorted.Text = "";
            AlgorithmsBase<int> sorted = (AlgorithmsBase<int>)TypeSortListBox.SelectedItem;
            if (sorted == null)
            {
                labelSorted.Text = "Type sort is not selected";
                return;
            }
            sorted.Items.AddRange(toSort.Items);
            try
            {
                sorted.TimeToSort();
            }
            catch (NotImplementedException)
            {
                labelSorted.Text = "Type sort is not selected";
                return;
            }
            DisplayItems(labelSorted, sorted.Items);
            sorted.Items.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            toSort.Items.Clear();
            labelToSort.Text = labelSorted.Text = "";
            foreach (var item in sortedItems)
            {
                panelItemSorted.Controls.Remove(item.ItemLabel);
                panelItemSorted.Controls.Remove(item.ItemVerticalProgressBar);
            }
            sortedItems.Clear();
        }

        public void DisplayItems(Label label, List<int> items)
        {
            label.Text = "";
            for (int i = 0; i < items.Count; i++)
            {
                if (i > 0)
                {
                    label.Text += ", " + items[i].ToString();
                }
                else
                {
                    label.Text += items[i].ToString();
                }
            }
        }
        public void DisplayPanelItemSorted(List<int> items)
        {
            foreach (var item in sortedItems)
            {
                panelItemSorted.Controls.Remove(item.ItemLabel);
                panelItemSorted.Controls.Remove(item.ItemVerticalProgressBar);
            }
            sortedItems.Clear();
            foreach (var value in items)
            {
                var sortedItem = new SortedItem(value);
                sortedItems.Add(sortedItem);
                panelItemSorted.Controls.Add(sortedItem.ItemVerticalProgressBar);
                panelItemSorted.Controls.Add(sortedItem.ItemLabel);
            }
        }
            
    }
}
