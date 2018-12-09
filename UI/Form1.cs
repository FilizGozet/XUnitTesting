using Examples.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        List<PersonModel> people;
        public Form1()
        {
            InitializeComponent();

            RebindDropdown();
        }

        private void RebindDropdown()
        {
            people = DataAccess.GetAllPeople();
            usersDropdown.DataSource = null;
            usersDropdown.DataSource = people;
            usersDropdown.DisplayMember = "FullName";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            resultsText.Text = Calculator.Add((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            resultsText.Text = Calculator.Subtract((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            resultsText.Text = Calculator.Multiply((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            resultsText.Text = Calculator.Divide((double)firstNumberValue.Value, (double)secondNumberValue.Value).ToString();
            firstNumberValue.Value = 0;
            secondNumberValue.Value = 0;
        }

        //add person
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new PersonModel { FirstName = firstNameText.Text, LastName = lastNameText.Text });

            firstNameText.Text = "";
            lastNameText.Text = "";

            RebindDropdown();
        }
    }
}
