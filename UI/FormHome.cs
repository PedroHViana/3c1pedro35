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
namespace _3c1pedro35.UI
{
    public partial class FormHome : Form
    {
        homebll medbll = new homebll();
        homedto meddto = new homedto();
        public FormHome()
        {
            InitializeComponent();
            dataGridView1.DataSource = medbll.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //editar
            meddto.Id = int.Parse(txt_id.Text);
            meddto.Jogo = txt_jogo.Text;
            meddto.Tipo = txt_tipo.Text;
            meddto.Preco = double.Parse(txt_preco.Text);

            medbll.Editar(meddto);
            MessageBox.Show("Editado com sucesso!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            txt_jogo.Clear();
            txt_tipo.Clear();
            txt_preco.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cadastrar
            meddto.Jogo = txt_jogo.Text;
            meddto.Tipo = txt_tipo.Text;
            meddto.Preco = double.Parse( txt_preco.Text);

            medbll.Inserir(meddto);
            MessageBox.Show("Cadastrado com sucesso!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            txt_jogo.Clear();
            txt_tipo.Clear();
            txt_preco.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txt_id.Text);
            meddto.Jogo = txt_jogo.Text;
            meddto.Tipo = txt_tipo.Text;
            meddto.Preco = double.Parse(txt_preco.Text);

            medbll.Excluir(meddto);
            MessageBox.Show("Excluído com sucesso!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            txt_jogo.Clear();
            txt_tipo.Clear();
            txt_preco.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txt_jogo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_tipo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_preco.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            } catch { MessageBox.Show("Não foi possível selecionar campo!"); }
           
        }
    }

        
    
}
