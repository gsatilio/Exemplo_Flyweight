namespace Exemplo_Flyweight
{
    // O Flyweight armazena uma parte comum de estado (também chamado de estado intrínseco)
    // que pertence a múltiplas entidades. O Flyweight aceita o resto do estado
    // (estado extrínseco, único para cada entidade) através de seus parâmetros de métodos.
    public class Flyweight
    {
        private Unidade _estadoCompartilhado;

        public Flyweight(Unidade tv)
        {
            this._estadoCompartilhado = tv;
        }

        public void Operacao(Unidade unico)
        {
            string s = this._estadoCompartilhado.ToString();
            string u = unico.ToString();
            Console.WriteLine($"\nFlyweight exibindo: " +
                              $"\nCompartilhado: {s}" +
                              $"\nÚnico:         {u}");
            Console.WriteLine("-".PadLeft(80, '-'));
            Unidade.Continue();
        }

        public string getKeyItens()
        {
            return this._estadoCompartilhado.getKeyItens();
        }
    }
}
