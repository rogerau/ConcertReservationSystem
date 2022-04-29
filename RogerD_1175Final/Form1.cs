using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RogerD_1175Final2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create a list to store all the concert reservation objects or customer details the user will entry to the app
        List<ConcertReservation> SortedReservationList = new List<ConcertReservation>();
        //Create an instance of the concert reservation class which is gonna be empty and will receive values
        ConcertReservation CurrentReservation = new ConcertReservation(); 

        //Event handler methods
        private void Form1_Load(object sender, EventArgs e)
        {
            //Welcome message once the App is openned
            MessageBox.Show("Welcome to the ConcertReservation App!");
            //Once the App is openned focus the cursor into the customer name textbox for user entry
            CNTextBox.Focus();
        }

        private void CreateCurrentRButton_Click(object sender, EventArgs e)
        {
            //Once the create current reservation button is clicked, load all the user entries into the current reservation listbox
            LoadCurrentReservationToListBox();
            //Once the information is added to the current reservation listbox, clear the input fields
            CNTextBox.Text = "";
            NATTextBox.Text = "";
            NCTTextBox.Text = "";
        }

        private void AddCurrentRButton_Click(object sender, EventArgs e)
        {
            //Once the add current reservation button is clicked, load the reservation list to the sorted reservation listbox
            //the list send is sorted by customername
            SortedReservationList.Add(CurrentReservation);
            LoadReservationListToListBox(SortedReservationList.OrderBy(customer => customer.CustomerName).ToList());
            CurrentReservationListBox.Items.Clear();
        }

        private void ClearCurrentRButton_Click(object sender, EventArgs e)
        {
            //Reset current reservation object using the empty constructor
            CurrentReservation = new ConcertReservation();
            //Clear the input text fields
            CNTextBox.Text = "";
            NATTextBox.Text = "";
            NCTTextBox.Text = "";
            //Clear the current reservation listbox
            CurrentReservationListBox.Items.Clear();
        }

        private void WriteRButton_Click(object sender, EventArgs e)
        {
            //Once the write list and grand total button is clicked, write the reservation list into a file ordered
            // by customer name.
            WriteToOutputFile(SortedReservationList.OrderBy(customer => customer.CustomerName).ToList());
            //Clear the sorted reservation listbox
            SortedReservationListBox.Items.Clear();
            //Clear the reservation list
            SortedReservationList.Clear();
        }
        //Methods

        //Method to load all user entries into the current reservation listbox
        private void LoadCurrentReservationToListBox()
        {
            //User validation of customername, number of adult and child tickets entries.
            if (CNTextBox.Text == "")
            {
                MessageBox.Show("Customer Name cannot be empty");
            }
            else if ((!int.TryParse(NATTextBox.Text, out int nat) || nat <0) || (!int.TryParse(NCTTextBox.Text, out int nct) || nct < 0))
            {

                MessageBox.Show("Number of tickets must be positive whole number >= 0");
            }
            else if (nat == 0 && nct == 0)
            {
                MessageBox.Show("At least one of NumberOfAdultTickets or NumOfChildTickets must be greater than 0");
            }

            else
            {
                //Clear the listbox for a new entry.
                CurrentReservationListBox.Items.Clear();

                //Populated the current reservation object with the validated values
                CurrentReservation.CustomerName = CNTextBox.Text;
                CurrentReservation.NumberOfAdultTickets = nat;
                CurrentReservation.NumberOfChildTickets = nct;

                //Add each current reservation to the ListBox
                CurrentReservationListBox.Items.Add("Customer Name: " + CurrentReservation.CustomerName);
                CurrentReservationListBox.Items.Add("Number of Adult Tickets: " + CurrentReservation.NumberOfAdultTickets);
                CurrentReservationListBox.Items.Add("Number of Child Tickets: " + CurrentReservation.NumberOfChildTickets);
                CurrentReservationListBox.Items.Add("Total Cost: " + CurrentReservation.TotalCost.ToString("C2"));
            }
        }

        //Method to load the reservation list to the SortedReservation ListBox
        private void LoadReservationListToListBox(List<ConcertReservation> AnyList)
        {
            //Clear the sorted reservation listbox
            SortedReservationListBox.Items.Clear();
            //Create a formatted output variable to hold the header in the listbox
            string objectStr2 = String.Format(
                "{0, -22} {1, -22} {2, -22} {3, -22}",
                "CustomerName", "NumberOfAdultTickets", "NumberOfChildTickets", "TotalCost");
            //Add the formatted header into the listbox
            SortedReservationListBox.Items.Add(objectStr2);
            //Add each formatted customer information into the sorted reservation listbox
            foreach (ConcertReservation item in AnyList)
            {
                SortedReservationListBox.Items.Add(item.ToString());
            }
        }


        private void WriteToOutputFile(List<ConcertReservation> AnyList)
        {
            //use a try cath blocks to cath any error during the writting.
            try
            {
                //Create an instance of the StreamWriter class to specify the location and name of the output file.
                using (StreamWriter outputFile = new StreamWriter("reservations.txt", false))
                {
                    //Write the header for this new file into the file
                    outputFile.WriteLine("CustomerName,NumberOfAdultTickets, NumberOfChildTickets, TotalCost");
                    //Write each customer details in the reservation list into the output file.
                    foreach (ConcertReservation item in AnyList)
                    {
                        outputFile.WriteLine(item.CustomerName + "," + item.NumberOfAdultTickets.ToString("F0") + "," + item.NumberOfChildTickets.ToString("F0") + "," +
                            item.TotalCost.ToString("F2"));
                    }
                    //Create a double variable to hold the output of the sum query which holds the grand total of all total costs of all customers in the list.
                    double grandTotal = (from item in SortedReservationList select item.TotalCost).Sum();
                    //Add to the end the grand total of total cost output
                    outputFile.WriteLine("Grand Total of TotalCost: " + grandTotal.ToString("C2"));
                }
            }
            //Identify and display an error message if the directory for this new file is not found
            catch (DirectoryNotFoundException dex)
            {
                MessageBox.Show("Directory Not Found: " + dex.Message);
            }
            //Identify and display an error message if any file error occurs
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
        }


    }



}
