using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Your_Keys
{
    public partial class form_adicionar_dados : Form
    {
        public string servico, website, email_associado, usuario, senha;
        public bool sem_dados = true;

        private void btn_gerar_usuario_Click(object sender, EventArgs e)
        {
            if(txtbox_servico.Text != "" || txtbox_email_associado.Text != "")
            {
                string temp = txtbox_email_associado.Text;

                if(temp.IndexOf('@') != -1)
                {
                    temp = temp.Remove((temp.IndexOf('@')), (temp.Length - temp.IndexOf('@')));
                    txtbox_usuario.Text = temp + txtbox_servico.Text;
                }
                else
                {
                    MessageBox.Show("insira um email valido");
                }
                   
            }
        }

        private void btn_gerar_senha_Click(object sender, EventArgs e)
        {
            Random ram = new Random();

            if(txtbox_usuario.Text !="")
            {
                string temp =  (ram.Next(100, 1000000001)) + txtbox_usuario.Text + (ram.Next(1001, 10001));
                txtbox_senha.Text = temp;
            }
        }

        public form_adicionar_dados()
        {
            
            InitializeComponent();

        }

        public form_adicionar_dados(ref ListView listView, ListViewItem item,  string servico, string website, string email_associado, string usuario, string senha)
        {

            InitializeComponent();

            listView.Items.Remove(item);
            


            txtbox_servico.Text = servico;
            txtbox_website.Text = website;
            txtbox_email_associado.Text = email_associado;
            txtbox_usuario.Text = usuario;
            txtbox_senha.Text = senha;

        }

        private void form_adicionar_dados_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            atribuir_dados();
            
            
        }
        private void atribuir_dados()
        {
            servico = txtbox_servico.Text;
            website = txtbox_website.Text;
            email_associado = txtbox_email_associado.Text;
            usuario = txtbox_usuario.Text;
            senha = txtbox_senha.Text;

            if (usuario != "" || senha != "")
            {
                sem_dados = false;
                this.Close();
            }   
            else
            {
                MessageBox.Show("Existe. alguns campos vazios (usuario e senha são obrigatorios)...");
            }

        }
    }
}
