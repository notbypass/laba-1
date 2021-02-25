using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = " select users.login as login, status.name as Name, jobs.name from users join status on users.id_status = status.Id_status join jobs on users.id_jobs = jobs.Id_jobs;";           
            MySqlConnection conn = DB.getConnection();
            MySqlCommand cmDB1 = new MySqlCommand(query, conn);
            cmDB1.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB1.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2)};
                        var listViemItem = new ListViewItem(row);
                        listView1.Items.Add(listViemItem);
                    }
                }


                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                MessageBox.Show("Подключиться");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);

            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


    
