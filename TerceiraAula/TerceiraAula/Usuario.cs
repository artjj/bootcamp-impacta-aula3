using System;
using System.Collections.Generic;
using System.Text;

namespace TerceiraAula
{
    class Usuario : Pessoa
    {
        public DateTime ?Demissao { get; set; }
        public DateTime AceiteDeTermos;
        public DateTime ConfirmacaoCadastro;
    }
}
