using System.Data;
using System.Data.SqlClient;

namespace ClientCRUD

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=MALEEK\\SQLEXPRESS;Initial Catalog=clientCRUD;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand command = new SqlCommand("insert into clientTable values ('" + int.Parse(idTxt.Text) + "','" + fnameTxt.Text + "','" + lnameTxt.Text + "','" + phoneTxt.Text + "','" + addressTxt.Text + "')", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Client Created successfully!!");
            conn.Close();
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from clientTable", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update clientTable set firstName = '" + fnameTxt.Text + "',lastName = '" + lnameTxt.Text + "',phoneNumber = '" + phoneTxt.Text + "',address= '" + addressTxt.Text + "' where ID ='" + int.Parse(idTxt.Text) + "'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Client updated Successfully!!");
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idTxt.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to Delete", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("delete clientTable where ID ='" + int.Parse(idTxt.Text) + "'", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Client Successfully Deleted!!");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Enter client Id");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from clientTable where id = '"+ int.Parse(idTxt.Text) + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
