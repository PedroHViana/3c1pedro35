using _3c1pedro35.Code.dal;
using _3c1pedro35.Code.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1pedro35.Code.bll
{
    internal class homebll
    {
        //Objeto para acesso ao banco de dados
        acessobd conexao = new acessobd();
        string tabela = "tbl_jogos";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(homedto medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Jogo}','{medDto.Tipo}','{medDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(homedto medDto)
        {
            string editar = $"update {tabela} set Tipo = '{medDto.Tipo}', Preco = '{medDto.Preco}',jogo = '{medDto.Jogo}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(homedto medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by jogo;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
