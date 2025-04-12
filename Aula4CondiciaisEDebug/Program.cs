//Estrutura condicial 
//usada para ser executado caso a condição seja verdadeira

using System.Reflection.Metadata;

// if (condiçao){
//     bolco executado
// }else{
// e executado caso seja falso
//}
//

if(10>20){
    Console.WriteLine("if executado");
}else if(10>3){
    Console.WriteLine("else if executado");
}else{
Console.WriteLine("else executado");
}


//Debug
// mostrar o codigo linha por linha
//comando Debug
// breakpoint:onde o codigo para  vc marca com o mause
//f5 executa o debug
//f10 avança


// switch case
// uma alternativa para if e else
int n = 2;
switch (n)
{
    case 1:
    Console.WriteLine("1");
    break;
    case 2:
    Console.WriteLine("2");
    break;
    case 3:
    Console.WriteLine("3");
    break;
    default:
        // Código a ser executado se nenhum dos casos for atendido
        break;
}