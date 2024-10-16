using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Compiler
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void stateDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private List<Contact> contacts = new List<Contact>();

        private void AddContact()
        {
            var contact = new Contact
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                State = stateComboBox.SelectedItem.ToString(),
                Email = emailTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text

            };

            contacts.Add(contact);
            UpdateContactListView();
            ClearInputFields();
        }


        private void UpdateContactListView()
        {
            contactListView.Items.Clear();
            foreach (var contact in contacts)
            {
                // Create new ListViewItem with contact's first and last name
                var listViewItem = new ListViewItem(contact.FirstName, contact.LastName);

                // add the other properties as sub-items
                listViewItem.SubItems.Add(contact.StreetAddress);
                listViewItem.SubItems.Add(contact.City);
                listViewItem.SubItems.Add(contact.State);
                listViewItem.SubItems.Add(contact.Email);
                listViewItem.SubItems.Add(contact.PhoneNumber);

                // add to ListView
                contactListView.Items.Add(listViewItem);
            }

        }

        private void ClearInputFields()
        {
            firstNameTextBox.Clear(); 
            lastNameTextBox.Clear();
            streetAddressTextBox.Clear();
            cityTextBox.Clear();
            stateComboBox.SelectedIndex = 0;
            emailTextBox.Clear();
            phoneNumberTextBox.Clear();

        }

      

        private void addButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }
    }
}
