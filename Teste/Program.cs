using System;
using System.Collections;

namespace DemoCSharp.FlyweightPattern
{
    //Classe abstrata Flyweight
    abstract class Flyweight
    {
        public abstract void Operacao(string parametro);
    }

    //Classe concreta, implementando a classe abstrata acima
    class ImplementacaoFlyweight : Flyweight
    {
        private string _parametro;

        public ImplementacaoFlyweight()
        {
            _parametro = "";
        }

        public override void Operacao(string parametro)
        {
            _parametro = _parametro + "|" + parametro;
            Console.WriteLine("Implementação de Operação: " + _parametro);
        }
    }

    //Factory para produzir e controler a classe Flyweight
    class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public FlyweightFactory()
        {
            _flyweights.Add("TipoA", new ImplementacaoFlyweight());
            _flyweights.Add("TipoB", new ImplementacaoFlyweight());
            _flyweights.Add("TipoC", new ImplementacaoFlyweight());
        }

        public Flyweight ObterFlyweight(string chave)
        {
            return ((Flyweight)_flyweights[chave]);
        }
    }

    //Classe Main para execução do App
    class MainApp
    {
        static void Main()
        {
            var parametroA = "xpto";
            var parametroB = "xpto2";

            var factory = new FlyweightFactory();

            var fA = factory.ObterFlyweight("TipoA");
            fA.Operacao(parametroA);

            var fB = factory.ObterFlyweight("TipoB");
            fB.Operacao(parametroB);

            var fA2 = factory.ObterFlyweight("TipoA");
            fA2.Operacao(parametroA);

            Console.ReadKey();
        }
    }
}