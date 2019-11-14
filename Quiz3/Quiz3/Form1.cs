using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3 {
    public partial class Form1 : Form {
        FileIO fileIO = new FileIO();
        public Form1() {
            InitializeComponent();
        }

        private void ownerRadioButton_CheckedChanged(object sender, EventArgs e) {

            //Disable Owner group box if Owner radio button not checked
            if (!ownerRadioButton.Checked) {
                ownerGroup.Enabled = false;
            }

            else {
                ownerGroup.Enabled = true;
            }
        }

        private void carRadioButton_CheckedChanged(object sender, EventArgs e) {

            //Disable Car group box if Car radio button not checked
            if (!carRadioButton.Checked) {
                carRegistrationGroup.Enabled = false;
            }

            else {
                carRegistrationGroup.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e) {
            //Car Group Box fields clear
            makeComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;

            //Owner Group Box fields clear
            firstNameTxtBox.Clear();
            lastNameTxtBox.Clear();
            telephoneTxtBox.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            ownerGroup.Enabled = false;
            yearComboBox.Items.Add("2020");
            yearComboBox.Items.Add("2019");
            yearComboBox.Items.Add("2018");
        }

        private void makeComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            //Clear model info once Make index changed
            modelComboBox.SelectedIndex = -1;
            modelComboBox.Items.Clear();

            //Variables to store indexes of car makes
            int toyotaMake = 0;
            int hondaMake = 1;
            int hyundaiMake = 2;

            //Based on selected index, model combo box is populated with different values
            //-------- Check starts --------//
            if(makeComboBox.SelectedIndex == toyotaMake) {
                modelComboBox.Items.Add("Corolla");
                modelComboBox.Items.Add("Camry");
                modelComboBox.Items.Add("Prius");

            }

            if (makeComboBox.SelectedIndex == hondaMake) {
                modelComboBox.Items.Add("Civic");
                modelComboBox.Items.Add("Accord");
                modelComboBox.Items.Add("Odyssey");

            }

            if (makeComboBox.SelectedIndex == hyundaiMake) {
                modelComboBox.Items.Add("Elantra");
                modelComboBox.Items.Add("Accent");
                modelComboBox.Items.Add("Sonata");

            }

            //-------- Check Ends --------//
        }

        private void saveButton_Click(object sender, EventArgs e) {

            //Empty string variable
            String empty = String.Empty;

            //Storing textbox values into string variables
            string firstName = firstNameTxtBox.Text;
            string lastName = lastNameTxtBox.Text;
            string telephone = telephoneTxtBox.Text;

            //Storing current selected indexes from comboBoxes
            int carMakeIndex = makeComboBox.SelectedIndex;
            int carModelIndex = modelComboBox.SelectedIndex;
            int carYearIndex = yearComboBox.SelectedIndex;

            //Validation check for empty fields
            if (firstName != empty &&
                lastName != empty &&
                telephone != empty &&
                carMakeIndex != -1 &&
                carModelIndex != - 1 &&
                carYearIndex != -1) {

                //Opening a save Dialog
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.OverwritePrompt = false;
                DialogResult result = SaveFileDialog1.ShowDialog();

                //Storing filepath for saveToFile Method + string content
                string filePath = SaveFileDialog1.FileName;
                string content = "Owner: " + firstName + " " + lastName + "\nTelephone Number: " + telephone
                                            + "\nMake: " + makeComboBox.SelectedItem.ToString() + "\nModel: " + modelComboBox.SelectedItem.ToString()
                                            + "\nYear: " + yearComboBox.SelectedItem.ToString() + "\n";  

                //If user clicks on save, call SaveToFile method from FileIO class
                if(result == DialogResult.OK) {
                    fileIO.SaveToFile(content, filePath);
                    MessageBox.Show("File was saved!");
                }
            }

            //Validation failure message
            else {
                MessageBox.Show("Please fill out all fields!");
            }
        }
    }
}
