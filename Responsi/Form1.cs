using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public const string conn = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=hr_uas";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable table;
        private DataGridViewRow _row;

        //public DataTable table;
        //public DataGridViewRow row;

        private KaryawanRepository krw;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(conn);
        }

        public void btInsert_Click(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                string sql = @"SELECT * FROM kar_insert(:_name, :_dep)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_name", tbKaryawan.Text);
                cmd.Parameters.AddWithValue("_dep", cbDep.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil masuk");
                    tbKaryawan.Text = null;
                    cbDep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); 
            btLoad.PerformClick();
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                dgvData.DataSource = null;

                table = new DataTable();
                string sql = "SELECT * FROM kar_select()";
                cmd = new NpgsqlCommand(sql, connection);

                NpgsqlDataReader r = cmd.ExecuteReader();
                table.Load(r);
                dgvData.DataSource = table;
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(conn);
            if (_row == null)
            {
                MessageBox.Show("Pilih data yg akan diubah");
            }
            try
            {
                connection.Open();
                string sql = @"SELECT * FROM kar_update(:_id, :_name; :_dep)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", _row.Cells["_idkaryawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", tbKaryawan);
                cmd.Parameters.AddWithValue("_dep", cbDep);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil update");
                    connection.Close();
                    btLoad.PerformClick();
                    tbKaryawan.Text = null;
                    cbDep.Text = null;
                    _row = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvData_cellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        }

        private void dgvData_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _row = dgvData.Rows[e.RowIndex];
                tbKaryawan.Text = _row.Cells["_nama"].Value.ToString();
                cbDep.Text = _row.Cells["_namadep"].Value.ToString();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(conn);
            if (_row == null)
            {
                MessageBox.Show("Pilih data dulu");
            }
            try
            {
                connection.Open();
                string sql = @"SELECT * FROM kar_delete(:_id)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", _row.Cells["_idkaryawan"].Value.ToString);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil menghapus");
                    tbKaryawan.Text = null;
                    cbDep.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }
    }
}