using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=dbResponsi";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        karyawan Karyawan = new karyawan();
        public Form1()
        {
            conn = new NpgsqlConnection(connstring);
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from tb_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            Karyawan.nama = tb_nama.Text;
            Karyawan.id_dep = cb_dep.Text;
            try
            {
                conn.Open();
                sql = @"select * from tb_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", Karyawan.nama);
                cmd.Parameters.AddWithValue("_id_dep", Karyawan.id_dep);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil dimasukkan", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    //load data
                    loadData();
                    tb_nama.Text = cb_dep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Insert fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Karyawan.nama = tb_nama.Text;
            Karyawan.id_dep = cb_dep.Text;
            if (r == null)
            {
                MessageBox.Show("Mohon pilih data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from tb_update(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", Karyawan.nama);
                cmd.Parameters.AddWithValue("_id_dep", Karyawan.id_dep);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    //load data
                    loadData();
                    tb_nama.Text = cb_dep.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Karyawan.nama = tb_nama.Text;
            Karyawan.id_dep = cb_dep.Text;
            if (r == null)
            {
                MessageBox.Show("Mohon pilih data yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from tb_delete(:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil didelete", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    //load data
                    loadData();
                    tb_nama.Text = cb_dep.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tb_nama.Text = r.Cells["_nama"].Value.ToString();
                cb_dep.Text = r.Cells["_id_Dep"].Value.ToString();
            }
        }
    }
}