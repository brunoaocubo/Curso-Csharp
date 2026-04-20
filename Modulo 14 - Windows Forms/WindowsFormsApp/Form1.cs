using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();

            string[] listCivilState = { "Solteiro", "Casado", "Divorciado", "União Estável" };
            civilState.Items.AddRange(listCivilState);
            civilState.SelectedIndex = 0;
        }

        private char sexSelected()
        {
            char sexSelected = 's';
            RadioButton[] checkedSex = { M, F, O };

            foreach (var item in checkedSex)
            {
                if (item.Checked)
                {
                    sexSelected = Convert.ToChar(item.Name);
                }
            }
            return sexSelected;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Insira um nome válido:");
                name.Focus();
                return;
            }

            if(telNumber.Text.Length < 11)
            {
                MessageBox.Show("Insira um número de telefone válido:");
                telNumber.Focus();
                return;
            }

            int index = -1;

            foreach (Person person in people)
            {
                if (person.name == name.Text)
                {
                    index = people.IndexOf(person);
                }
            }

            Person newPerson = new Person()
            {
                name = name.Text,
                bornDate = bornDate.Text,
                civilState = civilState.SelectedItem.ToString(),
                telNumber = telNumber.Text,
                house = checkHouse.Checked,
                vehicle = checkVehicle.Checked,
                sex = sexSelected()
            };

            if(index < 0)
            {
                people.Add(newPerson);
            }
            else
            {
                people[index] = newPerson;
            }

            btnClear_Click(btnClear, EventArgs.Empty);
            UpdateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            people.RemoveAt(listRegisters.SelectedIndex);
            //people.RemoveAll(n => n.name == listRegisters.SelectedItem.ToString());
            UpdateList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {  
            name.Text = "";
            bornDate.Text = "";
            civilState.SelectedIndex = 0;
            telNumber.Text = "";
            checkHouse.Checked = false;
            checkVehicle.Checked = false;
            name.Focus();
        }

        private void UpdateList()
        {
            listRegisters.Items.Clear();

            foreach (Person item in people)
            {
                if (item != null)
                {
                    listRegisters.Items.Add(item.name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void listRegisters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Person selectedPerson = people[listRegisters.SelectedIndex];
            name.Text = selectedPerson.name;
            bornDate.Text = selectedPerson.bornDate;
            civilState.SelectedItem = selectedPerson.civilState;
            telNumber.Text = selectedPerson.telNumber;
            checkHouse.Checked = selectedPerson.house;
            checkVehicle.Checked = selectedPerson.vehicle;
            RadioButton[] checkedSex = { M, F, O };
            foreach (RadioButton item in checkedSex)
            {
                char sex = Convert.ToChar(item.Name);
                if (sex == selectedPerson.sex)
                {
                    item.Checked = true;
                }
            }
        }
    }
}
