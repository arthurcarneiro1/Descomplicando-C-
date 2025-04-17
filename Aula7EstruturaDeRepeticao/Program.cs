// Estrutura de Repetição

//for : quando sabemos a quantidade de repetiçoes

string[] listaCompra = ["maça","uva","pera","caqui","maracuja"]; //lista criada

for(int i = 0; i<listaCompra.Length; i++){ // for classico
    Console.WriteLine(listaCompra[i]);
   
}

foreach (var item in listaCompra) // melhor para percorrer
{
    Console.WriteLine(item);
}

//while : uado quando não sabemos a quantidade de repetiçoes

int contador = 0;

while(contador<10){
    
     if(contador==4){
        contador++;
        continue;// continue interrompe aquele laço em especifico
    }
    Console.WriteLine(contador);
    if(contador==7){
        break; // break: para a repetição
    }
contador++;
}
 contador = 0;
do // do while executa primeiro depois verifica
{
   Console.WriteLine(contador); 
contador++;
} while (contador<10);