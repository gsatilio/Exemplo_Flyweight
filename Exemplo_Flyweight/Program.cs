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

        // Inserção Unidades
        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Barco",
            Time = "azul",
            Atacando = false,
            PosicaoX = 150,
            PosicaoY = 200
        });

        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Soldado",
            Time = "vermelho",
            Atacando = true,
            PosicaoX = 80,
            PosicaoY = 325
        });

        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Balista",
            Time = "azul",
            Atacando = true,
            PosicaoX = 20,
            PosicaoY = 570
        });

        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Arqueiro",
            Time = "azul",
            Atacando = true,
            PosicaoX = 175,
            PosicaoY = 203
        });

        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Barco",
            Time = "vermelho",
            Atacando = true,
            PosicaoX = 100,
            PosicaoY = 25
        });

        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Elefante",
            Time = "azul",
            Atacando = false,
            PosicaoX = 321,
            PosicaoY = 79
        });

        FlyweightFactory.atualizarTelaJogador(factory, new Unidade
        {
            Tipo = "Barco",
            Time = "azul",
            Atacando = false,
            PosicaoX = 180,
            PosicaoY = 200
        });

        // Segunda impressão Flyweight
        factory.listarFlyweights();
    }
}