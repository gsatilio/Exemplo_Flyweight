using Exemplo_Flyweight;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // O código do cliente normalmente pré popula alguns flyweights na etapa de inicialização da aplicação.
        var factory = new FlyweightFactory(
            new Unidade { Tipo = "Cavalo"},
            new Unidade { Tipo = "Soldado"},
            new Unidade { Tipo = "Elefante" },
            new Unidade { Tipo = "Arqueiro"}
           );

        // Primeira impressão Flyweight
        factory.listarFlyweights();

        // Inserção de 3 televisores
        atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Barco",
            Time = "azul",
            Atacando = false,
            PosicaoX = 150,
            PosicaoY = 200
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Soldado",
            Time = "vermelho",
            Atacando = true,
            PosicaoX = 80,
            PosicaoY = 325
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Balista",
            Time = "azul",
            Atacando = true,
            PosicaoX = 20,
            PosicaoY = 570
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Arqueiro",
            Time = "azul",
            Atacando = true,
            PosicaoX = 175,
            PosicaoY = 203
        });

        // Segunda impressão Flyweight
        factory.listarFlyweights();
    }
    public static void atualizarTelaJogador(FlyweightFactory factory, Unidade tv)
    {
        Console.WriteLine("_".PadLeft(80, '_'));
        Console.WriteLine("\nAtualizando unidades na tela do jogador.");
        Console.WriteLine(tv.getKeyItens());

        var flyweight = factory.GetFlyweight(new Unidade
        {
            Tipo = tv.Tipo
        });

        // O código do cliente armazena ou calcula o estado extrínseco e passa para os métodos do flyweight.
        flyweight.Operacao(tv);
    }
}