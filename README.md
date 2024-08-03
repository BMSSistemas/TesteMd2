# Controle de Fluxo de Caixa

## Descrição

Aplicação para gerenciar lançamentos financeiros e obter saldo diário consolidado.

## Tecnologias

- ASP.NET Core 6
- SQLite
- Entity Framework Core

## Instalação

### 1.Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/controle-fluxo-caixa.git
   cd controle-fluxo-caixa
  ```
### 2.Restaure os Pacotes
  ```bash
     dotnet restore
  ```
### 3.Crie o Banco de Dados e aplique as Migrações
  ```bash
    dotnet ef database updayte
  ```
### 4.Execute a Aplicação
  ```bash
     dotnet run 
  ```
### 5.Acesse os serviços
  - Adicionar Lançamento: POST http://localhost:5000/lancamento
  - Saldo Diário: GET http://localhost:5000/consolidado
## Testes
  ```bash
     dotnet test
  ```
## Hospedagem e Repositório

1. **Crie um repositório no GitHub** e faça o upload do código.
2. **Hospedagem**: Utilize Azure, AWS, ou qualquer outro serviço de cloud para hospedar a aplicação, garantindo escalabilidade e tolerância a falhas.

Esta solução em .NET atende aos requisitos propostos e segue boas práticas de desenvolvimento e arquitetura, garantindo um sistema robusto e escalável para o controle de fluxo de caixa.
