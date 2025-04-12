//Operadores logicos

//&& é
//todos precisam ser verdadeiro
//ex:
using System.Reflection.Metadata;

bool notaSuficiente = true;
bool frequencia= true;
bool result = notaSuficiente  && frequencia; // as duas condiçoes precisam atender para retornar True

//|| ou
// so apenas 1 precia ser verdadeiro
bool foneEsquerdo = true;
bool foneDireito= false;
bool ouvirMusica= foneEsquerdo || foneDireito; // como uma condiçao foi verdadeira  o resulado e true
//!  not
// negaçao logica inverte o resultado 
bool chuva = false;
if (!chuva)// mudou o resultado para true
{
    Console.Write("esta chovendo");
}
