# Nava.People.Api

Bem-vindo à documentação da API de Consulta de Dados de Pessoas Nava. Esta API permite consultar informações sobre pessoas.

## Autenticação

A autenticação na API é realizada usando **Basic Authentication**. Para acessar os endpoints protegidos, as credenciais de autenticação serão enviadas por e-mail.

## Dados

Os dados das pessoas estão armazenados em um arquivo JSON localizado na pasta "database" do projeto. O arquivo contém informações como nome, sobrenome, documento, idade, endereço e número de telefone de cada pessoa.

## Endpoints

### Listar Todas as Pessoas

Retorna uma lista de todas as pessoas cadastradas.

- **URL:** `/api/person`
- **Método:** GET
- **Resposta:** JSON contendo a lista de pessoas

### Buscar Pessoa por Documento

Busca uma pessoa com base no número do documento.

- **URL:** `/api/person/{document}`
- **Método:** GET
- **Parâmetros:** `{document}` é o número do documento da pessoa
- **Resposta:** JSON contendo os detalhes da pessoa ou uma mensagem de erro caso não seja encontrada

## Exemplo de Uso

### Listar Todas as Pessoas

**URL:** `/api/people`

```http
GET /api/people
[
    {
        "id": 1,
        "firstName": "João",
        "lastName": "Silva",
        "document": "123456789",
        "age": 30,
        "address": "Rua das Flores, 123",
        "phoneNumber": "(11) 98765-4321"
    },
    // ... outras pessoas
]
```


### Buscar Pessoa por Documento

**URL:** `/api/people/123456789`

```http
GET /api/people/123456789
{
    "id": 1,
    "firstName": "João",
    "lastName": "Silva",
    "document": "123456789",
    "age": 30,
    "address": "Rua das Flores, 123",
    "phoneNumber": "(11) 98765-4321"
}
```
## Como Usar

1. Clone este repositório.
2. Configure as dependências e execute a aplicação.
3. Acesse os endpoints descritos acima utilizando um cliente HTTP ou ferramentas como o Postman.

## Autor
Carolina Campioni

