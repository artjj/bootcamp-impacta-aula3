using System;
using System.Collections.Generic;
using System.Text;

namespace TerceiraAula
{
    class Produto
    {
        public int Id;
        public string Nome;
        public string Descricao;
        public double Peso;
        public double Valor;
        public DateTime Validade { get; private set; };
        public string Tipo;

        public string ExibirDados()
        {
            return "Id: " + Id 
                + ", Nome: " + Nome 
                + ", Descrição: " + Descricao 
                + ", Peso: " + Peso 
                + ", Valor: $" + Valor 
                + ", Validade: " + Validade; 
        }

        public void AtualizarDataValidade(DateTime novaData)
        {
            Validade = novaData;
        }

        public bool IsProdutoValido()
        {
            return Validade > DateTime.Now;
        }
    }
}
