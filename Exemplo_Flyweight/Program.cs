using Exemplo_Flyweight;
internal class Program
{
    private static void Main(string[] args)
    {
        // O código do cliente normalmente pré popula alguns flyweights na etapa de inicialização da aplicação.
        var factory = new FlyweightFactory(
            new Unidade { Imagem = "Cavalo.jpeg" },
            new Unidade { Imagem = "Soldado.jpeg" },
            new Unidade { Imagem = "Elefante.jpeg" }
           );

        // Primeira impressão Flyweight
        factory.listarFlyweights();

        // Atualização de Unidades
        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Cavalo.jpeg",
            Time = "azul",
            Atacando = false,
            PosicaoX = 150,
            PosicaoY = 200
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Soldado.jpeg",
            Time = "vermelho",
            Atacando = true,
            PosicaoX = 80,
            PosicaoY = 325
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Arqueiro.jpeg",
            Time = "azul",
            Atacando = true,
            PosicaoX = 20,
            PosicaoY = 570
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Cavalo.jpeg",
            Time = "azul",
            Atacando = true,
            PosicaoX = 175,
            PosicaoY = 203
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Cavalo.jpeg",
            Time = "vermelho",
            Atacando = true,
            PosicaoX = 100,
            PosicaoY = 25
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Balista.jpeg",
            Time = "azul",
            Atacando = false,
            PosicaoX = 321,
            PosicaoY = 79
        });

        atualizarTelaJogador(factory, new Unidade
        {
            Imagem = "Arqueiro.jpeg",
            Time = "azul",
            Atacando = false,
            PosicaoX = 180,
            PosicaoY = 200
        });

        // Segunda impressão Flyweight
        factory.listarFlyweights();
    }
    public static void atualizarTelaJogador(FlyweightFactory factory, Unidade unidade)
    {
        Console.WriteLine("_".PadLeft(80, '_'));
        Console.WriteLine("\nAtualizando unidades na tela do jogador.");
        Console.WriteLine("====>  " + unidade.getKeyItens());

        var flyweight = factory.GetFlyweight(new Unidade
        {
            Imagem = unidade.Imagem
        });

        // O código do cliente armazena ou calcula o estado extrínseco e passa para os métodos do flyweight.
        flyweight.Imprimir(unidade);
    }
}