using OpenQA.Selenium;

namespace WebScraping
{
    public class BrasileiraoService 
    {
        BrasileiraoRepository brRepository = new BrasileiraoRepository();

        public void registrarTimes(List<IWebElement> posicoes, List<IWebElement> nomes, List<IWebElement> pontos)  
        {
            Brasileirao time;
            List<Brasileirao> brasileirao = new List<Brasileirao>();
            var pontuacoes = tratandoPontuacao(pontos);

            for(int i=0; i < posicoes.Count; i++) {
                
                time = new Brasileirao(
                    Convert.ToInt32(posicoes[i].Text.ToString()),
                    nomes[i].Text,
                    pontuacoes[i]
                );

                brasileirao.Add(time);       
            }
            
            brRepository.registrarTimes(brasileirao);
        }

        public List<int> tratandoPontuacao(List<IWebElement> pontos) 
        {
            var pontuacao = new List<int>();
        
            for(int i=0; i < pontos.Count; i++) 
            {
                switch(i) 
                {
                    case 0: 
                        pontuacao.Add(Convert.ToInt32(pontos[i].Text));
                        break;
                    case 9: 
                        pontuacao.Add(Convert.ToInt32(pontos[i].Text));
                        break;
                    case 18: 
                        pontuacao.Add(Convert.ToInt32(pontos[i].Text));
                        break;
                    case 27: 
                        pontuacao.Add(Convert.ToInt32(pontos[i].Text));    
                        break;
                    case 36: 
                        pontuacao.Add(Convert.ToInt32(pontos[i].Text));
                        break;
                }
            }
            
            return pontuacao;
        }
    }
}