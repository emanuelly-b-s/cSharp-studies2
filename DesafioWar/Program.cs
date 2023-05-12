
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;


Random rand = new Random();

const int qtdAtacantes = 1000;
const int qtdDefensores = 583;

const int qtdDados = 22 * (qtdAtacantes + qtdDefensores) / 10;

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

    if (atacantes.Count() > defensores.Count())
        vA++;
    else
        vD++;
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

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Parallel.For(0, K, i =>
{
    byte[] data = new byte[qtdDados];
    lock(rand)
    {
        rand.NextBytes(data);
    }
    // Interlocked
    Batalha(atacantes, defensores);
});

stopwatch.Stop();

//Metodo Monte Carlo
// for (int m = 0; m < K; m++)
// {
//     Batalha(atacantes, defensores);

// }
Console.WriteLine("Vit atacante: " + vA);
Console.WriteLine("Vit defD: " + vD);

Console.WriteLine($"Concluído em  {stopwatch.ElapsedMilliseconds} ms.");
Console.WriteLine($"Defensores {(vD * 100) / K} % / Atacantes {(vA * 100) / K}% ");