using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backfazenda.mapeamento
{
    internal class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Fornecedor()
        { }
    }
}
