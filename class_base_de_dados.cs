using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace database_consultas
{
    
    class dbConsultas
    {
        SqliteConnection conexao = new SqliteConnection("Data Source = userdata.db");
        SqliteCommand comando = new SqliteCommand();
        SqliteDataReader leitura_col;

        int total_dados = 0;
        
        private string carregar_todo_bd = "Select * from DadosYourKey";
        private string adicionar_dado_ao_bd = "Insert into DadosYourKey (servico, website, email_associado, usuario, senha) values ";
        private string remover_dado_bd = "Delete from DadosYourKey where id = ";
        public void carregarTodoBd(ref ListView list) // vindo do listview do frm_home
        {
            
            using (conexao)
            {
                conexao.Open();
                using (leitura_col)
                {
                    comando.CommandText = carregar_todo_bd;
                    comando.Connection = conexao;
                    leitura_col = comando.ExecuteReader();
                    total_dados = list.Items.Count;

                    while(leitura_col.Read())
                    {
                        ListViewItem item = new ListViewItem(leitura_col["id"].ToString());
                        item.SubItems.Add(leitura_col["servico"].ToString());
                        item.SubItems.Add(leitura_col["website"].ToString());
                        item.SubItems.Add(leitura_col["email_associado"].ToString());
                        item.SubItems.Add(leitura_col["usuario"].ToString());
                        item.SubItems.Add(leitura_col["senha"].ToString());

                        if (item != null)
                        {
                            list.Items.Add(item);
                            
                        }

                    }

                }

                conexao.Close();
            }
        }
        public void adicionarDadoBd(ref ListView listview , int id_provisorio, string servico, string website, string email_associado, string usuario, string senha)
        {
            using (conexao)
            {
                conexao.Open();

                using (comando)
                {
                    
                    comando.CommandText = adicionar_dado_ao_bd + "(" + "'" + servico + "'" + "," + "'" + website + "'" + "," + "'" + email_associado + "'" + "," + "'" + usuario + "'" + "," + "'" + senha + "'" + ")";
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();

                    ListViewItem item = new ListViewItem(id_provisorio.ToString());
                    item.SubItems.Add(servico);
                    item.SubItems.Add(website);
                    item.SubItems.Add(email_associado);
                    item.SubItems.Add(usuario);
                    item.SubItems.Add(senha);

                    listview.Items.Add(item);
                }

                

                conexao.Close();   
            }
        }
        
        public void removerDado_bd(int id)
        {
            using (conexao)
            {
                conexao.Open();

                using (comando)
                {
                    comando.CommandText = remover_dado_bd + (id.ToString());
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }
    }
}
