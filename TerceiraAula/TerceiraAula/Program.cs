using System;

namespace TerceiraAula
{
    class Program
    {
        static void Main(string[] args)
        {
            var validade = new DateTime(2021, 9, 20);
            Produto cafe = new Produto()
            {
                Id = 1,
                Nome = "Café 3 Corações",
                Descricao = "Cafe premium torrado embalado a vácuo",
                Tipo = "Alimento",
                Valor = 9.75,
            };
            cafe.AtualizarDataValidade(validade);

            Produto leite = new Produto();
            leite.Id = 2;
            leite.Nome = "Leite UHT Integral";
            leite.Descricao = "Leite integral pasteurizado";
            leite.Tipo = "Alimento";
            leite.Valor = 4.85;
            leite.AtualizarDataValidade(validade);

            if (cafe.Validade == leite.Validade)
            {
                Console.WriteLine("A validade é a mesma!");
            }
            else
            {
                Console.WriteLine("Validades diferentes!");
            }
        }
    }
}
