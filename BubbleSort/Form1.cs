using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;

namespace Sort
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<SortedItem> sortedItems = new List<SortedItem>();

        AlgorithmsBase<int> toSort = new AlgorithmsBase<int>();

        List<AlgorithmsBase<SortedItem>> TypeSort = new List<AlgorithmsBase<SortedItem>>()
        {
            new BubbleSort<SortedItem>(),
            new CocktailSort<SortedItem>(),
            new InsertionSort<SortedItem>()
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
                    DisplayPanelItemSorted(toSort.Items,out sortedItems);
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
                            DisplayPanelItemSorted(toSort.Items,out sortedItems);
                        }
                        DisplayItems(labelToSort, toSort.Items);
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            toSort.Items.Clear();
            labelToSort.Text = labelSorted.Text = "";
            RemoveSortedItems();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            AlgorithmsBase<SortedItem> sorted = (AlgorithmsBase<SortedItem>)TypeSortListBox.SelectedItem;
            if (sorted == null)
            {
                labelSorted.Text = "Type sort is not selected";
                return;
            }
            labelSorted.Text = "";
            //RemoveSortedItems();
            sorted.Items.Clear();
            ClearPanelItem();
            sorted.Items.AddRange(sortedItems);
            DisplayPanelItemSorted(sorted.Items);
            if (checkBoxVisualize.Checked)
            {
                if (sorted is BubbleSort<SortedItem>)
                {
                    sorted.CompareEvent += BubbleSort_CompareEvent;
                    sorted.SwopEvent += BubbleSort_SwopEvent;
                }
            }
            try
            {
                var time = sorted.TimeToSort();
            }
            catch (NotImplementedException)
            {
                labelSorted.Text = "Type sort is not corrected " + nameof(sorted);
                return;
            }
            DisplayItems(labelSorted, sorted.Items);
            //sorted.Items.Clear();
        }

        private void BubbleSort_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            int temp = e.Item1.Value;
            e.Item1.SetValue(e.Item2.Value);
            e.Item2.SetValue(temp);
            panelItemSorted.Refresh();
        }
        private void BubbleSort_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.DarkRed);
            panelItemSorted.Refresh();
            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
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
        public void DisplayItems(Label label, List<SortedItem> items)
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
            int number = 0;
            foreach (var value in items)
            {
                var sortedItem = new SortedItem(value, number);
                sortedItems.Add(sortedItem);
                panelItemSorted.Controls.Add(sortedItem.ItemVerticalProgressBar);
                panelItemSorted.Controls.Add(sortedItem.ItemLabel);
                number++;
            }
            panelItemSorted.Refresh();
        }
        public void DisplayPanelItemSorted(List<int> items, out List<SortedItem> sortedItems)
        {
            var result = new List<SortedItem>();
            ClearPanelItem();
            int number = 0;
            foreach (var value in items)
            {
                var sortedItem = new SortedItem(value, number);
                result.Add(sortedItem);
                panelItemSorted.Controls.Add(sortedItem.ItemVerticalProgressBar);
                panelItemSorted.Controls.Add(sortedItem.ItemLabel);
                number++;
            }
            sortedItems = result;
            panelItemSorted.Refresh();
        }
        public void DisplayPanelItemSorted(List<SortedItem> items)
        {
            ClearPanelItem();
            int number = 0;
            foreach (var item in items)
            {
                panelItemSorted.Controls.Add(item.ItemVerticalProgressBar);
                panelItemSorted.Controls.Add(item.ItemLabel);
                number++;
            }
            panelItemSorted.Refresh();
        }
        
        public void RemoveSortedItems()
        {
            //foreach (var item in sortedItems)
            //{
            //    panelItemSorted.Controls.Remove(item.ItemLabel);
            //    panelItemSorted.Controls.Remove(item.ItemVerticalProgressBar);
            //}
            sortedItems.Clear();
            ClearPanelItem();
        }
        public void ClearPanelItem()
        {
            panelItemSorted.Controls.Clear();
            panelItemSorted.Refresh();
        }
    }
}
