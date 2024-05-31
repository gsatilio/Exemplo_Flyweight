namespace Exemplo_Flyweight
{
    // O Flyweight Factory cria e gerencia os objetos Flyweight. Ele garante que
    // flyweights são compartilhados de forma correta. Quando o cliente solicita a
    // flyweight, a factory ou retorna uma instância existente ou cria uma nova, se ainda não existir.
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> _flyweight = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Unidade[] unidade)
        {
            foreach (var elementoAtual in unidade)
            {
                _flyweight.Add(new Tuple<Flyweight, string>(new Flyweight(elementoAtual), this.getKey(elementoAtual)));
            }
        }

        // Retorna um hash de string do Flyweight para o objeto que está sendo inserido
        public string getKey(Unidade key)
        {
            List<string> elements = new List<string>();

            // atributo intrínseco (imutável)
            elements.Add(key.Imagem);


            // atributo extrínseco (mutável)
            if (key.Time != null)
                elements.Add(key.Time);
            if (key.Atacando != false)
                elements.Add(key.Atacando.ToString());
            if (key.PosicaoX != 0)
                elements.Add(key.PosicaoX.ToString());
            if (key.PosicaoY != 0)
                elements.Add(key.PosicaoY.ToString());

            //elements.Sort();

            return string.Join("_", elements);
        }

        // Retorna um Flyweight existente ou um novo, a depender do que vier da hash gerada pela getKey
        public Flyweight GetFlyweight(Unidade unidadeCompartilhado)
        {
            string key = this.getKey(unidadeCompartilhado);

            if (_flyweight.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Não foi encontrado um flyweight, criando um novo.");
                this._flyweight.Add(new Tuple<Flyweight, string>(new Flyweight(unidadeCompartilhado), key));
                Console.WriteLine($"Key gerada:   {this.getKey(unidadeCompartilhado)}");
            }
            else
            {
                Console.WriteLine("********** FlyweightFactory: REUTILIZANDO flyweight já criado. **********");
                Console.WriteLine($"Key Reutilizada:   {this.getKey(unidadeCompartilhado)}");
            }
            return this._flyweight.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        // Imprime os meus Flyweight
        public void listarFlyweights()
        {
            var count = _flyweight.Count;
            Console.WriteLine($"\nFlyweightFactory: {count} flyweights keys localizadas:");
            foreach (var flyweight in _flyweight)
            {
                Console.WriteLine(flyweight.Item2);
            }
            Console.WriteLine("\nQue equivalem aos objetos intrínsecos:");
            Console.WriteLine($"\n       [Imagem]           [Time]  [Atacando]  [PosicaoX]  [PosicaoY]");
            foreach (var flyweight in _flyweight)
            {
                Console.WriteLine(flyweight.Item1.getKeyItens());
            }
            Unidade.Continue();
        }
    }
}
