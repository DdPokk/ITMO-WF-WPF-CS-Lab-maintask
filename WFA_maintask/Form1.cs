using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_maintask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();

            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=.\\SQLExpress")) // необходимо подключить к своему серверу backup БД из репозитория ApressFinancial
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ShareDesc, CurrentPrice FROM ShareDetails.Shares", cn))
                {
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Result.Items.Add(read[0] + "  " + read[1]);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=.\\SQLExpress")) // необходимо подключить к своему серверу backup БД из репозитория ApressFinancial
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT count(*) FROM ShareDetails.Shares", cn))
                {
                    Result.Items.Add(cmd.ExecuteScalar());
                }
            }
        }

        private void cmdTest2_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=.\\SQLExpress")) // необходимо подключить к своему серверу backup БД из репозитория ApressFinancial
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ShareDetails.Shares(ShareDesc, CurrentPrice) VALUES ('ITMO' , 50000 )", cn))
                {
                   cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Result.Items.Clear();
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=.\\SQLExpress"))  // необходимо подключить к своему серверу backup БД из репозитория ApressFinancial
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ShareDetails.Shares WHERE CurrentPrice = 50000.00000", cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
