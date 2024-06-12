using SQLDataForm.BaseModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace SQLDataForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseClass.Initialize();
            dataGridView1.DataSource = BaseClass._dt;

        }

        private void _bind_DataSourceChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                BaseClass.TestConnection();
                BaseClass.Insert(field_Name.Text, float.Parse(field_Price.Text), field_Supplier.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"DELETE ERROR:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DELETE EXCEPTION:{ex.Message}");
            }




        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                BaseClass.Delete(field_Name.Text, float.Parse(field_Price.Text), field_Supplier.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"DELETE ERROR:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DELETE EXCEPTION:{ex.Message}");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                BaseClass.Update(field_Name.Text, float.Parse(field_Price.Text), field_Supplier.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"UPDATE ERROR:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"UPDATE EXCEPTION:{ex.Message}");
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            try
            {

                BaseClass.Filter(field_Name.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"FILTER ERROR:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FILTER EXCEPTION:{ex.Message}");
            }
        }
    }
}
