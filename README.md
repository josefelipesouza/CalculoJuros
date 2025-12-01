📘 API de Cálculo de Juros

API desenvolvida em .NET 8, utilizando arquitetura em camadas (API, Application, Domain, Infrastructure).
Permite calcular juros, multa e valor final de um pagamento atrasado com base na data de vencimento.

🚀 Executando o Projeto

Abra o terminal na pasta da API:

\CalculoJuros\CalculoJuros.API>


Execute:

dotnet run


Se tudo estiver certo, aparecerá algo assim:

Now listening on: http://localhost:5136  
Application started.  
Hosting environment: Development


A API ficará disponível em:

👉 http://localhost:5136

📄 Acessando o Swagger

O Swagger é a interface interativa da API.

Acesse:

👉 http://localhost:5136/swagger/index.html

No Swagger você pode:

Ver toda a documentação da API

Testar endpoints pelo navegador

Ver exemplos de Request e Response

Inspecionar modelos e tipos

💲 Calculando Juros

A API possui uma rota principal:

POST /api/CalculoJuros/calcular

Ela recebe o valor original e a data de vencimento, calculando:

Multa

Juros acumulado

Valor final com acréscimos

Dias de atraso

📡 Exemplo de Requisição cURL
curl -X 'POST' \
  'http://localhost:5136/api/CalculoJuros/calcular' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "valor": 1000,
  "dataVencimento": "2025-11-28T22:56:07.886Z"
}'

🔍 Exemplo de Resposta (200 OK)
{
  "valorOriginal": 1000,
  "multa": 0.025,
  "juros": 75,
  "valorFinal": 1075,
  "diasAtraso": 3
}

🧮 Regras de Negócio

✔️ Se a data atual for maior que a data de vencimento → existe atraso
✔️ Juros é calculado aplicando % de Multa por dia de atraso
✔️ O valor final =
valorOriginal + juros

🛠 Tecnologias Utilizadas

.NET 8

C#

Swagger / Swashbuckle

Arquitetura em camadas (API, Application, Domain, Infrastructure)

Injeção de Dependência (DI)

CQRS com Handlers (se estiver usando)
