using Group_Project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroupProject
{
    public partial class MainWindow : Window
    {
        DataAccess DBA = new DataAccess();
        DataSet DBDS = new DataSet();
        DataTable DBDT = new DataTable();
        string SQLStatement;
        int DBReturnNum;
        int newInvoiceNum;

        public MainWindow()
        {
            InitializeComponent();

            populateDG();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            enableInvoiceInfo();

            populateCB();

            try
            {
                SQLStatement = "INSERT INTO Invoices(InvoiceDate, TotalCharge) VALUES(#1/11/1111#, '0')";

                DBA.ExecuteNonQuery(SQLStatement);

                DataTable DBDT = new DataTable();

                SQLStatement = "SELECT * FROM Invoices";

                DBDT = DBA.ExecuteSQLStatement2(SQLStatement);

                invoiceDG.ItemsSource = DBDT.DefaultView;

                SQLStatement = "SELECT InvoiceNum FROM Invoices WHERE TotalCharge = 0";

                newInvoiceNum = Convert.ToInt32(DBA.ExecuteScalarSQL(SQLStatement));

                SQLStatement = "SELECT * FROM LineItems WHERE InvoiceNum = " + newInvoiceNum;

                DBDT = DBA.ExecuteSQLStatement2(SQLStatement);

                invoiceDG.ItemsSource = DBDT.DefaultView;

                numTB.Text = Convert.ToString(newInvoiceNum);

                SQLStatement = "SELECT InvoiceDate FROM Invoices WHERE InvoiceNum = " + newInvoiceNum;

                dateTB.Text = DBA.ExecuteScalarSQL(SQLStatement);

                SQLStatement = "SELECT TotalCharge FROM Invoices WHERE InvoiceNum = " + newInvoiceNum;

                totalTB.Text = DBA.ExecuteScalarSQL(SQLStatement);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            /// ADD CODE
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            /// ADD CODE
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            disableInvoiceInfo();

            populateDG();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            int itemQuant = Convert.ToInt32(quantityTB.Text);
            string itemName = itemCB.SelectedItem.ToString();
            string itemCode;

            try
            {
                SQLStatement = "SELECT ItemCode FROM ItemDesc WHERE ItemDesc = " + itemName;

                itemCode = DBA.ExecuteScalarSQL(SQLStatement);

                SQLStatement = "INSERT INTO LineItems(InvoiceNum, LineItemNum, ItemCode) VALUES(" + newInvoiceNum + "," + itemQuant + "," + itemCode + ")";

                DBA.ExecuteNonQuery(SQLStatement);
                
                SQLStatement = "SELECT * FROM LineItems WHERE InvoiceNum = " + newInvoiceNum;

                DBDT = DBA.ExecuteSQLStatement2(SQLStatement);

                invoiceDG.ItemsSource = DBDT.DefaultView;

                itemCB.Items.Clear();

                quantityTB.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            /// DELETE Invoices table
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            SQLStatement = "DELETE FROM Invoices WHERE InvoiceNum = " + newInvoiceNum;

            DBA.ExecuteNonQuery(SQLStatement);

            disableInvoiceInfo();

            populateDG();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            /// Search.MainWindow SearchWindow = new Search.MainWindow();

            /// SearchWindow.Show();
        }

        private void populateCB()
        {
            try
            {
                DBDS = DBA.ExecuteSQLStatement("SELECT ItemDesc FROM ItemDesc", ref DBReturnNum);

                for (int i = 0; i < DBReturnNum; i++)
                {
                    itemCB.Items.Add(DBDS.Tables[0].Rows[i][0].ToString());
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void populateDG()
        {
            try
            {
                SQLStatement = "SELECT * FROM Invoices";

                DBDT = DBA.ExecuteSQLStatement2(SQLStatement);

                invoiceDG.ItemsSource = DBDT.DefaultView;
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void enableInvoiceInfo()
        {
            numTB.IsEnabled = true;
            dateTB.IsEnabled = true;
            itemCB.IsEnabled = true;
            priceTB.IsEnabled = true;
            quantityTB.IsEnabled = true;
            totalTB.IsEnabled = true;
            saveBtn.IsEnabled = true;
            addBtn.IsEnabled = true;
            removeBtn.IsEnabled = true;
            cancelBtn.IsEnabled = true;
        }

        private void disableInvoiceInfo()
        {
            numTB.IsEnabled = false;
            numTB.Text = "";
            dateTB.IsEnabled = false;
            dateTB.Text = "";
            itemCB.IsEnabled = false;
            itemCB.Items.Clear();
            priceTB.IsEnabled = false;
            priceTB.Text = "";
            quantityTB.IsEnabled = false;
            quantityTB.Text = "";
            totalTB.IsEnabled = false;
            totalTB.Text = "";
            saveBtn.IsEnabled = false;
            addBtn.IsEnabled = false;
            removeBtn.IsEnabled = false;
            cancelBtn.IsEnabled = false;
        }
    } /// end MainWindow
} /// end GroupProject
