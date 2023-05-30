using System.Data.SqlClient;
using System.Data;

namespace pr26
{
    public partial class Form1 : Form
    {
        public SqlConnection connection = new SqlConnection();
        public string connectionString = @"Data Source=DESKTOP-O0BVAQ1\MSSQLSERVER01;Initial Catalog=ComputerClub;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        public void update()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM LogIn";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            update();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                string query = $"INSERT INTO LogIn (Login, Password) SELECT '{textBox1.Text}','{textBox2.Text}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = $"UPDATE LogIn SET Login = '{textBox1.Text}', Password = '{textBox2.Text}' WHERE ID = {dataGridView1.SelectedRows[0].Cells[0].Value}";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = $"DELETE FROM LogIn WHERE ID = {dataGridView1.SelectedRows[0].Cells[0].Value}";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}