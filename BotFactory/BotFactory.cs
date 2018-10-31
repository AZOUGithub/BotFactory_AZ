using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BotFactory
{
    public partial class BotFactoryForm : Form
    {
        public BotFactoryForm()
        {
            InitializeComponent();
        }

        private void BotFactory_Load(object sender, EventArgs e)
        {
            Init();
        }
        public void Init()
        {

            List<Item> items = new List<Item>();
            items.Add(new Item() { Text = "R2D2", Value = 0 });
            items.Add(new Item() { Text = "HAL", Value = 1 });
            items.Add(new Item() { Text = "T-800", Value = 2 });
            items.Add(new Item() { Text = "Wall-E", Value = 3 });

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

        }

        public class Item
        {
            public Item() { }
            public int Value { set; get; }
            public string Text { set; get; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez choisi de construire le robot " + comboBox1.Text + " qui a pour temps d'exécution...");
        }
    }
}
