using System;
using System.Collections.Generic;
using System.Text;

namespace AppCardapio1.Interface
{
    class Conexao
    {
        //MySqlConnection conexaoMySQL;
        //MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        //public string CriarStringConexao()
        //{
        //    builder.Server = "mysql.sophix.com.br";
        //    builder.Database = "dbevan";
        //    builder.UserID = "evandrox";
        //    builder.Password = "projetor2019";
        //    builder.Port = 3306;

        //    return builder.ToString();
        //}

        //public string InsertDetails(GravarPedidos custDB)
        //{
        //    string connString = "Server=mysql.sophix.com.br;Port=3306;Database=dbevan;Uid=evandrox;password=projetor2019";
        //    MySqlConnection conn = new MySqlConnection(connString);
        //    MySqlCommand command = conn.CreateCommand();

        //    //string StringConexaoMysql = CriarStringConexao();
        //    command.CommandText = "INSERT INTO tbcarrinho(nome,preco,total,qty) VALUES('Suco','9','9','1') ";
        //    conn.Open();
        //    command.ExecuteNonQuery();

        //    conn.Close();
        //}

        //public List<string> GravaPedidos()
        //{
        //        List<string> lista;
        //        string StringConexaoMysql = CriarStringConexao();
        //        string consulta = "SELECT Nome from Categorias ORDER BY Nome";
        //        try
        //        {
        //            conexaoMySQL = new MySqlConnection(StringConexaoMysql);
        //            conexaoMySQL.Open();

        //            MySqlDataReader rdr = null;
        //            MySqlCommand cmd = new MySqlCommand(consulta, conexaoMySQL);

        //            rdr = cmd.ExecuteReader();
        //            lista = new List<string>();

        //            while (rdr.Read())
        //            {
        //                Restaurantes r = new Restaurantes();
        //                r.nome = rdr["Nome"].ToString();
        //                lista.Add(r.nome);
        //            }
        //            return lista;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            conexaoMySQL.Close();
        //        }
        //}
    }
}
