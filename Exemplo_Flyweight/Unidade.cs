namespace Exemplo_Flyweight
{
    public class Unidade
    {
        public string Tipo {  get; set; }
        public string Time {  get; set; }
        public bool Atacando {  get; set; }
        public int PosicaoX {  get; set; }
        public int PosicaoY {  get; set; }

        public override string ToString()
        {
            return $"[Unidade: {Tipo}]".PadRight(20) +
                $"[Cor: {Time}]".PadRight(20) +
                $"[Atacando: {Atacando}]".PadRight(20) +
                $"[Posicao X: {PosicaoX}]".PadRight(20) +
                $"[Posicao Y: {PosicaoY}]".PadRight(20);
        }

        public string getKeyItens()
        {
            return $"[Unidade: {Tipo}]".PadRight(25);
                /*$"[Cor: {Time}]".PadRight(25); +
                $"[Modelo: {Atacando}]".PadRight(20); +
                "..." +
               $"[Taxa de Atualizacao: {TaxaAtualizacao}]".PadRight(20) +
               $"[Garantia Estendida: {AnosGarantia}]".PadRight(20);*/
        }

        public static void Continue()
        {
            Console.WriteLine("Continuar...");
            Console.ReadKey();
        }
    }
}
