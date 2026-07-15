using Microsoft.Data.SqlClient;
using Projeto_AssistenciaTec.Data;
using Projeto_AssistenciaTec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_AssistenciaTec.Repository
{
    public class ClienteRepository
    {
        public int Salvar(Cliente cliente)
        {

            //Criar a instrução SQL de INSERT
            string sql = "INSERT INTO tbl_clientes (nome, email, telefone, endereco) " +
                "OUTPUT INSERTED.cliente_id " +
                "VALUES (@Nome, @Email, @Telefone, @Endereco)";


            //Criar/abrir a conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            //Criar o comando que será ernviado ao anco de dados
            using var comando = new SqlCommand(sql,conexao);

            //Preencher os campos da instrução sql com os valores
            comando.Parameters.AddWithValue("@Nome", cliente.Nome);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Telefone",cliente.Telefone);
            comando.Parameters.AddWithValue("@Endereco", cliente.Endereco);


            //Executar o comando
            var novoId = (int) comando.ExecuteScalar();// casting


            return novoId;

            // Da forma antiga, não esquecer de fechar a conexão depois de usar
            //conexao.Close();

        }

        public List<Cliente> ListarTodos()
        {

            //Criar instrução sql para listar todos
            var sql = "SELECT * FROM tbl_clientes ORDER BY nome ASC";

            //Abrir conexão com o banco de dados
            using var conexao = Conexao.GetConexao();
            
            //Criar o comando
            using var comando = new SqlCommand( sql,conexao);

            // Criar um objeto que guarda o resultado do comando SELECT
            using var resultado = comando.ExecuteReader();

            //Criar uma lista de clientes vazia
            List<Cliente> clientes= new List<Cliente>();

            while (resultado.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = resultado.GetInt32(resultado.GetOrdinal("cliente_id"));
                cliente.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                cliente.Email = resultado.GetString(resultado.GetOrdinal("email"));
                cliente.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                cliente.Endereco = resultado.GetString(resultado.GetOrdinal("endereco"));
                clientes.Add(cliente);
                


            }

            return clientes;
        }
    }
}
