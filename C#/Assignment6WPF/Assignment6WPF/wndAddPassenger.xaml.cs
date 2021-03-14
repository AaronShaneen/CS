using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment6WPF
{
    /// <summary>
    /// Interaction logic for wndAddPassenger.xaml
    /// </summary>
    public partial class wndAddPassenger : Window
    {
        clsDataAccess database = new clsDataAccess();
        DataSet dataset = new DataSet();
        string sSQL;
        int iReturn = 0;

        public wndAddPassenger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the current window without adding the new user
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }

            catch (Exception error)
            {
                Console.Write("Error: {0}", error);
            }
        }

        /// <summary>
        /// Save the new passenger
        /// </summary>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sSQL = "INSERT INTO PASSENGER(First_Name, Last_Name) VALUES('" + txtFirstName.Text.ToString() + "','" + txtLastName.Text.ToString() + "')";

                database.ExecuteNonQuery(sSQL);

                this.Hide();
            }

            catch (Exception error)
            {
                Console.Write("Error: {0}", error);
            }
        }
    }
}
