using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1Sintaxe.models
{
    public class Pessoa
    {
        //PascalCase
        //atributos
        //são os valores atribuidos da classe
        public string NomeCompleto { get; set; }

        public int idade { get; set; }

        //Metodos
        // e oque apresenta uma ação dentro de uma classe
        public void Apresentacao(){
            Console.WriteLine($"meu nome é {NomeCompleto} e tenho {idade}");
        }
    }
}