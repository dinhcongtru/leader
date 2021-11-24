using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class frmsinhvien : Form
    {
        public frmsinhvien()
        {
            InitializeComponent();
        }

        private void frmsinhvien_Load(object sender, EventArgs e)
        {
            
            LoadDataGridView();
            LoadCombobox();
        }
        private void LoadDataGridView()
        {
            string sql = "select *from sinhvien ";
            DataTable abc = new DataTable();
            abc = ketnoi.SelectDB(sql);
            dataGridView1.DataSource = abc;
        }
        private void LoadCombobox ()
        {
            string sql = "select * from lophoc  ";
            DataTable lophoc = ketnoi.SelectDB(sql);
            cmblophoc.DisplayMember = "tenlop";
            cmblophoc.ValueMember = "id";
            cmblophoc.DataSource = lophoc   ;
        }
       
        private void bntthoat_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void bntluu_Click(object sender, EventArgs e)
        {
            string sql = "select tensv  from sinhvien  where tensv  =N '" + txbtensv.Text + "'";
            DataTable dt = ketnoi.SelectDB(sql);
            if (dt.Rows.Count > 0)
                MessageBox.Show("Tên sinh viên  đã tồn tại!");
            else
            {
                sql = "insert into sinhvien(tensv) values (N'" + txbtensv.Text + "')";
                ketnoi.UIDDB(sql);
                LoadDataGridView();
            }
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            if (txbmasv.Text.Trim() == "")
            {
                MessageBox.Show("chọn sinh viên để xóa!");
                return;
            }
            string sql = "delete from sinhvien  where id = '" + txbmasv.Text + "'";
            ketnoi.UIDDB(sql);
            LoadDataGridView();
        }

        private void bntcapnhat_Click(object sender, EventArgs e)
        {
            string sql = "update sinhvien  set tensv  = N'" + txbtensv.Text + "', ngaysinh = '" + dtngaysinh.Value.ToString("yyyy-MM-dd") + "', dienthoai = '" + txbdienthoai.Text + "',diachi = '" +txbdiachi.Text + "', where id = '" + txbmasv.Text + "'";
            ketnoi.UIDDB(sql);
            LoadDataGridView();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txbmasv.Text = row.Cells["id"].Value.ToString();
            txbtensv.Text = row.Cells["tensv"].Value.ToString();
            cmblophoc.Text = row.Cells["tenlop"].Value.ToString();
            dtngaysinh.Value = DateTime.Parse(row.Cells["ngaysinh"].Value.ToString());
            bool _ktgioitinh = bool.Parse(row.Cells["gioitinh"].Value.ToString());
            if(_ktgioitinh == true )
            {
                radnam.Checked = true;
                radnu.Checked = false;
            } else
            {
                radnam.Checked = false;
                radnu.Checked = true;
            }
            txbdienthoai.Text = row.Cells["dienthoai"].Value.ToString();
            txbdiachi.Text = row.Cells["diachi"].Value.ToString();
                
        }

        private void cmblophoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
