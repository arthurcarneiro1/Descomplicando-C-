// Tipos de Dados 
// oque e uma variavel
// e uma forma de armazenar um valor na memoria
int idade = 23;
//a idade foi salva e armazenada na variavel idade

// Tipos de Dados mais usados
// tipode de dados são usado pq o c#  euma lihguamde de forte tipagem

//string para um grupo de caracteres
string nome = "arthur";

//int para numero inteiros;
int n = 2;

//double para numero com ponto flutuante
double n2= 2.3;

//bool para verdadeiro ou false
bool respost = true;

//char para apenas 1 caractere
char id = 'a';


//var
//usado para não precisar ficar definindo o tipo o proprio c# vai saber
var sobrenome = "Carneiro";
var n3=5;


//datetime
//usado no c# para podemos manipular as datas e horas

DateTime agora = DateTime.Now; // salvei o momento atual
Console.WriteLine(agora);
Console.WriteLine(agora.Hour);
Console.WriteLine(agora.Day);
Console.WriteLine(agora.ToString("dd/MM/yyyy")); // usado para formatar a exibiçao

