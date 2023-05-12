
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

Random rand = new Random();

int qtdAtacantes = 1000;
int qtdDefensores = 585;


int K = 10_000;
int vD = 0;
int vA = 0;

ConcurrentQueue<Atacante> atacantes = new ConcurrentQueue<Atacante>();
ConcurrentQueue<Defensor> defensores = new ConcurrentQueue<Defensor>();

void LimpaJogadores(ConcurrentQueue<Atacante> atacantes, ConcurrentQueue<Defensor> defensores)
{
    while (defensores.Count > 0)
    {
        defensores.TryDequeue(out _);
    }

    while (atacantes.Count > 0)
    {
        atacantes.TryDequeue(out _);
    }
}

void Batalha(ConcurrentQueue<Atacante> atacantes, ConcurrentQueue<Defensor> defensores)
{
    LimpaJogadores(atacantes, defensores);
    CriandoAtaques(qtdAtacantes);
    CriandoDefensores(qtdDefensores);

    List<int> dadoA = new List<int>();
    List<int> dadoD = new List<int>();

    for (int i = 0; i < qtdAtacantes + qtdDefensores; i += 3)
    {
        if (atacantes.Count() == 1 || defensores.Count() < 1)
            break;

        int menorNumSoldados = 3;

        if (atacantes.Count() < 3 || defensores.Count() < 3)
            menorNumSoldados = 2;

        for (int j = 0; j < menorNumSoldados; j++)
        {
            dadoA.Add(rand.Next(1, 7));
            dadoD.Add(rand.Next(1, 7));
        }

        dadoA.Sort();
        dadoD.Sort();

        for (int q = 0; q < menorNumSoldados; q++)
        {
            var x = dadoA[q] > dadoD[q] ? defensores.TryDequeue(out _) : atacantes.TryDequeue(out _);
        }
        dadoA.Clear();
        dadoD.Clear();
    }

    int sobrouA = atacantes.Count();
    int sobrouD = defensores.Count();

    if (sobrouA > sobrouD)
    {
        vA++;
    }
    else
    {
        vD++;
    }
}

ConcurrentQueue<Atacante> CriandoAtaques(int qtdAtacantes)
{
    for (int i = 0; i < qtdAtacantes; i++)
    {
        Atacante Atacante = new Atacante();
        atacantes.Enqueue(Atacante);
    }

    return atacantes;
}

ConcurrentQueue<Defensor> CriandoDefensores(int qtdAtacantes)
{
    for (int i = 0; i < qtdDefensores; i++)
    {
        Defensor Defensor = new Defensor();
        defensores.Enqueue(Defensor);
    }

    return defensores;
}

void Paralelo()
{
    Parallel.For(0, K, i =>
    {
        Batalha(atacantes, defensores);
    });
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
Paralelo();
stopwatch.Stop();

//Metodo Monte Carlo
// for (int m = 0; m < K; m++)
// {
//     Batalha(atacantes, defensores);

// }


double probabilidadeAtacante = (vA * 100) / K;
double probabilidadeDefensores = (vD * 100) / K;

Console.WriteLine("Vit atacante: " + vA);
Console.WriteLine("Vit defD: " + vD);

Console.WriteLine($"Concluído em  {stopwatch.ElapsedMilliseconds} ms.");
Console.WriteLine($"Defensores {probabilidadeDefensores} % / Atacantes {probabilidadeAtacante}% ");