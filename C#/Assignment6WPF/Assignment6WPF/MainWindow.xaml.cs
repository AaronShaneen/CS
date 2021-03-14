using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Assignment6WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        clsDataAccess database;

        string[] takenSeats = new string[24];

        /// <summary>
        /// Main window will fill the combo box using the database provided
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                string sSQL;
                database = new clsDataAccess();
                int iReturn = 0;
                DataSet dataset = new DataSet();
                clsFlights Flights;


                //Create the SQL statement to extract the flights information
                sSQL = "SELECT Flight_ID, Flight_Number, Aircraft_Type FROM FLIGHT";

                //Extract the flights and put them into the DataSet
                dataset = database.ExecuteSQLStatement(sSQL, ref iReturn);

                //For each of the returned rows, create a new flight and add it to the combo box.
                for (int i = 0; i < iReturn; i++)
                {
                    Flights = new clsFlights();
                    Flights.sID = dataset.Tables[0].Rows[i][0].ToString();
                    Flights.sFlightNumber = dataset.Tables[0].Rows[i]["Flight_Number"].ToString();
                    Flights.sAircraftType = dataset.Tables[0].Rows[i]["Aircraft_Type"].ToString();
                    cmbChooseFlight.Items.Add(Flights);
                }
            }

            catch(Exception error)
            {
                Console.Write("Error: {0}", error);
            }

        }

        /// <summary>
        /// When the user selects a new flight from the combo box, the new flight will be visible.
        /// </summary>
        private void cmbChooseFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                clsFlights Flight;
                Flight = (clsFlights)cmbChooseFlight.SelectedItem;
                cmbChoosePassenger.Items.Clear();
                cmbChoosePassenger.IsEnabled = true;
                btnAddPassenger.IsEnabled = true;
                btnDeletePassenger.IsEnabled = true;
                Array.Clear(takenSeats, 0, takenSeats.Length);

                int iSelectedBox = cmbChooseFlight.SelectedIndex + 1;

                lblFlightNumber.Content = "Flight: " + Flight.sFlightNumber;

                database = new clsDataAccess();
                int iReturn = 0;
                DataSet dataset = new DataSet();
                clsPassenger Passenger;


                string sSQL = "SELECT PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number " +
                              "FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER " +
                              "WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND " +
                              "FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND " +
                              "FLIGHT.FLIGHT_ID = " + iSelectedBox;

                //Extract the passengers and put them into the DataSet
                dataset = database.ExecuteSQLStatement(sSQL, ref iReturn);

                for (int i = 0; i < iReturn; i++)
                {
                    Passenger = new clsPassenger();
                    Passenger.sID = dataset.Tables[0].Rows[i][0].ToString();
                    Passenger.sFirstName = dataset.Tables[0].Rows[i]["First_Name"].ToString();
                    Passenger.sLastName = dataset.Tables[0].Rows[i]["Last_Name"].ToString();
                    Passenger.sFlight = dataset.Tables[0].Rows[i][3].ToString();
                    Passenger.sSeat = dataset.Tables[0].Rows[i][3].ToString();

                    cmbChoosePassenger.Items.Add(Passenger);

                    takenSeats[i] = Passenger.sSeat;
                }

                /// <summary>
                /// if flight 1 is selected
                /// </summary>
                if (cmbChooseFlight.SelectedIndex == 0)
                {
                    pnlFlight1.IsEnabled = true;
                    pnlFlight1.Visibility = System.Windows.Visibility.Visible;
                    pnlFlight2.IsEnabled = false;
                    pnlFlight2.Visibility = System.Windows.Visibility.Hidden;
                    lblF1Line.Visibility = System.Windows.Visibility.Visible;
                    lblF2Line.Visibility = System.Windows.Visibility.Hidden;

                    foreach (Label MyLabel in pnlFlight1.Children)
                    {
                        MyLabel.Background = System.Windows.Media.Brushes.Blue;
                        for (int i = 0; i < takenSeats.Length; i++)
                        {
                            if ((string)MyLabel.Content == takenSeats[i])
                            {
                                MyLabel.Background = System.Windows.Media.Brushes.Red;
                            }

                        }
                    }
                }

                /// <summary>
                /// if flight 2 is selected
                /// </summary>
                else if (cmbChooseFlight.SelectedIndex == 1)
                {
                    pnlFlight1.IsEnabled = false;
                    pnlFlight1.Visibility = System.Windows.Visibility.Hidden;
                    pnlFlight2.IsEnabled = true;
                    pnlFlight2.Visibility = System.Windows.Visibility.Visible;
                    lblF1Line.Visibility = System.Windows.Visibility.Hidden;
                    lblF2Line.Visibility = System.Windows.Visibility.Visible;

                    foreach (Label MyLabel in pnlFlight2.Children)
                    {
                        MyLabel.Background = System.Windows.Media.Brushes.Blue;
                        for (int i = 0; i < takenSeats.Length; i++)
                        {
                            if ((string)MyLabel.Content == takenSeats[i])
                            {
                                MyLabel.Background = System.Windows.Media.Brushes.Red;
                            }
                        }
                    }
                }

            }

            catch (Exception error)
            {
                Console.Write("Error: {0}", error);
            }
        }

        /// <summary>
        /// This whole method is not needed for assignment6 P1
        /// </summary>
        private void cmbChoosePassenger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbChoosePassenger.SelectedItem != null)
            {
                clsPassenger Passenger;

                //Extract the selected Passenger object from the combo box
                Passenger = (clsPassenger)cmbChoosePassenger.SelectedItem;

                //Set the seat label
                txtPassengerSeat.Text = Passenger.sSeat;

                //Need to find the selected seat in the panel.  Loop through each label in the panel.
                if (cmbChooseFlight.SelectedIndex == 0)
                {
                    foreach (Label MyLabel in pnlFlight1.Children)
                    {
                        MyLabel.Background = System.Windows.Media.Brushes.Blue;
                        for (int i = 0; i < takenSeats.Length; i++)
                        {
                            if ((string)MyLabel.Content == takenSeats[i])
                            {
                                MyLabel.Background = System.Windows.Media.Brushes.Red;
                            }
                        }

                        //Check to see if the passenger's seat matches the label
                        if ((string)MyLabel.Content == Passenger.sSeat)
                        {
                            MyLabel.Background = System.Windows.Media.Brushes.Green;
                        }
                    }
                }

                else if (cmbChooseFlight.SelectedIndex == 1)
                {
                    foreach (Label MyLabel in pnlFlight2.Children)
                    {
                        MyLabel.Background = System.Windows.Media.Brushes.Blue;
                        for (int i = 0; i < takenSeats.Length; i++)
                        {
                            if ((string)MyLabel.Content == takenSeats[i])
                            {
                                MyLabel.Background = System.Windows.Media.Brushes.Red;
                            }
                        }

                        //Check to see if the passenger's seat matches the label
                        if ((string)MyLabel.Content == Passenger.sSeat)
                        {
                            MyLabel.Background = System.Windows.Media.Brushes.Green;
                        }
                    }
                }   
            }
        }

        /// <summary>
        /// add passenger button click
        /// brings up add passenger window
        /// </summary>
        private void btnAddPassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sSQL;
                clsDataAccess database = new clsDataAccess();
                string newPassID;
                string newPassName;

                /// create new add passenger window
                wndAddPassenger wndMyAddNewPlayerWindow = new wndAddPassenger();

                /// show add passenger window
                wndMyAddNewPlayerWindow.ShowDialog();

                /// query most recent passenger id
                sSQL = "SELECT MAX(Passenger_ID)  FROM Passenger";

                /// retrieve most recent passnger id
                newPassID = database.ExecuteScalarSQL(sSQL);

                /// close add passenger window instance
                wndMyAddNewPlayerWindow.Close();

                /// disable add passenger button
                btnAddPassenger.IsEnabled = false;

                /// query passenger name with most recent passenger id
                sSQL = "SELECT First_Name, Last_Name FROM Passenger WHERE Passenger_ID = " + newPassID;

                /// retrieve new passenger name
                newPassName = database.ExecuteScalarSQL(sSQL);

                /// clear passenger combo box
                cmbChoosePassenger.Items.Clear();

                /// add new passenger to passenger combo box
                cmbChoosePassenger.Items.Add(newPassName);

                /// automatically select new passenger
                /// cmbChoosePassenger.SelectedItem = newPassName;

                /// user selects seat for new passenger
                /// SELECT NEW PASS SEAT

                /// insert new passenger info into flight link table
                /// sSQL = "INSERT INTO Flight_Passenger_Link(Flight_ID, Passenger_ID, Seat_Number) VALUES('" + cmbChooseFlight.SelectedValue + "','" + newPassID + "','" + /* SEAT # */ + "')";

                /// enable add passenger button
                /// btnAddPassenger.IsEnabled = true;
            }

            catch (Exception error)
            {
                //Console.Write("Error: {0}", error);
                MessageBox.Show(error.ToString());
            }
        }

        private void btnDeletePassenger_Click(object sender, RoutedEventArgs e)
        {
            clsDataAccess database = new clsDataAccess();
            string sSQL;

            /// delete selected passenger from flight link table
            sSQL = "DELETE FROM FLIGHT_PASSENGER_LINK WHERE FLIGHT_ID = " + cmbChooseFlight.SelectedValue.ToString() + "AND PASSENGER_ID = " + cmbChoosePassenger.SelectedValue.ToString();

            /// delete selected passenger
            database.ExecuteNonQuery(sSQL);

            /// delete selected passenger from passenger table
            sSQL = "Delete FROM PASSENGER WHERE PASSENGER_ID = " + cmbChoosePassenger.SelectedValue.ToString();

            /// delete selected passenger
            database.ExecuteNonQuery(sSQL);
        }
    }
}
