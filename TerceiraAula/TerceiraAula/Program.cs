using System;
using System.Collections.Generic;

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
            leite.AtualizarDataValidade(new DateTime(2021, 9, 13));

            if (!cafe.IsProdutoValido())
            {
                Console.WriteLine("Café vencido!");
            }

            if (!leite.IsProdutoValido())
            {
                Console.WriteLine("Leite vencido!");
            }

            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nome = "Arthur Dylan",
                IsMaiorDeIdade = true
            };

            Usuario usuario = new Usuario()
            {
                Id = 1,
                Nome = "",
                Demissao = null
            };

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(cliente);
            pessoas.Add(usuario);

            foreach(var p in pessoas)
            {
                if (p is Cliente)
                {
                    Console.WriteLine($"Cliente: {p.Nome}, é maior de idade? {((Cliente)p).IsMaiorDeIdade}");
                }
                else if (p is Usuario)
                {
                    Console.WriteLine($"Usuario: {p.Nome}, é maior de idade? {((Usuario)p).Demissao}");
                }
                else
                {
                    Console.WriteLine($"Pessoa: {p.Nome}");
                }
            }
        }
    }
}
