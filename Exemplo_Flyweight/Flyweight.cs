namespace Exemplo_Flyweight
{
    // O Flyweight armazena uma parte comum de estado (também chamado de estado intrínseco)
    // que pertence a múltiplas entidades. O Flyweight aceita o resto do estado
    // (estado extrínseco, único para cada entidade) através de seus parâmetros de métodos.
    public class Flyweight
    {

        private Unidade _estadoCompartilhado;
        //private string _imagem;

        public Flyweight(Unidade unidade)
        {
            this._estadoCompartilhado = unidade;
        }

        public void Imprimir(Unidade unico)
        {
            string s = this._estadoCompartilhado.getKeyItens();
            string u = unico.Mutavel().ToString();
            Console.WriteLine($"\nFlyweight exibindo: " +
                              $"\nCompartilhado (Intrínseco): {s}" +
                              $"\nÚnico (Extrínseco):         {u}" +
                              $"\n\nObjeto criado: {unico}");
            Console.WriteLine("-".PadLeft(80, '-'));
            Unidade.Continue();
        }

        public string getKeyItens()
        {
            return this._estadoCompartilhado.getKeyItens();
        }
    }
}
