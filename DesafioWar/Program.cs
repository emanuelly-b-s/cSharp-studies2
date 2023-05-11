
using System;
using System.Collections.Concurrent;
using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;

Random rand = new Random();

ConcurrentQueue<Atacante> atacantes = new ConcurrentQueue<Atacante>();
ConcurrentQueue<Defensor> defensores = new ConcurrentQueue<Defensor>();

List<int> dadoA = new List<int>();
List<int> dadoD = new List<int>();

for (int i = 0; i < 1300; i++)
{
    Atacante Atacante = new Atacante();
    atacantes.Enqueue(Atacante);
}

for (int i = 0; i < 800; i++)
{
    Defensor Defensor = new Defensor();
    defensores.Enqueue(Defensor);
}

int qtdD = defensores.Count();
int qtdA = atacantes.Count();

int K = 1000;
int vD = 0;
int vA = 0;


for (int m = 0; m < K; m++)
{
    // var dt = DateTime.Now;

    for (int i = 0; i < qtdD + qtdA; i += 3)
    {
        if (atacantes.Count() < 2 || defensores.Count() < 1)
            break;

        for (int j = 0; j < 3; j++)
        {
            dadoA.Add(rand.Next(1, 7));
            dadoD.Add(rand.Next(1, 7));
        }

        dadoA.Sort();
        dadoD.Sort();

        for (int q = 0; q < 3; q++)
        {
            if (dadoA[q] > dadoD[q])
            {
                defensores.TryDequeue(out _);
            }
            else
            {
                atacantes.TryDequeue(out _);

            }
        }

        dadoA.Clear();
        dadoD.Clear();
    }

    if (atacantes.Count() > defensores.Count())
    {
        
        vA++;
    }
    else
    {
        vD++;
    }

    Console.WriteLine("def " + defensores.Count() + " atacantes " + atacantes.Count());
    for (int i = 0; i < 1300; i++)
    {
        Atacante Atacante = new Atacante();
        atacantes.Enqueue(Atacante);
    }

    for (int i = 0; i < 800; i++)
    {
        Defensor Defensor = new Defensor();
        defensores.Enqueue(Defensor);
    }

}



// double probabilidadeAtacante = (vA * 100) / K;
// double probabilidadeDefensores = (vD * 100) / K;

Console.WriteLine("Vit atacante: " + vA);
Console.WriteLine("Vit defD: " + vD);

// Console.WriteLine($"Defensores {probabilidadeDefensores} % / Atacantes {probabilidadeAtacante} % ");
