//Author: Josh Werlein
//Purpose: Create an application with 3 classes of Philospher Dog and Car
//Date: 9/20/2023

using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics;

namespace PhilosopherDogCar_List
{
    public partial class PhilosopherDogCarListForm : Form
    {
        public PhilosopherDogCarListForm()
        {
            InitializeComponent();
        }

        // Class level Object - Binding List
        private BindingList<PhilosopherDogCar_List.Car> carList = new BindingList<PhilosopherDogCar_List.Car>();
        private BindingList<PhilosopherDogCar_List.Dog> dogList = new BindingList<PhilosopherDogCar_List.Dog>();
        private BindingList<PhilosopherDogCar_List.Philosopher> philosopherList = new BindingList<PhilosopherDogCar_List.Philosopher>();

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Class", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void CarCreateButton_Click(object sender, EventArgs e)
        {
            //Validate all data in Textboxes
            if (string.IsNullOrEmpty(carMakeTextBox.Text) || !carMakeTextBox.Text.All(char.IsLetter))
            {
                Msg("Car Make can not be blank and can only contain letters.");
                carMakeTextBox.Focus();
                return;
            }
            else if ((carModelTextBox.Text ?? "") == (string.Empty))
            {
                Msg("Car Model can not be blank.");
                carModelTextBox.Focus();
                return;
            }
            else
            {
                //Declare Objects and Variables
                var carObject = new PhilosopherDogCar_List.Car(carMakeTextBox.Text);

                //Assign Car Properties
                carObject.Make = carMakeTextBox.Text;
                carObject.Model = carModelTextBox.Text;
                carObject.Color = carColorComboBox.Text;

                //Add new customer object to list of customers
                carList.Add(carObject);

                //Display the message box for the newly added car object
                DisplaySelectedObjectDescription(carObject);

                //Reset labels
                ClearLabels();

                //Focus on car make textBox
                carMakeTextBox.Focus();
            }
        }

        private void DogCreateButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            decimal valueDEC;

            //Validate all data in Textboxes
            if (string.IsNullOrEmpty(dogBreedTextBox.Text) || !dogBreedTextBox.Text.All(char.IsLetter))
            {
                Msg("Dog Breed can not be blank and can only contain letters.");
                dogBreedTextBox.Focus();
                return;
            }
            else if (decimal.TryParse(dogWeightTextBox.Text, out valueDEC) == false)
            {
                Msg("Dog weight must be a Decimal.");
                dogWeightTextBox.Focus();
                return;
            }
            else
            {
                //Declare Objects and Variables
                var dogObject = new PhilosopherDogCar_List.Dog(dogBreedTextBox.Text);

                //Assign Car Properties
                dogObject.Breed = dogBreedTextBox.Text;
                dogObject.Weight = dogWeightTextBox.Text;
                dogObject.Color = dogColorComboBox.Text;

                //Add new customer object to list of customers
                dogList.Add(dogObject);

                //Display the message box for the newly added car object
                DisplaySelectedObjectDescription(dogObject);

                //Reset Labels
                ClearLabels();

                //Focus on dog breed textBox
                dogBreedTextBox.Focus();
            }
        }

        private void PhilosopherCreateButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            DateTime valueDAT;

            //Validate all data in Textboxes
            if (string.IsNullOrEmpty(philosopherNameTextBox.Text) || !philosopherNameTextBox.Text.All(char.IsLetter))
            {
                Msg("Philosopher Name can not be blank and can only contain letters.");
                philosopherNameTextBox.Focus();
                return;
            }
            else if ((philosopherQuoteTextBox.Text ?? "") == (string.Empty))
            {
                Msg("Philosopher Quote can not be blank.");
                philosopherQuoteTextBox.Focus();
                return;
            }
            else if (DateTime.TryParse(philosopherDateTimePicker.Text, out valueDAT) == false)
            {
                return;
            }
            else
            {
                //Declare Objects and Variables
                var philosopherObject = new PhilosopherDogCar_List.Philosopher(philosopherNameTextBox.Text);

                //Assign Car Properties
                philosopherObject.Name = philosopherNameTextBox.Text;
                philosopherObject.Quote = philosopherQuoteTextBox.Text;
                philosopherObject.Date = valueDAT;

                //Add new customer object to list of customers
                philosopherList.Add(philosopherObject);

                //Display the message box for the newly added car object
                DisplaySelectedObjectDescription(philosopherObject);

                //Reset Labels
                ClearLabels();

                //Focus on dog breed textBox
                philosopherNameTextBox.Focus();
            }
        }

        private void PhilosopherDogCarList_Load(object sender, EventArgs e)
        {
            //Set the cursor to carMakeTextBox
            carMakeTextBox.Focus();

            //Only allow items in the drop down menu to be selected
            carColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dogColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Add Color to ComboBox's on load
            this.carColorComboBox.Items.Add("Red");
            this.carColorComboBox.Items.Add("Blue");
            this.carColorComboBox.Items.Add("Green");
            this.carColorComboBox.Items.Add("Yellow");
            this.carColorComboBox.Items.Add("Brown");
            this.carColorComboBox.Items.Add("Silver");
            this.carColorComboBox.Items.Add("Tan");
            this.carColorComboBox.Items.Add("White");
            this.carColorComboBox.Items.Add("Black");
            this.dogColorComboBox.Items.Add("Red");
            this.dogColorComboBox.Items.Add("White");
            this.dogColorComboBox.Items.Add("Black");
            this.dogColorComboBox.Items.Add("Brown");
            this.dogColorComboBox.Items.Add("Gold");
            this.dogColorComboBox.Items.Add("Tan");
            this.dogColorComboBox.Items.Add("Grey");

            //Select color in the comboBox on load
            this.carColorComboBox.SelectedIndex = 0;
            this.dogColorComboBox.SelectedIndex = 0;

            //Connect Listbox properties to the Binding List object
            carListBox.DataSource = carList;
            carListBox.DisplayMember = "Make";
            dogListBox.DataSource = dogList;
            dogListBox.DisplayMember = "Breed";
            philosopherListBox.DataSource = philosopherList;
            philosopherListBox.DisplayMember = "Name";

            ClearLabels();
        }

        private void DisplaySelectedObjectDescription(object selectedObject)
        {
            //Check if the selected object is of type Car
            if (selectedObject is PhilosopherDogCar_List.Car carObject)
            {
                MessageBox.Show(carObject.GetCarDescription(), "Selected Car");
            }
            //Check if the selected object is of type Dog
            else if (selectedObject is PhilosopherDogCar_List.Dog dogObject)
            {
                MessageBox.Show(dogObject.GetDogDescription(), "Selected Dog");
            }
            //Check if the selected object is of type philosopher
            else if (selectedObject is PhilosopherDogCar_List.Philosopher philosopherObject)
            {
                MessageBox.Show(philosopherObject.Philosophize(), "Selected Philosopher");
            }
        }

        private void CarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected object in carListBox
            var selectedObject = carListBox.SelectedItem;

            //Display the selected object's description in a message box
            DisplaySelectedObjectDescription(selectedObject);
        }

        private void DogListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected object in dogListBox
            var selectedObject = dogListBox.SelectedItem;

            //Display the selected object's description in a message box
            DisplaySelectedObjectDescription(selectedObject);
        }

        private void PhilosopherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected object in philosopherListBox
            var selectedObject = philosopherListBox.SelectedItem;

            //Display the selected object's description in a message box
            DisplaySelectedObjectDescription(selectedObject);
        }

        private void ClearLabels()
        {
            //Clears Text Boxes of input
            this.carMakeTextBox.Text = string.Empty;
            this.carModelTextBox.Text = string.Empty;
            this.dogBreedTextBox.Text = string.Empty;
            this.dogWeightTextBox.Text = string.Empty;
            this.philosopherNameTextBox.Text = string.Empty;
            this.philosopherQuoteTextBox.Text = string.Empty;

            //Sets the first value of the comboBoxes
            this.dogColorComboBox.SelectedIndex = 0;
            this.carColorComboBox.SelectedIndex = 0;

            //Sets the date to today
            philosopherDateTimePicker.Value = DateTime.Today;
        }
    }
}