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
using System.Net.Mail;

namespace tesForm
{
    public partial class add : Form
    {
        public static int angka = 0;
        Form a;
        public add(Form form)
        {
            InitializeComponent();
            a = form;
        }

        static Point loc = new Point();
        private void plusAlamat_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            Button btn = new Button();
            if (angka == 0)
            {
                angka = Convert.ToInt32(alamat1Txt.Name.Substring(alamat1Txt.Name.Length - 4, 1));
                loc = alamat1Txt.Location;
            }

            txt.Name = "alamat" + (angka++) + "Txt";
            txt.Width = 190;
            loc.Y += 40;
            txt.Location = new Point(loc.X, loc.Y);
            alamatPanel.Height += 40;
            this.Height += 40;
            alamatPanel.Controls.Add(txt);

            btn.Name = "min" + angka + "Btn";
            btn.Text = "-";
            btn.Height = 23;
            btn.Width = 29;
            btn.Location = new Point(193, loc.Y);
            alamatPanel.Controls.Add(btn);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (namaTxt.Text == "" || hpTxt.Text == "" || emailTxt.Text == "" || alamat1Txt.Text == "")
            {
                MessageBox.Show("Semua Field Harus Diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string server = "localhost";
                    string database = "tes";
                    string con = @"server=" + server + ";uid=root;database=" + database + ";port=3306;charset=utf8";
                    MySqlConnection connection = new MySqlConnection(con);
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO `User`(`Nama`, `No Hp`, `Email`) VALUES (?nama,?hp,?email)";
                    command.Parameters.AddWithValue("?nama", namaTxt.Text);
                    command.Parameters.AddWithValue("?hp", hpTxt.Text);
                    command.Parameters.AddWithValue("?email", new MailAddress(emailTxt.Text));

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    for (int i = 0; i < this.alamatPanel.Controls.Count; i++)
                    {
                        if (this.alamatPanel.Controls[i] is TextBox)
                        {
                            connection.Open();
                            TextBox txtserial = (TextBox)this.alamatPanel.Controls[i];
                            string value = txtserial.Text;

                            command.CommandText = "INSERT INTO `alamat`(`alamat`, `namauser`) VALUES ('"+value+"','"+namaTxt.Text+"')";
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    a.Show();
                    this.Hide();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void hpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
