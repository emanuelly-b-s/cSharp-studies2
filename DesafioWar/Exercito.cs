
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

public class Exercito
{
    public int NumSoldados { get; set; }
    public Exercito(int numeroSoldados) => NumSoldados = numeroSoldados;

}

public class Atacantes : Exercito
{
    ConcurrentQueue<Exercito> atacantes = new ConcurrentQueue<Exercito>();

    public Atacantes(int numeroSoldados) : base(numeroSoldados)
    {
        NumSoldados = numeroSoldados;
    }

}

public class Defensores : Exercito
{
    ConcurrentQueue<Exercito> atacantes = new ConcurrentQueue<Exercito>();

    public Defensores(int numeroSoldados) : base(numeroSoldados)
    {
        NumSoldados = numeroSoldados;
    }

}