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
    public partial class form_criar_key : Form
    {
        public string Key = "";
        public form_criar_key()
        {
            InitializeComponent();
        }

        private void txtbox_key_criacao_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_key_criacao.Text.Length < 12)
                btn_criar.Visible = false;
            else
            {
                btn_criar.Visible = true;
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            Key = txtbox_key_criacao.Text;

            MessageBox.Show("sua key " + "\"" + Key + "\"" + " foi criada com sucesso", "Sucesso");

            this.Close();
        }

        private void form_criar_key_Load(object sender, EventArgs e)
        {

        }
    }
}
