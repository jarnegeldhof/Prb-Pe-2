using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prb.PermanenteEvaluatie.Resto.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int tableNumber;


        Dictionary<string, Decimal> drinks = new Dictionary<string, decimal>
        {
            { "Water", 2M},
            { "Cola", 2.5M},
            { "Wijn", 5M},
            { "Bier", 3M}
        };
        Dictionary<string, decimal> starters = new Dictionary<string, decimal>
        {
            { "Soep", 4.5M},
            { "Salades",5M},
            { "Bruschetta", 6M}
        };
        Dictionary<string, decimal> mainCourses = new Dictionary<string, decimal>
        {
            {"Steak", 15M},
            {"Kipfilet" , 12M},
            {"Zalm", 14M}
        };
        Dictionary<string, decimal> desserts = new Dictionary<string, decimal>
        {
            {"Ijs", 3.5M},
            {"Taart", 4m},
            {"Tiramisu", 4.5m}
        };

        Dictionary<string, (int quantity, decimal price)> table1 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table2 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table3 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table4 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table5 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table6 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table7 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> table8 = new Dictionary<string, (int, decimal)>();
        Dictionary<string, (int quantity, decimal price)> currentTable = new Dictionary<string, (int, decimal)>();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grbArticles.IsEnabled = false;
            btnCreateTicket.IsEnabled = false;
            btnClearTableCommand.IsEnabled = false;

        }


        private void BtnTable1_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table1;
            tableNumber = 1;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable1.Background = new SolidColorBrush(Colors.LightBlue);
            
        }


        private void BtnTable2_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table2;
            tableNumber = 2;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable2.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnTable3_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table3;
            tableNumber = 3;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable3.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnTable4_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table4;
            tableNumber = 4;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable4.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnTable5_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table5;
            tableNumber = 5;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable5.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnTable6_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table6;
            tableNumber = 6;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable6.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnTable7_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table7;
            tableNumber = 7;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable7.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnTable8_Click(object sender, RoutedEventArgs e)
        {
            currentTable = table8;
            tableNumber = 8;
            grbArticles.IsEnabled = true;
            BtnChooseDrink_Click(sender, e);
            tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            ColorTableButton();
            btnTable8.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnChooseDrink_Click(object sender, RoutedEventArgs e)
        {
            cmbArticle.IsEnabled = true;
            cmbArticle.ItemsSource = drinks.Keys;
            cmbArticle.SelectedIndex = 0;
            ColorChooseButton();
            btnChooseDrink.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnChooseStarter_Click(object sender, RoutedEventArgs e)
        {
            cmbArticle.IsEnabled = true;
            cmbArticle.ItemsSource = starters.Keys;
            cmbArticle.SelectedIndex = 0;
            ColorChooseButton();
            btnChooseStarter.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void BtnChooseMain_Click(object sender, RoutedEventArgs e)
        {
            cmbArticle.IsEnabled = true;
            cmbArticle.ItemsSource = mainCourses.Keys;
            cmbArticle.SelectedIndex = 0;
            ColorChooseButton();
            btnChooseMain.Background = new SolidColorBrush(Colors.LightBlue);
            
        }


        private void BtnChooseDessert_Click(object sender, RoutedEventArgs e)
        {
            cmbArticle.IsEnabled = true;
            cmbArticle.ItemsSource = desserts.Keys;
            cmbArticle.SelectedIndex = 0;
            ColorChooseButton();
            btnChooseDessert.Background = new SolidColorBrush(Colors.LightBlue);
        }


        private void CmbArticle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbArticle.SelectedItem == null) 
                return;

                string selectedItem = cmbArticle.SelectedItem.ToString();
            if (!currentTable.ContainsKey(selectedItem))
            {
                btnMinus.IsEnabled = false;
            }
        }


        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = cmbArticle.SelectedItem.ToString();
            if (cmbArticle.SelectedItem != null)
            {
                
                decimal itemPrice = GetItemPrice(selectedItem);
                if (currentTable.ContainsKey(selectedItem))
                {
                    currentTable[selectedItem] = (currentTable[selectedItem].quantity + 1, itemPrice);  
                }
                else
                {
                    currentTable.Add(selectedItem, (1, itemPrice));
                }
                tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
            }
            btnCreateTicket.IsEnabled = true;
            btnClearTableCommand.IsEnabled = true;
            btnMinus.IsEnabled = true;
        }


        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (cmbArticle.SelectedItem != null)
            {
                string selectedItem = cmbArticle.SelectedItem.ToString();
                if (currentTable.ContainsKey(selectedItem))
                {

                    int newQuantity = currentTable[selectedItem].quantity - 1;

                    if (newQuantity > 0)
                    {
                        currentTable[selectedItem] = (newQuantity, currentTable[selectedItem].price);
                    }
                    else
                    {
                        currentTable.Remove(selectedItem);
                        btnMinus.IsEnabled = false;
                    }

                    tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
                }
                if (currentTable.Count == 0)
                {
                    btnClearTableCommand.IsEnabled = false;
                    btnCreateTicket.IsEnabled = false;
                }
            }
        }


        private void BtnClearTableCommand_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult result = MessageBox.Show($"Weet je zeket dat je de bestilling van tafel {tableNumber} wilt verwijderen", "leeg tafel besteling", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                currentTable.Clear();
                tbkOrderOverview.Text = LoadOrderForTable(currentTable, tableNumber);
                btnClearTableCommand.IsEnabled = false ;
                btnCreateTicket.IsEnabled=false;
            }
        }


        private void BtnCreateTicket_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CreateTicket(currentTable, tableNumber), "BTW-bon");
        }


        private void BtnCalculateChange_Click(object sender, RoutedEventArgs e)
        {

        }


        private decimal GetItemPrice(string selectedItems)
        {
            if (drinks.ContainsKey(selectedItems))
                return drinks[selectedItems];
            else if (starters.ContainsKey(selectedItems))
                return starters[selectedItems];
            else if (mainCourses.ContainsKey(selectedItems))
                return mainCourses[selectedItems];
            else return desserts[selectedItems];
        }


        private string LoadOrderForTable(Dictionary<string, (int, decimal)> tableOrder, int tableNumber)
        {

            if (tableOrder == null || tableOrder.Count == 0)
            {
                return $"Orders voor tafel {tableNumber} \n" +
                       $"{new string('-', 69)}\n" +
                       "Geen bestelling voor deze tafel.\n" +
                       $"{new string('=', 40)}\n";
            }
            else
            {
                string result = $"Orders voor tafel {tableNumber}\n" +
                                $"{new string('-', 69)}\n";
                               
                foreach (var item in tableOrder)
                {
                    string itemDetails = $" {item.Key}: {item.Value.Item1} x € {item.Value.Item2.ToString("0.0")} \n";
                    result += itemDetails;
                }

                decimal totalPrice = tableOrder.Sum(item => item.Value.Item1 * item.Value.Item2);
                result += $"{new string('=', 40)}\n"+ $" total : € {totalPrice.ToString("0.0")}\n";


                btnClearTableCommand.IsEnabled = true;
                btnCreateTicket.IsEnabled = true;
                return result;
               
            }
        }


        private string CreateTicket(Dictionary<string, (int, decimal)> tableOrder, int tableNumber)
        {
             
            string result = $"***Btw Kasticket***\n" +
                            $"{new string('-', 69)}" +
                            $"\nRestaurant \nA TABLE \nStationstraat 1f \n8000 Brugge \nwww.atable.be\n" +
                            $"{new string('-', 69)}\n" +
                            $"tafel {tableNumber}\n" +
                            $"{new string('-', 69)}\n";
            foreach (var item in tableOrder)
            {
                decimal itemPrice = item.Value.Item1 * item.Value.Item2;
                string itemDetails = $" {item.Key}: {item.Value.Item1} x € {item.Value.Item2.ToString("0.0")} = € {itemPrice.ToString("0.0")}\n";
                result += itemDetails;
            }
            
            decimal totalPrice = tableOrder.Sum(item => item.Value.Item1 * item.Value.Item2);
            result += $"{new string('=', 40)}\n" + $" EURO:                   € {totalPrice.ToString("0.0")}\n";

            return result;
        }


        private void ColorTableButton()
        {
            btnTable1.Background = new SolidColorBrush(Colors.LightGray);
            btnTable2.Background = new SolidColorBrush(Colors.LightGray);
            btnTable3.Background = new SolidColorBrush(Colors.LightGray);
            btnTable4.Background = new SolidColorBrush(Colors.LightGray);
            btnTable5.Background = new SolidColorBrush(Colors.LightGray);
            btnTable6.Background = new SolidColorBrush(Colors.LightGray);
            btnTable7.Background = new SolidColorBrush(Colors.LightGray);
            btnTable8.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void ColorChooseButton()
        {
            btnChooseStarter.Background = new SolidColorBrush(Colors.LightGray);
            btnChooseMain.Background = new SolidColorBrush(Colors.LightGray);
            btnChooseDrink.Background = new SolidColorBrush(Colors.LightGray);
            btnChooseDessert.Background = new SolidColorBrush(Colors.LightGray);
        }
       
    }

}
