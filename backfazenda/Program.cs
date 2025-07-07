using backfazenda.DAO;
using backfazenda.mapeamento;
try
{
    Fornecedor a = new Fornecedor();
    a.IdFornecedor = 6; // Exemplo de ID de fornecedor existente

    CompraAnimais compraAnimais = new CompraAnimais();
    compraAnimais.IdCompra = 11; // Exemplo de ID de compra existente
    compraAnimais.DataCompra = DateOnly.FromDateTime(DateTime.Now);
    compraAnimais.NumeroNotaFiscal = "NFA-509";
    compraAnimais.ValorTotalNota = 1500.00;
    compraAnimais.ValorFrete = 500.00;
    compraAnimais.GTA = "GTA-RO-00345/25";
    compraAnimais.Quantidade = 1;
    compraAnimais.FKFornecedor = a;

    CompraAnimaisDAO caDAO = new CompraAnimaisDAO();
    caDAO.Cadastrar(compraAnimais);
    caDAO.Atualizar(compraAnimais);
}
catch (Exception ex)
{
    throw new Exception(ex.Message);
}
