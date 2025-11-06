using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project2App
{
    public partial class Form1 : Form
    {
        private VendingMachine vendingMachine;
        public Form1()
        {
            //Initial standard values for vending machine items
            List<Product> vendingMachineItems = new List<Product>()
            {
                new Product("Soda", 125),
                new Product("Chips", 100),
                new Product("Candy", 75)
            };
            vendingMachine = new VendingMachine(vendingMachineItems);
            InitializeComponent();
            foreach (Product p in vendingMachineItems)
            {
                //vendingMachineCheckedListBox.Items.Add(p.Name + " - $ " + ((p.Price/100.00).ToString("F2")));
                vendingMachineCheckedListBox.Items.Add($"{p.Name} - $ {(p.Price / 100.0):0.00}");
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if(quarterRadioBtn.Checked)
            {
                vendingMachine.InsertCoin(new Quarter());
            }
            else if(dimeRadioBtn.Checked)
            {
                vendingMachine.InsertCoin(new Dime());
            }
            else if(nickelRadioBtn.Checked)
            {
                vendingMachine.InsertCoin(new Nickel());
            }
            else { 
                MessageBox.Show("Please select a coin to insert.");
                return;
            }
            //double newAmount = (vendingMachine.CurrentBalance / 100.00);
            amountValueLbl.Text = "$ " + (vendingMachine.CurrentBalance / 100.00).ToString("F2");
        }

        private void returnChangeBtn_Click(object sender, EventArgs e)
        {
            if(vendingMachine.CurrentBalance > 0)
            {
                MessageBox.Show("Returning change: $" + vendingMachine.ReturnChange().ToString("F2"));
                //vendingMachine.ReturnChange();
                amountValueLbl.Text = "$ 0.00";
            }
            else
            {
                MessageBox.Show("No balance to return.");
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Processing purchase...");
            int totalCost = 0;
            List<string> receipt = new List<string>();
            if (vendingMachineCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item to purchase.");
                return;
            }
            foreach(string item in vendingMachineCheckedListBox.CheckedItems)
            {
                //MessageBox.Show("Selected item: " + item);
                string selectedItemName = item.Split('-')[0].Trim();
                foreach (Product p in vendingMachine.Products)
                {
                    if (p.Name == selectedItemName)
                    {
                        totalCost += p.Price;
                        receipt.Add(selectedItemName);
                    }
                }
            }
            
            if(totalCost != 0)
            {
                if(vendingMachine.CurrentBalance >= totalCost)
                {
                    vendingMachine.CurrentBalance -= totalCost;
                    amountValueLbl.Text = "$ " + (vendingMachine.CurrentBalance / 100.00).ToString("F2");
                    MessageBox.Show("You have purchased:\n" + string.Join(",\n", receipt) +
                        "\n\nTotal: $" + (totalCost / 100.0).ToString("0.00"));
                    vendingMachineCheckedListBox.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Insufficient balance. Please insert more coins.");
                }
            }
        }
    }// end class Form1

    class Coin
    {
        private int _value;
        private int _weight;

        public Coin(int value, int weight)
        {
            _value = value;
            _weight = weight;
        }
        public int Value { get { return _value; } set { _value = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
    }

    class Quarter : Coin
    {
        public Quarter() : base(25, 4)
        {

        }
    }

    class Dime : Coin
    {
        public Dime() : base(10, 2){}
    }

    class Nickel : Coin
    {
        public Nickel() : base(5, 5)
        {
        }
    }

    class Product
    {
        private string _name;
        private int _price;

        public Product(string name, int price)
        {
            _name = name;
            _price = price;
        }
        //Get and Set methods
        public string Name { get { return _name; } set { _name = value; }}
        public int Price { get { return _price; } set { _price = value; } }
    }

    class VendingMachine
    {
        const int MAX_CAPACITY = 50;
        private List<Product> _products;
        private int _currentBalance;
        private int _currentCapacity;

        public VendingMachine(List<Product> products)
        {
            _products = products;
            _currentBalance = 0;
        }
        public void InsertCoin(Coin coin)
        {
            if(_currentCapacity + coin.Weight < MAX_CAPACITY)
            {
                _currentCapacity += coin.Weight;
                _currentBalance += coin.Value;
            }
            else
            {
                MessageBox.Show("Vending Machine is full. Cannot accept more coins.");
                return;
            }
        }
        public int CurrentBalance{ get { return _currentBalance; } set { _currentBalance = value; } }
        public int CurrentCapacity { get { return _currentCapacity; } set { _currentCapacity = value; } }

        public List<Product> Products { get { return _products; } }

        public double ReturnChange()
        {
            double change = _currentBalance / 100.00;
            _currentBalance = 0;
            return change;
        }
    }
}// end namespace Project2App
