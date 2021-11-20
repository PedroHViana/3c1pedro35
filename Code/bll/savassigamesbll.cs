using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3c1pedro35.Code.dal;
using _3c1pedro35.Code.dto;

namespace _3c1pedro35.Code.bll
{
    internal class savassigamesbll
    {
        acessobd conexao = new acessobd();
        string tabela = "tbl_login";


        public bool RealizarLogin(savassigamesdto Login)
        {
            string sql = $"select * from {tabela} where Nome='{Login.User}' and Senha='{Login.Password}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void Inserir(savassigamesdto medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values('{medDto.User}','{medDto.Password}','{medDto.CPF}')";
            conexao.ExecutarComando(inserir);
        }
    }
}
