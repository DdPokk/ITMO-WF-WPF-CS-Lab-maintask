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
            using (SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=.\\SQLExpress"))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ShareDesc, CurrentPrice FROM ShareDetails.Shares", cn))
                {
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            listBoxResult.Items.Add(read[0] + "  " + read[1]);
                        }
                    }
                }
            }
        }
    }
}
