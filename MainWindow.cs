using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRP11_Castro_Jocson_FinalProject {
  public partial class MainWindow : Form {
    DataTable tableSource = new DataTable();
    DataGridViewRow selectedRow;
    Timer timer;
    string foodName, category;
    float servingSize, caloriesPerServing, proteinPerServing, fatPerServing, carbsPerServing;

    List<TextBox> textBoxes = new List<TextBox>(7);

    public MainWindow() {
      InitializeComponent();

      textBoxes.Add(foodNameTextBox);
      textBoxes.Add(categoryTextBox);
      textBoxes.Add(servingSizeTextBox);
      textBoxes.Add(caloriesTextBox);
      textBoxes.Add(proteinTextBox);
      textBoxes.Add(fatTextBox);
      textBoxes.Add(carbsTextBox);

      tableSource.Columns.Add("Food Name", typeof(string));
      tableSource.Columns.Add("Category", typeof(string));
      tableSource.Columns.Add("Serving Size", typeof(float));
      tableSource.Columns.Add("Calories", typeof(float));
      tableSource.Columns.Add("Protein", typeof(float));
      tableSource.Columns.Add("Fat", typeof(float));
      tableSource.Columns.Add("Carbs", typeof(float));

      dataGridView1.DataSource = tableSource;

      tableSource.Rows.Add("Rice", "Go", 100, 140, 10, 8, 20);

      currentTimeTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
      timer = new Timer();
      timer.Interval = 1000;
      timer.Tick += UpdateTime;
      timer.Start();
    }

    public void setUsername(String s) {
      usernameTextBox.Text = s;
    }

    public void UpdateTime(object sender, EventArgs e) {
      currentTimeTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }

    private void usernameTextBox_TextChanged(object sender, EventArgs e) {

    }

    private void addRecordBtn_Click(object sender, EventArgs e) {
      if (!FieldsAreComplete()) return;

      foodName = foodNameTextBox.Text;
      category = categoryTextBox.Text;
      servingSize = float.Parse(servingSizeTextBox.Text);
      caloriesPerServing = float.Parse(caloriesTextBox.Text);
      proteinPerServing = float.Parse(proteinTextBox.Text);
      fatPerServing = float.Parse(fatTextBox.Text);
      carbsPerServing = float.Parse(carbsTextBox.Text);

      tableSource.Rows.Add(foodName, category, servingSize, caloriesPerServing, proteinPerServing, fatPerServing, carbsPerServing);

      ClearFields();

      MessageBox.Show("Record has been added.", "", MessageBoxButtons.OK);
    }

    private void updateRecordBtn_Click(object sender, EventArgs e) {
      if (!FieldsAreComplete()) return;

      MessageBox.Show("Record has been updated.", "", MessageBoxButtons.OK);
    }

    private void deleteRecordBtn_Click(object sender, EventArgs e) {
      if (dataGridView1.SelectedRows.Count < 1) return;

      selectedRow = dataGridView1.SelectedRows[0];
      dataGridView1.Rows.Remove(selectedRow);

      MessageBox.Show("Record has been deleted.", "", MessageBoxButtons.OK);
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      selectedRow = dataGridView1.SelectedRows[0];

      for (int i = 0; i < textBoxes.Count; ++i) {
        textBoxes[i].Text = selectedRow.Cells[i].Value.ToString();
      }
    }

    private void clearFieldBtn_Click(object sender, EventArgs e) {
      ClearFields();
    }

    private void displayFromXMLBtn_Click(object sender, EventArgs e) {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void servingSizeTextBox_TextChanged(object sender, EventArgs e) {

    }

    private void ClearFields() {
      foreach (TextBox textBox in textBoxes) {
        textBox.Clear();
      }
    }

    private bool FieldsAreComplete() {
      foreach (TextBox textBox in textBoxes) {
        if (textBox.Text.Length < 1) return false;
      }
      return true;
    }
  }
}
