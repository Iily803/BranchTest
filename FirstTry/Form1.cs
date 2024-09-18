using System.Data.SqlClient;
namespace FirstTry
{
    public partial class Form1 : Form
    {
        //string str = "server=localhost;database=first;uid=root;pwd=123456";
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butTestCon_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("server=localhost;database=first;uid=root;pwd=123456");
            try {
                sqlCon.Open();
                MessageBox.Show("连接成功");
            }
            catch (Exception)
            {
                MessageBox.Show("连接失败" + sqlCon);
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
