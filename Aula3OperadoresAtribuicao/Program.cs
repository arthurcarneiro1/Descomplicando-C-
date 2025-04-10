// Operadores de Atribuição

//para atribuir um valor usamos o 
//=

using System.IO.Pipelines;

string nome = "arthur";
nome="Sam"; //valor mudou

//encremento
//+=
int contador = 10;
contador +=2; //12 , encremento mais 2 


//decremento
//-=
contador-=2; // 10 . diminuo o valor

// converte valores 
// parse

string numero = "3";

int n = int.Parse(numero); // numero convertido para string

//conversão segura
int.TryParse(numero, out int result); // ele converte e senão conseguir retorna null
Console.WriteLine(result);

// conversão implicita com cast

double n2 = 2.4;
int n4 = (int)n2; // usado para converter 