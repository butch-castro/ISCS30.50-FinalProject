using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRP11_Castro_Jocson_FinalProject
{
    public partial class Form2 : Form
    {
        DataTable tableSource = new DataTable();
        string foodName, category;
        float servingSize, caloriesPerServing, proteinPerServing, fatPerServing, carbsPerServing;
        public Form2()
        {
            InitializeComponent();
            tableSource.Columns.Add("Food Name", typeof(string));
            tableSource.Columns.Add("Category", typeof(string));
            tableSource.Columns.Add("Serving Size", typeof(float));
            tableSource.Columns.Add("Calories", typeof(float));
            tableSource.Columns.Add("Protein", typeof(float));
            tableSource.Columns.Add("Fat", typeof(float));
            tableSource.Columns.Add("Carbs", typeof(float));

            dataGridView1.DataSource = tableSource;

            tableSource.Rows.Add("Rice", "Go", 100, 140, 10, 8, 20);
        }

        public void setUsername(String s)
        {
            usernameTextBox.Text = s;
        }

        public void setCurrentTime()
        {
            currentTimeTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            foodName = foodNameTextBox.Text;
            category = categoryTextBox.Text;
            servingSize = float.Parse(servingSizeTextBox.Text);
            caloriesPerServing = float.Parse(caloriesTextBox.Text);
            proteinPerServing = float.Parse(proteinTextBox.Text);
            fatPerServing = float.Parse(fatTextBox.Text);
            carbsPerServing = float.Parse(carbsTextBox.Text);

            tableSource.Rows.Add(foodName, category, servingSize, caloriesPerServing, proteinPerServing, fatPerServing, carbsPerServing);

            foodNameTextBox.Text = "";
            categoryTextBox.Text = "";
            servingSizeTextBox.Text = "";
            caloriesTextBox.Text = "";
            proteinTextBox.Text = "";
            fatTextBox.Text = "";
            carbsTextBox.Text = "";

            MessageBox.Show("Record has been added.", "", MessageBoxButtons.OK);
        }

        private void updateRecordBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record has been updated.", "", MessageBoxButtons.OK);
        }

        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record has been deleted.", "", MessageBoxButtons.OK);
        }

        private void clearFieldBtn_Click(object sender, EventArgs e)
        {
            foodNameTextBox.Text = "";
            categoryTextBox.Text = "";
            servingSizeTextBox.Text = "";
            caloriesTextBox.Text = "";
            proteinTextBox.Text = "";
            fatTextBox.Text = "";
            carbsTextBox.Text = "";
        }

        private void displayFromXMLBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void servingSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
