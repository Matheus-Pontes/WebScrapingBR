namespace WebScraping
{ 
    public class Brasileirao 
    {
        public int posicao { get; set;}
        public string nome { get; set; }
        public int pontos { get; set; }

        public Brasileirao(int posicao, string nome, int pontos)
        {
            this.posicao = posicao;
            this.nome = nome;
            this.pontos = pontos;
        }

        public string toString() 
        {
            return posicao + "º | " + nome + " | " + pontos;
        }
    }
}