using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backfazenda.mapeamento
{
    internal class CompraAnimais
    {
        public int IdCompra { get; set; }
        public DateOnly DataCompra { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public double ValorTotalNota { get; set; }
        public double ValorFrete { get; set; }
        public string GTA { get; set; }
        public int Quantidade { get; set; }
        public Fornecedor FKFornecedor { get; set; }
    }
}
