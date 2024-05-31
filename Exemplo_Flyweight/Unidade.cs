namespace Exemplo_Flyweight
{
    public class Unidade
    {
        public string Imagem {  get; set; }
        public string Time {  get; set; }
        public bool Atacando {  get; set; }
        public int PosicaoX {  get; set; }
        public int PosicaoY {  get; set; }

        public string Mutavel()
        {
            return 
                $"[Time: {Time}]".PadRight(20) +
                $"[Atacando: {Atacando}]".PadRight(20) +
                $"[Posicao X: {PosicaoX}]".PadRight(20) +
                $"[Posicao Y: {PosicaoY}]".PadRight(20);
        }

        public string getKeyItens()
        {
            return $"[Imagem: {Imagem}]";
        }

        public override string ToString()
        {
            return $"[Imagem: {Imagem}]".PadRight(20) +
                $"[Time: {Time}]".PadRight(20) +
                $"[Atacando: {Atacando}]".PadRight(20) +
                $"[Posicao X: {PosicaoX}]".PadRight(20) +
                $"[Posicao Y: {PosicaoY}]".PadRight(20);
        }

        public static void Continue()
        {
            Console.WriteLine("Continuar...");
            Console.ReadKey();
        }
    }
}
