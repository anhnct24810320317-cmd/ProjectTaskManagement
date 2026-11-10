using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjectTaskManagement.DAL;

namespace ProjectTaskManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MessageBox.Show(
                        "Ket noi ProjectTaskDB thanh cong!"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Loi ket noi: " + ex.Message
                );
            }
        }
    }
}