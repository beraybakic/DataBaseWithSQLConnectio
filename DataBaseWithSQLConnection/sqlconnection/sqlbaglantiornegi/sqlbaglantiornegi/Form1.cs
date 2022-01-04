using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sqlbaglantiornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=uyeler;Integrated Security=True");

        private void verileriGoster()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from KisiBilgisi", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = oku["KisiID"].ToString();
                satir.SubItems.Add(oku["ad"].ToString());
                satir.SubItems.Add(oku["soyad"].ToString());
                satir.SubItems.Add(oku["yas"].ToString());
                satir.SubItems.Add(oku["ilce"].ToString());
                satir.SubItems.Add(oku["meslek"].ToString());
                listView1.Items.Add(satir);
            }
            conn.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from KisiBilgisi", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verileriGoster();
        }

        private void filtrele()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from KisiBilgisi where ad like '" + textBox1.Text + "%'", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem satir = new ListViewItem();
                satir.Text = oku["KisiID"].ToString();
                satir.SubItems.Add(oku["ad"].ToString());
                satir.SubItems.Add(oku["soyad"].ToString());
                satir.SubItems.Add(oku["yas"].ToString());
                satir.SubItems.Add(oku["ilce"].ToString());
                satir.SubItems.Add(oku["meslek"].ToString());
                listView1.Items.Add(satir);
            }
            conn.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            filtrele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uyelerDataSet.KisiBilgisi' table. You can move, or remove it, as needed.
            this.kisiBilgisiTableAdapter.Fill(this.uyelerDataSet.KisiBilgisi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand command2 = new SqlCommand("update KisiBilgisi set ad='" + textBox2.Text + "', soyad='" + textBox3.Text + "', yas='" + textBox4.Text + "', ilce='" + comboBox1.GetItemText(comboBox1.SelectedItem) + "', meslek='" + comboBox2.GetItemText(comboBox2.SelectedItem) + "' where KisiID =" + id, conn);
            command2.ExecuteNonQuery();
            conn.Close();
            verileriGoster();
        }
        string id = "", ad = "", soyad = "", yas = "", ilce = "", meslek = "";

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command3 = new SqlCommand("delete from KisiBilgisi where ad=@ad", conn);
            command3.Parameters.AddWithValue("@ad", textBox2.Text);
            command3.ExecuteNonQuery();
            conn.Close();
            verileriGoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand command1 = new SqlCommand("insert into KisiBilgisi (ad,soyad,yas,ilce,meslek) values (@ad,@soyad,@yas,@ilce,@meslek)", conn);
            command1.Parameters.AddWithValue("@ad", textBox2.Text);
            command1.Parameters.AddWithValue("@soyad", textBox3.Text);
            command1.Parameters.AddWithValue("@yas", textBox4.Text);
            command1.Parameters.AddWithValue("@ilce", comboBox1.GetItemText(comboBox1.SelectedItem));
            command1.Parameters.AddWithValue("@meslek", comboBox2.GetItemText(comboBox2.SelectedItem));
            command1.ExecuteNonQuery();
            dataGridView1.Refresh();
            conn.Close();
            verileriGoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir_no = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[satir_no].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[satir_no].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[satir_no].Cells[2].Value.ToString();
            yas = dataGridView1.Rows[satir_no].Cells[3].Value.ToString();
            ilce = dataGridView1.Rows[satir_no].Cells[4].Value.ToString();
            meslek = dataGridView1.Rows[satir_no].Cells[5].Value.ToString();
            textBox2.Text = ad;
            textBox3.Text = soyad;
            textBox4.Text = yas;
            comboBox1.Text = ilce;
            comboBox2.Text = meslek;
        }
    }
}
