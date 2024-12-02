using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Responsi
{
    internal class KaryawanRepository : Karyawan
    {
        public const string conn = "Host=localhost;Port=5432;Username=postgres;Password=Informatika;Database=hr_uas";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable table;
        private DataGridView dgvData;
        private DataGridViewRow _row;

        public DataGridViewRow Row { set{ _row = value; } }


        public KaryawanRepository(DataGridView _dgvData)
        {
            dgvData = _dgvData;
        }

        public void Load()
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

        public void Add(TextBox tbKaryawan, ComboBox cbDep)
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
            finally { connection.Close(); }
        }

        public void Edit(TextBox tbKaryawan, ComboBox cbDep)
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
                cmd.Parameters.AddWithValue("_id", _row.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", tbKaryawan);
                cmd.Parameters.AddWithValue("_dep", cbDep);

                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil update");
                    tbKaryawan.Text = null;
                    cbDep.Text = null;
                    Load();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }
        public void delete(TextBox tbKaryawan, ComboBox cbDep)
        {
            connection = new NpgsqlConnection(conn);
            if(_row == null)
            {
                MessageBox.Show("Pilih data dulu");
            }
            try
            {
                connection.Open();
                string sql = @"SELECT * FROM kar_delete(:_id)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", _row.Cells["_id_karyawan"].Value.ToString);

                if((int)cmd.ExecuteScalar()==1)
                {
                    MessageBox.Show("Berhasil menghapus");
                    tbKaryawan.Text = null;
                    cbDep.Text = null;
                    Load();
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
