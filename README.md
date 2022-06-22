# WebScrapingBR
- Web scraping da tabela do brasileirão os 5 primeiros colocados

## Tecnologias
- C# 
- .NET 6
- Selenium

## Funcionamento
- A partir do selenium fazemos uma consulta ao link da tabela do brasileirão na WEB.
    - Após isso, vemos os elementos HTML que correspondem a tabela e aos times. Sendo, a partir de sua classe(class) css
    - Por fim, pegamos apenas os valores que correspondem respectivamente a Posição, Nome e Pontuação

## Para se divertir 
- Conectar a aplicação a um banco de dados.
- Criar uma tabela com as colunas pré-definidas a partir da classe Model/Brasileirao.cs
- Para rodar no console
    - ` dotnet run `
