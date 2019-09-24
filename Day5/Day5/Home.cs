using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public partial class Home : Form
    {
        Boolean input = false;
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<string> age = new List<string> { };
        List<string> address = new List<string> { };
        List<string> gpa = new List<string> { };
        string message = "";
        int count = 0;

        public Home()
        {
            InitializeComponent();
            DisableButtons();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
=======
            input = Information();
            GetData();

            UncheckRadioButton();


        }
        private void Input()
        {
            Information();
            if(input)
            {
                id.Add(idTextBox.Text);
                name.Add(nameTextBox.Text);
                mobile.Add(mobileTextBox.Text);
                age.Add(ageTextBox.Text);
                address.Add(addressTextBox.Text);
                gpa.Add(gpaPointTextBox.Text);

                ClearInput();
            }
        }

        private Boolean Information()
        {
            if (input == false)
            {
                if (idTextBox.Text.Length < 4 || idTextBox.Text == "" || id.Contains(idTextBox.Text))
                {
                    if (idTextBox.Text.Length < 4)
                    {
                        MessageBox.Show("Id must be 4 character");

                    }
                    else if (idTextBox.Text == "")
                    {
                        MessageBox.Show("Id must be filled");
                    }
                    else if (id.Contains(idTextBox.Text))
                    {
                        MessageBox.Show("Id is not available");
                    }

                }
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Name can not be empty!!!");
                }

                if (mobileTextBox.Text.Length < 11 || mobileTextBox.Text == "" || id.Contains(mobileTextBox.Text))
                {
                    if (mobileTextBox.Text.Length < 11)
                    {
                        MessageBox.Show("Mobile number must be 11 number");

                    }
                    else if (mobileTextBox.Text == "")
                    {
                        MessageBox.Show("Mobile number must be filled");
                    }
                    else if (id.Contains(mobileTextBox.Text))
                    {
                        MessageBox.Show("Mobile number already exist");
                    }

                }
                return true;
            }
            return input;
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckNameInput(e);
        }

        private void mobileNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckAgeInput(e);
        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckAgeInput(e);
        }

        private void gpaPointTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckGpaInput(e);
>>>>>>> 1a91dc8091b72826d477c0eed295157cb1807f1a
        }

        private void CheckNameInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Name input only alphabetic characters");

            }
        }
        private void CheckAgeInput(KeyPressEventArgs e)
        {
<<<<<<< HEAD
            
            
        }
        Boolean check = false;
        
=======
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Input only numbers");
            }
        }
        private void CheckGpaInput(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Input valid Gpa Point");
            }
        }
        private void ClearInput()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaPointTextBox.Text = "";
        }
        
        private void Calculation()
        {
            MaxGPA();
            MinGPA();
            AvgGPA();
            TotalGPA();

        }
        private double TotalGPA()
        {
            double sum = 0;
            for (int i = 0; i < id.Count; i++)
            {
                sum += double.Parse(gpa[i]);
            }
            totalTextBox.Text = sum + " ";

            return sum;
        }
        private void AvgGPA()
        {
            double sum = TotalGPA();
            double avg = sum / id.Count;

            avgTextBox.Text = avg.ToString("##.##");
        }
        private void MinGPA()
        {
            try
            {
                String name = "";
                double min = double.Parse(gpa.Min());
                minTextBox.Text = min + "";
                for (int i = 0; i < id.Count; i++)
                {
                    if (min == double.Parse(gpa[i]))
                    {
                        name += name[i] + ", ";
                    }
                }
                minNameTextBox.Text = name;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void MaxGPA()
        {
            try
            {
                String name = "";
                double max = double.Parse(gpa.Max());
                maxTextBox.Text = max + "";
                for (int i = 0; i < id.Count; i++)
                {
                    if (max == double.Parse(gpa[i]))
                    {
                        name += name[i] + ", ";
                    }
                }
                maxNameTextBox.Text = name;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (idRadioButton.Checked)
            {
                if (!idTextBox.Text.Equals(""))
                {
                    String information = "";
                    for (int i = 0; i < id.Count; i++)
                    {
                        if (idTextBox.Text == id[i])
                        {
                            information += "ID: " + id[i] +
                                            "\nName: " + name[i] +
                                            "\nMobile: " + mobile[i] +
                                            "\nAge: " + age[i] +
                                            "\nAddress: " + address[i] +
                                            "\nGPA: " + gpa[i] +
                                            "\n\n";
                        }
                    }
                    if (information.Equals(""))
                    {
                        MessageBox.Show("No data found using given ID !!");
                        richTextBox.Text = "";
                    }
                    else
                    {
                        richTextBox.Text = information;
                        MessageBox.Show("Data Found!!");
                    }
                }
                else
                {
                    MessageBox.Show("Input ID number");
                }
            }
            else if (nameRadioButton.Checked)
            {
                if (!nameTextBox.Text.Equals(""))
                {
                    String information = "";
                    for (int i = 0; i < id.Count; i++)
                    {
                        if (nameTextBox.Text == name[i])
                        {
                            information += "ID: " + id[i] +
                                            "\nName: " + name[i] +
                                            "\nMobile: " + mobile[i] +
                                            "\nAge: " + age[i] +
                                            "\nAddress: " + address[i] +
                                            "\nGPA: " + gpa[i] +
                                            "\n\n";
                        }
                    }
                    if (information.Equals(""))
                    {
                        MessageBox.Show("No data found using given Name !!");
                        richTextBox.Text = "";
                    }
                    else
                    {
                        richTextBox.Text = information;
                        MessageBox.Show("Data Found !!");
                    }
                }
                else
                {
                    MessageBox.Show("Input a name");
                }
            }
            else if (mobileRadioButton.Checked)
            {
                if (!mobileTextBox.Text.Equals(""))
                {
                    String information = "";
                    for (int i = 0; i < id.Count; i++)
                    {
                        if (mobileTextBox.Text == name[i])
                        {
                            information += "ID: " + id[i] +
                                            "\nName: " + name[i] +
                                            "\nMobile: " + mobile[i] +
                                            "\nAge: " + age[i] +
                                            "\nAddress: " + address[i] +
                                            "\nGPA: " + gpa[i] +
                                            "\n\n";
                        }
                    }
                    if (information.Equals(""))
                    {
                        MessageBox.Show("No data found using given Mobile !!");
                        richTextBox.Text = "";
                    }
                    else
                    {
                        richTextBox.Text = information;
                        MessageBox.Show("Data Found !!");

                    }

                }
                else
                {
                    MessageBox.Show("Input a mobile number");
                }
            }
            else
            {
                MessageBox.Show("Check a button first!");
            }

            ClearInput();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllInformation();
            Calculation();
            ClearInput();

            UncheckRadioButton();

        }
        private void UncheckRadioButton()
        {
            idRadioButton.Checked = false;
            nameRadioButton.Checked = false;
            mobileRadioButton.Checked = false;
        }
        private void GetData()
        {
            try
            {
                if (input)
                {
                    id.Add(idTextBox.Text);
                    name.Add(nameTextBox.Text);
                    mobile.Add(mobileTextBox.Text);
                    age.Add(ageTextBox.Text);
                    address.Add(addressTextBox.Text);
                    gpa.Add(gpaPointTextBox.Text);

                    count++;
                    SetData();
                    ClearInput();

                    MessageBox.Show("Information added successfully.");

                    EnableButtons();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void SetData()
        {
            try
            {
                String message = "Student Number: " + count +
                        "\nID: " + idTextBox.Text +
                        "\nName: " + nameTextBox.Text +
                        "\nMobile: " + mobileTextBox.Text +
                        "\nAge: " + ageTextBox.Text +
                        "\nAddress: " + addressTextBox.Text +
                        "\nGPA: " + gpaPointTextBox.Text;

                richTextBox.Text = message;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void DisableButtons()
        {
            showButton.Enabled = false;
            searchButton.Enabled = false;
        }
        private void EnableButtons()
        {
            showButton.Enabled = true;
            searchButton.Enabled = true;
        }
        private void ShowAllInformation()
        {
            String message = "";
            try
            {
                if (!(id.Count == 0))
                {
                    for (int i = 0; i < id.Count; i++)
                    {
                        message += "Student: " + (i + 1) +
                        "\nID: " + id[i] +
                        "\nName: " + name[i] +
                        "\nMobile: " + mobile[i] +
                        "\nAge: " + age[i] +
                        "\nAddress: " + address[i] +
                        "\nGPA: " + gpa[i] +
                        "\n\n";
                    }
                    richTextBox.Text = message;
                }
                else
                {
                    MessageBox.Show("No data found!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

>>>>>>> 1a91dc8091b72826d477c0eed295157cb1807f1a
    }


}

