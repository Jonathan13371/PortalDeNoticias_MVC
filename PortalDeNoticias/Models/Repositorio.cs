using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Repositorio
    {
        static List<Noticias> ListadeNoticia;//Varivel lista de noticia
        public static List<Noticias> ListadeNoticia1
        {
            get
            {
                if (ListadeNoticia == null)
                {
                    CriarNoticia();
                }
                return ListadeNoticia;
            }
        }

        private static void CriarNoticia()
        {
            ListadeNoticia = new List<Noticias>();
            ListadeNoticia.Add(
                new Noticias
                {
                    Id = 1,
                    Titulo = "Xiaomi 13 Ultra vs Xiaomi 12S Ultra: o que muda entre os celulares",
                    Autor = "Isabele Scavassa",
                    Data = DateTime.Now,
                    Conteudo = "O Xiaomi 13 Ultra foi anunciado em abril de 2023 para substituir o posto " +
                    "ocupado até então pelo Xiaomi 12S Ultra, de 2022. Ambos custam 5.999 yuans na China o " +
                    "que dá R$ 4.420 em conversão direta. Focados em boa experiência fotográfica, os dois " +
                    "celulares de ponta compartilham especificações como lentes elaboradas em parceria com a " +
                    "Leica e tela com suporte a HDR10 Plus e Dolby Vision. No entanto, eles diferem quando o " +
                    "assunto é processamento, já que o produto mais novo atualiza o chip e amplia a memória RAM, " +
                    "que vai de 12 GB na geração anterior para 16 GB na atual." +
                    "Embora nenhum deles esteja disponível no Brasil, há expectativas sobre a chegada do Xiaomi " +
                    "13 Ultra, que pode ser comercializado globalmente no futuro.Nas linhas a seguir, o TechTudo " +
                    "te explica as semelhanças e diferenças de ficha técnica.",





                }



                );
            ListadeNoticia.Add
                (
                new Noticias

                {
                    Id = 2,
                    Titulo = "Como usar a Siri com ChatGPT pelo iPhone",
                    Autor = "Murilo Tunholi",
                    Data = DateTime.Today.AddDays(-4),
                    Conteudo = "Usar a Siri com ChatGPT pelo iPhone é possível, pois a plataforma OpenAI fornece " +
                    "a API necessária para criar um atalho no iOS que integra os dois serviços. Esse atalho permite " +
                    "abrir a assistente da Apple para fazer perguntas ou dar comandos de voz para a inteligência " +
                    "artificial diretamente pelo smartphone, sem a necessidade de acessar um navegador web e digitar " +
                    "as instruções via texto. As respostas geradas são as mesmas mostradas na versão tradicional do " +
                    "ChatGPT. Usar a Siri com ChatGPT pelo iPhone é possível, pois a plataforma OpenAI fornece a API " +
                    "necessária para criar um atalho no iOS que integra os dois serviços. Esse atalho permite abrir a " +
                    "assistente da Apple para fazer perguntas ou dar comandos de voz para a inteligência artificial " +
                    "diretamente pelo smartphone, sem a necessidade de acessar um navegador web e digitar as instruções " +
                    "via texto. As respostas geradas são as mesmas mostradas na versão tradicional do ChatGPT.",

                }

                );

            ListadeNoticia.Add
               (
               new Noticias
               {
                   Id = 3,
                   Autor = "Fernando Sousa",
                   Titulo = "7 motivos pelos quais você ainda precisa de um pen drive em 2022",
                   Conteudo = "Ter um pen drive em 2022 ainda pode ser útil. Além de funcionar como uma solução de armazenamento de " +
                   "dados, o dispositivo de memória flash tem várias utilidades práticas para o dia a dia — mesmo competindo com outras " +
                   "tecnologias mais avançadas. Com um custo baixo e sendo compatível com uma grande variedade de aparelhos, " +
                   "o pen drive pode ser uma ferramenta estratégica para quem trabalha na área de TI ou mesmo para quem precisa " +
                   "levar consigo alguns arquivos essenciais com facilidade. Se você tem um pen drive sobrando aí, a lista que o " +
                   "TechTudo apresenta abaixo vai te ajudar a encontrar diversas novas usabilidades para sua unidade de armazenamento" +
                   " externo, tornando seu pen drive uma ferramenta poderosa para reparo, backup e até mesmo produtividade. " +
                   "1.Pen drive roda sistemas operacionais no PC 2.Portabilidade e praticidade " +
                   "3.Sistemas de armazenamento em nuvem são limitados 4.Documentos confidenciais " +
                   "5.Você pode instalar jogos no seu pen drive",
                   Data = DateTime.Today.AddMonths(-2)
               }
               );

            ListadeNoticia.Add
                    (
                new Noticias
                {
                    Id = 4,
                    Autor = "Danilo Paulo de Oliveira",
                    Titulo = "Leilão tem Apple Watch, Mi Band, Amazfit e Xbox por preços baixos",
                    Conteudo = "A Receita Federal abriu um leilão com diversos produtos eletrônicos para as cidades de Natal (RN) " +
                    "e Recife (PE). Apple Watch, Mi Band, relógios da Amazfit e Xbox One X são alguns dos produtos com preço baixo, " +
                    "ao menos no lance inicial. São dezenas de lotes e boa parte dos produtos estão disponíveis para pessoas físicas. " +
                    "Interessados têm até 30 de setembro às 21h00 para o envio das propostas de valor de compra. Os produtos são fruto " +
                    "de apreensão realizada pelo órgão. Os preços devem ser observados apenas como referência já que podem subir a " +
                    "depender do interesse do público. De acordo com a Receita Federal, os ganhadores do leilão devem retirar os " +
                    "aparelhos de forma presencial, pois o órgão não se responsabiliza pelo envio. Além disso, os equipamentos não" +
                    " têm garantia do fabricante e a Receita não promete o funcionamento. Os relógios e pulseiras inteligentes da " +
                    "Xiaomi dominam os lotes de eletrônicos, que apresentam mais de um produto cada. Um exemplo é o lote 77, que " +
                    "conta com uma unidade do Amazfit Verge Lite, uma unidade do1x Mi Band 4, um Amazfit GTR, dois Amazfit Bip e " +
                    "cinco unidades do Amazfit Bip Lite, com lance inicial de R$ 800 – valor bastante inferior ao preço cobrado " +
                    "por esses modelos no varejo. Já o lote 96 conta com um Apple Watch 6 por R$ 500 de lance inicial. Para pessoas " +
                    "jurídicas, há um número maior de opções, mas os preços iniciais são maiores.",
                    Data = DateTime.Today.AddYears(-1)
                }
                );

            ListadeNoticia.Add
            (
                new Noticias
                {
                    Id = 5,
                    Autor = "Caroline Silvestre",
                    Titulo = "Como deixar o seu navegador de Internet o mais seguro possível",
                    Conteudo = "Google Chrome, Safari e Microsoft Edge contam com recursos próprios que ajudam a reforçar a " +
                    "segurança e privacidade dos seus dados. Isso porque, ao navegar na Internet, os usuários estão sujeitos a " +
                    "ameaças como malwares, ataques hacker e sites de phishing. Para manter os internautas seguros, o Chrome, " +
                    "por exemplo, oferece o recurso de proteção reforçada, que detecta e alerta o usuário sobre a presença de " +
                    "malwares. Já no Safari, é possível ativar a prevenção inteligente contra rastreamento, que impede que sites " +
                    "compartilhem seus dados de navegação. A disponibilidade e configuração desses recursos variam conforme cada " +
                    "navegador. A seguir, confira como ativar as principais funções de segurança do Google Chrome, Safari e " +
                    "Microsoft Edge",
                    Data = DateTime.Today.AddDays(-1)
                }
                );
        }
    }
}
