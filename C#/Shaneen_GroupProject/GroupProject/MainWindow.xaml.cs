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
        public MainWindow()
        {
            InitializeComponent();

            populateDG();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            enableInvoiceInfo();
            updateBtn.IsEnabled = false;
            saveBtn.IsEnabled = true;
            populateCB();
            DataAccess db = new DataAccess();
            try
            {
                string newInvoiceNum;
                newInvoiceNum = db.ExecuteScalarSQL("SELECT (MAX(InvoiceNum)+1) FROM Invoices");

                numTB.Text = newInvoiceNum;
            }

            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Edit an Invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {

            DataAccess db = new DataAccess();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                updateBtn.IsEnabled = true;
                saveBtn.IsEnabled = false;
                if (invoiceDG.SelectedItems.Count > 0)
                {

                    DataRowView drv = (DataRowView)invoiceDG.SelectedItems[0];
                    numTB.Text = drv["InvoiceNum"].ToString();
                    dateTB.Text = drv["InvoiceDate"].ToString();
                    enableInvoiceInfo();
                    dateTB.IsReadOnly = false;

                    string sSQL = "SELECT InvoiceNum, LineItemNum, ItemDesc FROM LineItems INNER JOIN ItemDesc ON LineItems.ItemCode = ItemDesc.ItemCode WHERE InvoiceNum = " + drv["InvoiceNum"];

                    dt = db.ExecuteSQLStatement2(sSQL);

                    invoiceDG.ItemsSource = dt.DefaultView;

                    
                    int DBReturnNum = 0;
  
                    ds = db.ExecuteSQLStatement("SELECT ItemDesc FROM ItemDesc", ref DBReturnNum);

                    for (int i = 0; i < DBReturnNum; i++)
                    {
                        itemCB.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please select an invoice to edit.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Delete an Invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            try
            {
                //if an invoice is selected
                if (invoiceDG.SelectedItems.Count > 0)
                {
                    //capture selected invoice
                    DataRowView drv = (DataRowView)invoiceDG.SelectedItems[0];

                    //sql statements to delete invoice
                    string sSQL = "DELETE FROM Invoices WHERE InvoiceNum = " + drv["InvoiceNum"].ToString();
                    string sSQL2 = "DELETE FROM LineItems WHERE InvoiceNum =" + drv["InvoiceNum"].ToString();

                    if (MessageBox.Show("Delete Invoice?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        db.ExecuteNonQuery1(sSQL2);
                        db.ExecuteNonQuery1(sSQL);
                        populateDG();
                        MessageBox.Show("Invoice Deleted.", "Confirmation");
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Please select an invoice to delete.");
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            string invoiceNum = numTB.Text;
            string invoiceDate = dateTB.Text;

            DataAccess db = new DataAccess();
            DataTable dt = new DataTable();
            try
            {
                db.ExecuteNonQuery1("INSERT INTO Invoices(InvoiceNum, InvoiceDate, TotalCharge) VALUES(" + invoiceNum + ",'" + invoiceDate + "'," + 0 +")");
                dt = db.ExecuteSQLStatement2("SELECT InvoiceNum, FORMAT(InvoiceDate, 'mm/dd/yyyy') AS InvoiceDate, TotalCharge FROM Invoices");
                invoiceDG.ItemsSource = dt.DefaultView;
                numTB.Text = "";
                dateTB.Text = "";
                disableInvoiceInfo();
                MessageBox.Show("Invoice added!", "Message");
            }

            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string invoiceNum = numTB.Text;
            string itemDesc = itemCB.SelectedItem.ToString();
            int invoiceTotal = 0;

            DataAccess db = new DataAccess();
            DataTable dt = new DataTable();
            try
            {
                //query to get item code
                string itemCode = db.ExecuteScalarSQL("SELECT ItemCode FROM ItemDesc WHERE ItemDesc = '" + itemDesc +"'");
                invoiceTotal += Convert.ToInt32(db.ExecuteScalarSQL("SELECT Cost FROM ItemDesc WHERE ItemDesc = '" + itemDesc + "'"));
                string lineItem = db.ExecuteScalarSQL("SELECT (MAX(LineItemNum) + 1) FROM LineItems");
                db.ExecuteNonQuery1("INSERT INTO LineItems(InvoiceNum, LineItemNum, ItemCode) VALUES(" + invoiceNum + ", " + lineItem + ", '" + itemCode + "')");
                dt = db.ExecuteSQLStatement2("SELECT InvoiceNum, LineItemNum, ItemDesc FROM LineItems INNER JOIN ItemDesc ON LineItems.ItemCode = ItemDesc.ItemCode WHERE InvoiceNum = " + invoiceNum);
                invoiceDG.ItemsSource = dt.DefaultView;
                totalTB.Text = invoiceTotal.ToString();
                MessageBox.Show("Item added!");
            }

            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
            DataTable dt = new DataTable();
            string invoiceNum = numTB.Text;
            try
            {
                //if an invoice is selected
                if (invoiceDG.SelectedItems.Count > 0)
                {
                    //capture selected invoice
                    DataRowView drv = (DataRowView)invoiceDG.SelectedItems[0];

                    //sql statements to delete invoice

                    string sSQL = "DELETE FROM LineItems WHERE LineItemNum =" + drv["LineItemNum"].ToString();

                    if (MessageBox.Show("Are you sure you wish to delete this item?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        db.ExecuteNonQuery1(sSQL);

                        dt = db.ExecuteSQLStatement2("SELECT InvoiceNum, LineItemNum, ItemDesc FROM LineItems INNER JOIN ItemDesc ON LineItems.ItemCode = ItemDesc.ItemCode WHERE InvoiceNum = " + invoiceNum);
                        invoiceDG.ItemsSource = dt.DefaultView;
                        MessageBox.Show("Item Deleted!", "Confirmation");
                    }

                }
                else
                {
                    MessageBox.Show("Please select an invoice to delete.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            createBtn.IsEnabled = true;
            disableInvoiceInfo();
            populateDG();
            populateCB();
            deleteBtn.IsEnabled = true;
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            Search searchPage = new Search();
            searchPage.Show();
            this.Hide();  
        }

        private void populateCB()
        {
            try
            {
                DataAccess DBA = new DataAccess();
                DataSet DBDS = new DataSet();
                int DBReturnNum = 0;

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
                DataAccess DBA = new DataAccess();
                DataTable DBDT = new DataTable();

                DBDT = DBA.ExecuteSQLStatement2("SELECT InvoiceNum, FORMAT(InvoiceDate, 'mm/dd/yyyy') AS InvoiceDate, TotalCharge  FROM Invoices");

                invoiceDG.ItemsSource = DBDT.DefaultView;
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }



        private void enableInvoiceInfo()
        {
            dateTB.IsEnabled = true;
            itemCB.IsEnabled = true;
            priceTB.IsEnabled = true;
            //saveBtn.IsEnabled = true;
            addBtn.IsEnabled = true;
            cancelBtn.IsEnabled = true;
            //quantityTB.IsEnabled = true;
            removeBtn.IsEnabled = true;
            totalTB.IsEnabled = true;
            numTB.IsEnabled = true;
        }

        private void disableInvoiceInfo()
        {
            dateTB.IsEnabled = false;
            itemCB.IsEnabled = false;
            priceTB.IsEnabled = false;
            //saveBtn.IsEnabled = false;
            addBtn.IsEnabled = false;
            cancelBtn.IsEnabled = false;
            //quantityTB.IsEnabled = false;
            removeBtn.IsEnabled = false;
            totalTB.IsEnabled = false;
            numTB.IsEnabled = false;
        }

        private void itemCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string itemValue = itemCB.SelectedItem.ToString();
            try
            {
                DataAccess DBA = new DataAccess();
                DataSet ds = new DataSet();

                string sSQL = "SELECT Cost FROM ItemDesc WHERE ItemDesc LIKE '" + itemValue + "'";

                string x = DBA.ExecuteScalarSQL(sSQL);
                priceTB.Text = x;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            string invoiceNum = numTB.Text;
            string invoiceDate = dateTB.Text;
            int totalCharge = 0;
            DataAccess db = new DataAccess();
            DataTable dt = new DataTable();
            try
            {
                db.ExecuteNonQuery1("UPDATE Invoices SET InvoiceDate = '" + invoiceDate + "', TotalCharge = '" + totalCharge + "' WHERE InvoiceNum LIKE " + invoiceNum);
                dt = db.ExecuteSQLStatement2("SELECT InvoiceNum, FORMAT(InvoiceDate, 'mm/dd/yyyy') AS InvoiceDate, TotalCharge FROM Invoices");
                invoiceDG.ItemsSource = dt.DefaultView;
            }

            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    } /// end MainWindow
} /// end GroupProject
