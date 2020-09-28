using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database_consultas;

namespace Your_Keys
{
    public partial class form_home : Form
    {
        dbConsultas consultas_bd = new dbConsultas();
        int numero_registros = 0;

        ListViewItem item_selecionado = new ListViewItem();
        public form_home()
        {
            InitializeComponent();
            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            form_adicionar_dados adicionar_dados = new form_adicionar_dados();

            adicionar_dados.ShowDialog();

            if( ! adicionar_dados.sem_dados)
            {
                //adcionar ao bd
                numero_registros++;
                lbl_info_total_de_registros.Text = numero_registros.ToString();
                consultas_bd.adicionarDadoBd(ref listv_dados_keys, numero_registros, adicionar_dados.servico, adicionar_dados.website, adicionar_dados.email_associado, adicionar_dados.usuario, adicionar_dados.senha);
            }

            adicionar_dados.Dispose();
        }

        private void btn_adicionar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_adicionar, "Adicionar nova key");
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listv_dados_keys.SelectedItems)
            {
                listv_dados_keys.Items.Remove(item);
                consultas_bd.removerDado_bd(int.Parse(item.Text));
                numero_registros--;
                lbl_info_total_de_registros.Text = numero_registros.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listv_copiar_area_de_transferencia.Items.Clear();

            foreach (ListViewItem item in listv_dados_keys.SelectedItems)
            {
                
                listv_copiar_area_de_transferencia.Items.Add(item.SubItems[1].Text);
                listv_copiar_area_de_transferencia.Items.Add(item.SubItems[2].Text);
                listv_copiar_area_de_transferencia.Items.Add(item.SubItems[3].Text);
                listv_copiar_area_de_transferencia.Items.Add(item.SubItems[4].Text);
                listv_copiar_area_de_transferencia.Items.Add(item.SubItems[5].Text);
            }

            btn_fechar_area_de_transferencia.Visible = true;
            listv_copiar_area_de_transferencia.Visible = true;
        }

        private void btn_copiar_texto_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_copiar_texto, "Copiar key para área de transfererencia");
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
            form_adicionar_dados adicionar_dados = new form_adicionar_dados(ref listv_dados_keys, item_selecionado, item_selecionado.SubItems[1].Text, item_selecionado.SubItems[2].Text, item_selecionado.SubItems[3].Text, item_selecionado.SubItems[4].Text, item_selecionado.SubItems[5].Text);
            adicionar_dados.ShowDialog();

            if (!adicionar_dados.sem_dados)
            {
                //adcionar ao bd

                consultas_bd.removerDado_bd(int.Parse(item_selecionado.Text));

                numero_registros++;
                lbl_info_total_de_registros.Text = numero_registros.ToString();
                consultas_bd.adicionarDadoBd(ref listv_dados_keys, numero_registros, adicionar_dados.servico, adicionar_dados.website, adicionar_dados.email_associado, adicionar_dados.usuario, adicionar_dados.senha);
            }

            //////////////////
        }

        private void btn_remover_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_remover, "Remover key");
        }

        private void btn_editar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_editar, "Editar key");
        }

        private void form_home_Load(object sender, EventArgs e)
        {
            consultas_bd.carregarTodoBd(ref listv_dados_keys); //enviado ao metodo da classe dbConsultas;
            numero_registros = listv_dados_keys.Items.Count;

            lbl_info_total_de_registros.Text = numero_registros.ToString();

        }

        private void listv_dados_keys_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esta_selecionado = false;

            foreach (ListViewItem item in listv_dados_keys.SelectedItems)
            {
                if (item.Selected)
                {
                    esta_selecionado = true;

                    item_selecionado = item;
                }
                    
                else
                    esta_selecionado = false;
            }

            btn_editar.Visible = esta_selecionado;
            btn_remover.Visible = esta_selecionado;
            btn_copiar_texto.Visible = esta_selecionado;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listv_copiar_area_de_transferencia.Visible = false;
            btn_fechar_area_de_transferencia.Visible = false;
        }

        private void listv_copiar_area_de_transferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listv_copiar_area_de_transferencia.SelectedItems)
            {
                Console.WriteLine(item.Text);
                Clipboard.SetText(item.Text);
                MessageBox.Show("Copiado para area de transferencia...");
                listv_copiar_area_de_transferencia.Visible = false;
                btn_fechar_area_de_transferencia.Visible = false;
            }
        }
    }
}
