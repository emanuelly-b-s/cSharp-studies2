
using System;
using System.Collections.Concurrent;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;

Random rand = new Random();


ConcurrentQueue<Atacante> atacantes = new ConcurrentQueue<Atacante>();

ConcurrentQueue<Defensor> defensores = new ConcurrentQueue<Defensor>();

List<int> dadoA = new List<int>();
List<int> dadoD = new List<int>();

for (int i = 0; i < 1500; i++)
{
    Atacante Atacante = new Atacante();
    atacantes.Enqueue(Atacante);
}

for (int i = 0; i < 1500; i++)
{
    Defensor Defensor = new Defensor();
    defensores.Enqueue(Defensor);
}

int qtdD = defensores.Count();
int qtdA = atacantes.Count();

Exercito exercito = new Exercito(qtdA, qtdD);

// Console.WriteLine(exercito.qtdAtacantes);
// Console.WriteLine(exercito.qtdDefensores);
for (int i = 0; i < 3; i++)
{
   dadoA.Add(rand.Next(1, 7));
   dadoD.Add(rand.Next(1, 7));
}

dadoA.Sort();
dadoD.Sort();

foreach (var item in dadoA)
{
    Console.WriteLine(item);
}
foreach (var item in dadoD)
{
    Console.WriteLine(item);
}


















