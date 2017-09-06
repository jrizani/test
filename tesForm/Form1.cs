using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace tesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connection = "";
        MySqlConnection con;
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            add Add = new add(this);
            Add.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "tes";
            connection = @"server="+server+";uid=root;database="+database+";port=3306;charset=utf8";
            string query = "SELECT s.nama, s.`No Hp`, s.email, d.alamat FROM user s LEFT JOIN alamat d ON d.namauser = s.nama WHERE s.Nama LIKE '%" + searchTxt.Text + "%'";
            
            SelectAllFrom(query, dataGridView1);
        }
        void SelectAllFrom(string query, DataGridView dgv)
        {

            try
            {
                dataSet11.DataTable1.Clear();
                con = new MySqlConnection(connection);
                con.Open();
                MySqlCommand _cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = query
                };
                _cmd.ExecuteNonQuery();

                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);
                _da.Fill(dataSet11.DataTable1);

                MySqlCommandBuilder _cb = new MySqlCommandBuilder(_da);

                dgv.DataSource = dataSet11.DataTable1;
                //dgv.DataMember = dataSet11.DataTable1.TableName;
                dgv.AutoResizeColumns();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
            }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add Add = new add(this);
            Add.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "tes";
            connection = @"server=" + server + ";uid=root;database=" + database + ";port=3306;charset=utf8"; 
            string query = "SELECT s.nama, s.`No Hp`, s.email, d.alamat FROM user s LEFT JOIN alamat d ON d.namauser = s.nama WHERE s.Nama LIKE '%" + searchTxt.Text + "%'";
            SelectAllFrom(query, dataGridView1);
        }
    }
}
