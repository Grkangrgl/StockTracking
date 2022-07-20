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

namespace NesneTabanliFinalOdev
{
    public partial class Form1 : Form
        {
            
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                GridUpdate();
                
            }

        void GridUpdate()
        {
            dataGridView1.DataSource = Classes.SQLConnectionClass.Table("Select * From Ürünler");
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TxtUrunID.Text = row.Cells["ÜrünNo"].Value.ToString();
                TxtUrunAd.Text = row.Cells["ÜrünAd"].Value.ToString();
                TxtUrunFiyat.Text = row.Cells["BirimFiyat"].Value.ToString();
                TxtStokMiktarı.Text = row.Cells["StokMiktarı"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void UrunKaydet_Click(object sender, EventArgs e)
        {
            Models.Urunler urun = new Models.Urunler()
            {
                Data_ÜrünNo = Convert.ToInt32(TxtUrunID.Text),
                Data_ÜrünAd = TxtUrunAd.Text,
                Data_BirimFiyat = Convert.ToInt32(TxtUrunFiyat.Text),
                Data_StokMiktarı = Convert.ToInt32(TxtStokMiktarı.Text)
            };
            urun.Kaydet();
            GridUpdate();
        }

        private void UrunSil_Click(object sender, EventArgs e)
        {
            Models.Urunler urun = new Models.Urunler()
            {
                Data_ÜrünNo = Convert.ToInt32(TxtUrunID.Text)
            };
            urun.Sil();
            GridUpdate();
        }
        private void TxtUrunAdArama_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            GridUpdate();//veritabanından verileri çekme kodu.
            if (TxtUrunAdArama.Text == "")
            {
                GridUpdate();
            }
            string searchValue = TxtUrunAdArama.Text; //
            try
            {
                List<DataGridViewRow> indexList = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ÜrünAd"].Value == null || !row.Cells["ÜrünAd"].Value.ToString().Contains(searchValue))
                    {// kosuldaki Cells[] içerisindeki değer datagrid sutununu temsil eder. hangi sutunsa o yazılacak
                        int rowIndex = row.Index;
                        dataGridView1.Rows[rowIndex].Selected = true;
                        indexList.Add(row);
                        
                    }
                }
                foreach (DataGridViewRow row in indexList)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}

