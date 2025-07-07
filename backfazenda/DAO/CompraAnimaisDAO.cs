using backfazenda.mapeamento;
using backfazenda.utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace backfazenda.DAO
{
    internal class CompraAnimaisDAO
    {
        public void Cadastrar(CompraAnimais compra)
        {
			try
			{
				string dataCompra = compra.DataCompra.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO compra_animais (Data_Compra, " +
                    "Numero_Nota_Fiscal, Valor_Total_Nota, Valor_Frete, GTA, Quantidade, fk_id_fornecedor) " +
                    "VALUES (@DataCompra, @NumeroNotaFiscal, @ValorTotalNota, " +
                    "@ValorFrete, @GTA, @Quantidade, @FKFornecedor)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@DataCompra", dataCompra);
                comando.Parameters.AddWithValue("@NumeroNotaFiscal", compra.NumeroNotaFiscal);
                comando.Parameters.AddWithValue("@ValorTotalNota", compra.ValorTotalNota);
                comando.Parameters.AddWithValue("@ValorFrete", compra.ValorFrete);
                comando.Parameters.AddWithValue("@GTA", compra.GTA);
                comando.Parameters.AddWithValue("@Quantidade", compra.Quantidade);
                comando.Parameters.AddWithValue("@FKFornecedor", compra.FKFornecedor.IdFornecedor);

                comando.ExecuteNonQuery();

                Conexao.FecharConexao();
            }
			catch (Exception ex)
			{
                throw new Exception(ex.Message);
            }
        }
        public void Atualizar(CompraAnimais compra)
        {
            try
            {
                string dataCompra = compra.DataCompra.ToString("yyyy-MM-dd");
                string sql = "UPDATE compra_animais SET data_compra = @DataCompra, " +
                    "numero_nota_fiscal = @NumeroNotaFiscal, valor_total_nota = @ValorTotalNota," +
                    " valor_frete = @ValorFrete, GTA = @GTA, quantidade = @quantidade, fk_id_fornecedor = @FKFornecedor " +
                    "WHERE id_compra = @IdCompra";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@IdCompra", compra.IdCompra);
                comando.Parameters.AddWithValue("@DataCompra", dataCompra);
                comando.Parameters.AddWithValue("@NumeroNotaFiscal", compra.NumeroNotaFiscal);
                comando.Parameters.AddWithValue("@ValorTotalNota", compra.ValorTotalNota);
                comando.Parameters.AddWithValue("@ValorFrete", compra.ValorFrete);
                comando.Parameters.AddWithValue("@GTA", compra.GTA);
                comando.Parameters.AddWithValue("@Quantidade", compra.Quantidade);
                comando.Parameters.AddWithValue("@FKFornecedor", compra.FKFornecedor.IdFornecedor);

                comando.ExecuteNonQuery();

                Conexao.FecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
