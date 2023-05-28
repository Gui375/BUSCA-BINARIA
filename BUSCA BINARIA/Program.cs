using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;


//EXEMPLO DE BUSCA BINARIA
#region

//int[] vetor = new int[10];
//int minimo = 0;
//int maximo = vetor.Length - 1;
//int meio;
//int busca;

//for (int i = 0; i < vetor.Length; i++)
//{
//    vetor[i] = i * 2;
//}


//var vetorOrdenado = vetor.OrderBy(item => item).ToArray();

//foreach (var item in vetor)
//{
//    Console.Write($"{item}|");
//}



//Console.WriteLine();
//busca = int.Parse(Console.ReadLine());
//while (minimo <= maximo)
//{
//    meio = (minimo + maximo) / 2;
//    if (busca == vetorOrdenado[meio])
//    {
//        Console.WriteLine($"elemento encontrato na posição {meio}");
//        break;
//    }
//    else
//    {
//        //String.Compare(busca, vetor[meio])
//        // 0 quando sao iguais
//        //-1 quando busca vem no alfabeto vem antes de vetor[meio] ana , beto 
//        //1 quando busca vem no alfabeto vem depois de vetor[meio] vitor , guilherme
//        //carlos
//        //carla
//        if (busca > vetorOrdenado[meio])
//        {
//            minimo = meio + 1;
//        }
//        else
//        {
//            maximo = meio - 1;
//        }
//    }

//}

#endregion

// atividade 1
#region
// A) a complexidade da busca binaria depende da situação, mas nos piores dos casos é O(Log n ).
// Agora  a busca linear no seu pior caso seria O(n)
//
// B) O melhor caso em que a busca linear é mais interessante que a busca binaria,
// é quando o valor pesquisado está na primeira posição que neste caso seria O(1)
//
// C) O vetor está ordenado é fundamental para a busca binaria, porque ele se torna muito mais eficiente quando 
// o vetor está ordernado, alem de eliminar grande parte da busca desejada!
#endregion

// atividade 2
#region
//string[] vetor_palavras = new string[4];

//int inicio = 0;
//int fim = vetor_palavras.Length-1;
//int meio;
//string busca;

//for (int i = 0; i <= vetor_palavras.Length-1; i++)
//{
//    Console.WriteLine("Escreva uma palavra : ");
//    vetor_palavras[i] = Console.ReadLine();
//}

//var vetor_palavras_Ord = vetor_palavras.OrderBy(x => x).ToArray();
//Console.WriteLine("");
//foreach (var nomes in vetor_palavras_Ord)
//{
//    Console.WriteLine(nomes);
//}

//// para usar busca binaria, se começa com while 

//Console.WriteLine("");

//Console.WriteLine("Qual nome você deseja buscar ?");
//busca= Console.ReadLine();
//bool verificacao=false;

//while (inicio <= fim )
//{
//    meio = (inicio + fim ) / 2;
//    if (string.Compare(busca, vetor_palavras_Ord[meio]) == 0 )
//    {
//        verificacao = true;
//        break;
//    }
//    else
//    {
//        if (string.Compare(busca, vetor_palavras_Ord[meio]) == 1)
//        {
//               inicio = meio + 1;
//        }
//        else
//        {
//            fim = meio - 1;
//        }

//    }
//}
//if (verificacao == true)
//{
//    Console.Write("deu certo ");
//}
//else
//{
//    Console.Write("Não deu certo ");
//}
#endregion

//atividade 3
#region
// A) O novo valor 5 teria que ser inserido na primeira posição do vetor (Posição 0 do vetor), 
// B) Não é ruim, somente esse vetor é perfeito para a busca binaria, pois já está ordenado, agora, caso um novo falor for inserido, precisaria ser inserido na ultima posição do vetor
//    o que quebraria toda a organização do vetor, e precisaria ser ordenado novamente


// C)
int[] vetor = new int[9] {10,20,30,40,50,60,70,80,90 };
var vetorOrdenado = vetor.OrderBy(item => item).ToArray();
int[] vetor2 = new int[10];

int busca;



Console.WriteLine("Valores do vetor: ");
foreach (var item in vetorOrdenado)
{
    Console.Write($"{item}|");

}

menu:
Console.WriteLine("\na. 1 – Inserir no vetor\r\nb. 2 – Buscar no vetor por busca binária\r\nc. 3 – Buscar no vetor por busca sequencial\r\nd. 4 – Sair");    
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Qual valor você deseja adicionar ?");
        int valorNovo=int.Parse(Console.ReadLine());
        int[] NovoVetor = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, valorNovo };
        Console.WriteLine();
        var NovoVetor_ordernado = NovoVetor.OrderBy(item => item).ToArray();    
        foreach (var item in NovoVetor_ordernado)
        {
            Console.WriteLine(item);
        }
        for (int i = 0; i<=NovoVetor.Length-1;i++)
        {
            vetor2[i] = NovoVetor_ordernado[i];
        }
        goto menu;

    case 2:
        BuscaBinaria(vetor2,0,vetor2.Length-1);
        goto menu;

    case 3:
        Console.WriteLine("Valor procurado? ");
        busca=int.Parse(Console.ReadLine());
        bool ver=false;
        for (int i = 0; i <= vetor2.Length - 1; i++)
        {
            if (busca == vetor2[i])
            {
                Console.WriteLine($"Numero encontrado");
                ver = true;
            }
           
        }
        for (int i = 0; i <= vetor.Length - 1; i++)
        {
            if (busca == vetor[i])
            {
                Console.WriteLine($"Numero encontrado");
                ver = true;
            }

        }
        if (ver==true)
        {
        }
        else
        {
            Console.WriteLine("Numero não encontrado");
        }
        goto menu;

    case 4:
        Console.WriteLine("Fim do codigo !");
        break;
}

void BuscaBinaria(int[]V, int ini, int fim )
{
    int[] NovoVetor = V;
    int meio = (ini + fim) / 2;
    bool verificacao = false;
    Console.WriteLine("Qual valor você deseja buscar ? ");
    busca = int.Parse(Console.ReadLine());
    while (ini <= fim)
    {
        meio = (ini + fim) / 2;
        if (busca == NovoVetor[meio])
        {
            Console.WriteLine($"elemento encontrato na posição {meio + 1}");
            verificacao = true;
            break;
        }
        else
        {
            if (busca > vetorOrdenado[meio])
            {
                ini = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }
    }
    if (verificacao == true)
    {

    }
    else
    {
        Console.WriteLine("Não existe");
    }
}

#endregion

