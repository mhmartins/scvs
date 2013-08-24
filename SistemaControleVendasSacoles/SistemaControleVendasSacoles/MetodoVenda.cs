using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaControleVendasSacoles
{
    class MetodoVenda
    {
       /* public IList<Cliente> ListarClientes()
        {
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                if (conexao.State == ConnectionState.Open)
                {
                    IList<Cliente> listaDeClientes = new ObservableCollection<Cliente>();
                    var sql = new MySqlCommand(" Select * from clientes ", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Cliente cliente = new Cliente();
                        if (MySqlDR["idclientes"] != DBNull.Value)
                            cliente.IdCliente = Convert.ToInt32(MySqlDR["idclientes"]);
                        if (MySqlDR["nome"] != DBNull.Value)
                            cliente.Nome = MySqlDR["nome"].ToString();
                        if (MySqlDR["idade"] != DBNull.Value)
                            cliente.Idade = Convert.ToInt32(MySqlDR["idade"]);

                        listaDeClientes.Add(cliente);
                    }
                    return listaDeClientes;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }*/
    }
}
