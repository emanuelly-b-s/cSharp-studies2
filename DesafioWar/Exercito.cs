
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

public class Exercito
{
    public int qtdAtacantes { get; set; }
    public int qtdDefensores { get; set; }

    public Exercito(int qtdAtacantes, int qtdDefensores)
    {
        this.qtdAtacantes = qtdAtacantes;
        this.qtdDefensores = qtdDefensores;
    }

}

public class Defensor
{
    // ConcurrentQueue<Exercito> atacantes = new ConcurrentQueue<Exercito>();
    public int NumSoldados { get; set; }
}

public class Atacante
{
    // ConcurrentQueue<Exercito> atacantes = new ConcurrentQueue<Exercito>();
    public int NumSoldados { get; set; }
}


// }