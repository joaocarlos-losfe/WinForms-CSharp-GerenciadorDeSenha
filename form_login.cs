using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Your_Keys
{
    public partial class form_login : Form
    {
        public string Key = "";
        List<string> dados_list_view = new List<string>();
        public form_login()
        {
            InitializeComponent();
        }

        private void txtbox_key_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_key.Text.Length < 4)
                btn_entrar.Visible = false;
            else
                btn_entrar.Visible = true;
        }

        private void chbox_mostrar_key_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_mostrar_key.Checked)
                txtbox_key.PasswordChar = '\0';
            else
                txtbox_key.PasswordChar = '*';
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txtbox_key.Text != Key)
            {
                lbl_info_erro.Visible = true;
            }
            else
            {
                lbl_info_erro.Visible = false;
                form_home home = new form_home();
                this.Hide();
                home.ShowDialog();
                this.Show();
                home.Dispose(); // liberar memoria
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            if(!File.Exists("userdata.dat"))
            {
                form_criar_key criar_key = new form_criar_key();
                criar_key.ShowDialog();

                Key = criar_key.Key;

                Console.WriteLine("key: " + Key);

                if(Key != "" || Key == null)
                {
                    
                    using (StreamWriter save_file = new StreamWriter("userdata.dat"))
                    {
                        save_file.WriteLine(Key);
                    }

                    using (SqliteConnection connection = new SqliteConnection("Data Source=userdata.db"))
                    {
                        using (SqliteCommand command = new SqliteCommand())
                        {
                            connection.Open();

                            string CMD_criar_tabela = @"CREATE TABLE DadosYourKey 
                                                      (   
                                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                        servico VARCHAR(30),
                                                        website VARCHAR(300),
                                                        email_associado VARCHAR(30),
                                                        usuario VARCHAR(30),
                                                        senha VARCHAR(30)
                                                      );";

                            command.CommandText = CMD_criar_tabela;
                            command.Connection = connection;

                            command.ExecuteNonQuery();

                            Console.WriteLine("ok...");

                            command.Dispose();
                            connection.Close();
                            connection.Dispose();
                        }
                    }

                }

                criar_key.Dispose();

            }
            else
            {
                using (StreamReader load_file = new StreamReader("userdata.dat"))
                {
                   
                    Key = load_file.ReadLine();

                }
            }
        }
    }
}
