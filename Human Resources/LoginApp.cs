using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Resources
{
    public partial class LoginApp : Form
    {
        public LoginApp()
        {
            InitializeComponent();
        }

        private void LoginApp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet1.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.hrDataSet1.USERS);
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            /* SqlDataReader myReader;

             try
             {
                 sqlConnection1.Open();
                 myReader = sqlCommand1.ExecuteReader();

                 if (!myReader.Read())
                 {
                     sqlConnection1.Close();
                     myReader.Close();
                     CreateAdminLogin();
                 }
                 else
                 {
                     myReader.Close();

                     sqlCommand2.Parameters["@login"].Value = LoginTextBox.Text;
                     sqlCommand2.Parameters["@password"].Value =
                        passwordTextBox.Text;

                     myReader = sqlCommand2.ExecuteReader();

                     if (!myReader.Read())
                     {
                         MessageBox.Show("Доступ запрещен", "Ошибка");
                         myReader.Close();
                         sqlConnection1.Close();
                         return;
                     }

                     if (LoginTextBox.Text == myReader.GetString(1) &&
                        passwordTextBox.Text == myReader.GetString(2))
                     {
                         if (myReader.GetInt32(3) != 80)
                         {
                             dataGrid1.ReadOnly = true;
                             button2.Enabled = false;
                         }
                         else
                         {
                             dataGrid1.ReadOnly = false;
                             button2.Enabled = true;
                         }

                         myReader.Close();

                         dataSet11.Clear();
                         sqlDataAdapter1.Fill(dataSet11);
                     }
                     else
                     {
                         MessageBox.Show("Доступ запрещен", "Ошибка");
                     }
                     myReader.Close();
                     sqlConnection1.Close();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Ошибка");
             }
         }

         private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
         {

         }
            
     }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        }
        }
