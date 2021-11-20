using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3c1pedro35.Code.bll;
using _3c1pedro35.Code.dto;
using _3c1pedro35.UI;

namespace _3c1pedro35
{
    public partial class Formlogin : Form
    {
        savassigamesbll medbll = new savassigamesbll();
        savassigamesdto meddto = new savassigamesdto();    
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            meddto.User = textBox1.Text;
            meddto.Password = textBox2.Text;
            meddto.CPF = textBox3.Text;
            
            medbll.Inserir(meddto);
            MessageBox.Show("Cadastrado com sucesso!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            meddto.User = textBox1.Text;
            meddto.Password = textBox2.Text;

            if (medbll.RealizarLogin(meddto) == true)
            {
                FormHome home = new FormHome();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
