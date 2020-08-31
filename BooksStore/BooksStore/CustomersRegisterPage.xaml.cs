using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BooksStore
{
    /// <summary>
    /// Interaction logic for CustomersRegisterPage.xaml
    /// </summary>
    public partial class CustomersRegisterPage : Window
    {
        public CustomersRegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            CustomersRegisterCheck registerCheck = new CustomersRegisterCheck(txtEmail.Text, txtName.Text, txtSurname.Text, txtIDCard.Text, txtAddress.Text);
            if (registerCheck.CheckNullOutput == false)
            {
                MessageBox.Show("Please fill all the form");
            }
            else if (registerCheck.CheckDoubleEmail == false)
            {
                MessageBox.Show("This Email is already used");
            }
            else if (registerCheck.EmailCheckCountOutput == false)
            {
                MessageBox.Show("Email cannot exceed 50 characters");
            }
            else if (registerCheck.NameCheckCountOutput == false)
            {
                MessageBox.Show("Name cannot exceed 30 characters");
            }
            else if (registerCheck.SurnameCheckCountOutput == false)
            {
                MessageBox.Show("Last name cannot exceed 30 characters");
            }
            else if (registerCheck.IDCardCheckCountOutput == false)
            {
                MessageBox.Show("ID number must be 13 digits");
            }
            else if (registerCheck.AddressCheckCountOutput == false)
            {
                MessageBox.Show("Address cannot exceed 300 characters");
            }
            else
            {
                CustomersRegisterSystem customersRegister = new CustomersRegisterSystem(txtEmail.Text, txtName.Text, txtSurname.Text, txtIDCard.Text, txtAddress.Text);
                MessageBox.Show("Registeration Complete");
                this.Close();
            }
        }
    }
}
