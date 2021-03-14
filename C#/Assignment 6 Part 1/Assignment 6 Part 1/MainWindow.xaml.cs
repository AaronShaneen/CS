using Assignment_6_Part_1.Business_Objects;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Assignment_6_Part_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Data access class
        /// </summary>
        DataAccess db;

        /// <summary>
        /// Holds the add passenger window
        /// </summary>
        AddPassengerWindow addPassengerWindow;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                db = new DataAccess();
                addPassengerWindow = new AddPassengerWindow();

                string sqlStatement;
                int numRows = 0;
                DataSet dataSet = new DataSet();
                Flight flight;

                sqlStatement = "SELECT * FROM Flight";

                dataSet = db.ExecuteSQLStatement(sqlStatement, ref numRows);

                for (int i = 0; i < numRows; i++)
                {
                    flight = new Flight();
                    flight.FlightID = Int32.Parse(dataSet.Tables[0].Rows[i]["Flight_ID"].ToString());
                    flight.FlightNumber = Int32.Parse(dataSet.Tables[0].Rows[i]["Flight_Number"].ToString());
                    flight.AircraftType = dataSet.Tables[0].Rows[i]["Aircraft_Type"].ToString();

                    flightComboBox.Items.Add(flight);
                }
            }

            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Displays the correct flight seating arrangement based on the combo box selection.
        /// Enables passenger combo box and add passenger button.
        /// </summary>
        private void chooseFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Flight flight;

                flight = (Flight)flightComboBox.SelectedItem;

                if (flight.FlightNumber == 102)
                {
                    flightSeatingGroupBox1.Visibility = Visibility.Hidden;
                    flightSeatingGroupBox2.Visibility = Visibility.Visible;
                    passengerComboBox.IsEnabled = true;
                    addPassengerButton.IsEnabled = true;
                }

                else if (flight.FlightNumber == 412)
                {
                    flightSeatingGroupBox2.Visibility = Visibility.Hidden;
                    flightSeatingGroupBox1.Visibility = Visibility.Visible;
                    passengerComboBox.IsEnabled = true;
                    addPassengerButton.IsEnabled = true;
                }
            }

            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Navigates to Add Passenger window from the main window
        /// </summary>
        private void navFromMainToAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                addPassengerWindow.ShowDialog();
                this.Show();
            }

            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
