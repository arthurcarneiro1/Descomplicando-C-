// using usado para importar 
using Aula1Sintaxe.models;
// Sintaxe e tipo da Dados
// no c# usamos o cameCase e o PascalCase

//cameCase
//usado em variaveis

string nome = "Arthur";

//PascalCase
// usada em atributos,classes metodos

 int Metodos(){
return 1+1;
}


//instanicando e usando classe

Pessoa p1 = new Pessoa();
// atribuiçao de valores
p1.NomeCompleto = "Arthur Carneiro";
p1.idade=23;
p1.Apresentacao();