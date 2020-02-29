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

        AlgorithmsBase<int> toSort = new AlgorithmsBase<int>();

        List<AlgorithmsBase<SortedItem>> TypeSort = new List<AlgorithmsBase<SortedItem>>()
        {
            new BubbleSort<SortedItem>(),
            new CocktailSort<SortedItem>(),
            new InsertionSort<SortedItem>(),
            new ShellSort<SortedItem>()
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
                if (int.TryParse(item.ToString(), out int value))
                {
                    toSort.Items.Add(value);
                }
            }
            textBoxAdd.Clear();
            DisplayItems(labelToSort, toSort.Items);
            DisplayPanelItemSorted(toSort.Items);
        }
        private void buttonAddRandom_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRandomMin.Text, out int min))
            {
                if (int.TryParse(textBoxRandomMax.Text, out int max))
                {
                    if (int.TryParse(textBoxRandomCount.Text, out int count))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int value = rnd.Next(min, max);
                            toSort.Items.Add(value);
                        }
                        //DisplayPanelItemSorted(toSort.Items,out sortedItems);
                        DisplayPanelItemSorted(toSort.Items);
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
            TimeSpan time;
            labelSorted.Text = "";
            ClearPanelItem();
            sorted.Items.Clear();
            sorted.Items = ConvertToSortedItem(toSort.Items);
            DisplayPanelItemSorted(sorted.Items);
            if (checkBoxVisualize.Checked)
            {
                sorted.CompareEvent += CompareEvent;
                sorted.SwopEvent += SwopEvent;
            }
            try
            {
                time = sorted.TimeToSort();
            }
            catch (NotImplementedException)
            {
                labelSorted.Text = "Type sort is not corrected " + nameof(sorted);
                return;
            }
            DisplayItems(labelSorted, sorted.Items);
            timeLabel.Text = "Time: " + time.TotalSeconds.ToString() + " s";
            comparisonsLabel.Text = "Comparisons: " + sorted.ComparisonCount;
            swopLabel.Text = "Swops: " + sorted.SwopCount;
            sorted.CompareEvent -= CompareEvent;
            sorted.SwopEvent -= SwopEvent;
        }

        private void SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            int temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panelItemSorted.Refresh();
        }
        private void CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
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
            ClearPanelItem();
            //sortedItems.Clear();
            int number = 0;
            foreach (var value in items)
            {
                var sortedItem = new SortedItem(value, number);
                //sortedItems.Add(sortedItem);
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
        
        public List<SortedItem> ConvertToSortedItem(List<int> items)
        {
            var result = new List<SortedItem>();
            int number = 0;
            foreach (var item in items)
            {
                result.Add(new SortedItem(item, number));
                number++;
            }
            return result;
        }
        public void RemoveSortedItems()
        {
            //sortedItems.Clear();
            ClearPanelItem();
        }
        public void ClearPanelItem()
        {
            panelItemSorted.Controls.Clear();
            panelItemSorted.Refresh();
        }
    }
}
