# CashFlowControl

## DescriÃ§Ã£o

Este projeto controla o fluxo de caixa diÃ¡rio de um comerciante, permitindo lanÃ§amentos de dÃ©bitos e crÃ©ditos e gerando um relatÃ³rio consolidado diÃ¡rio.

## Estrutura do Projeto

- **Core**: ContÃ©m as entidades, interfaces e serviÃ§os principais.
- **Infrastructure**: ImplementaÃ§Ãµes especÃ­ficas para persistÃªncia e outras dependÃªncias.
- **Application**: ContÃ©m os casos de uso e serviÃ§os da aplicaÃ§Ã£o.
- **Presentation**: APIs e interfaces de usuÃ¡rio.
- **Tests**: ContÃ©m os testes unitÃ¡rios e de integraÃ§Ã£o.

## Como Rodar Localmente

1. Clone o repositÃ³rio:
    \\\ash
    git clone https://github.com/SeuUsuario/CashFlowControl.git
    cd CashFlowControl
    \\\

2. Restaure as dependÃªncias:
    \\\ash
    dotnet restore
    \\\

3. Execute os testes:
    \\\ash
    dotnet test
    \\\

4. Execute a aplicaÃ§Ã£o:
    \\\ash
    dotnet run --project Presentation
    \\\

5. Acesse o Swagger UI:
    Abra o navegador e navegue para \https://localhost:5001/swagger/index.html\ para visualizar e testar os endpoints da API.

## Endpoints

- \POST /api/transactions\: Adiciona uma nova transaÃ§Ã£o.
- \GET /api/transactions/consolidated?date=YYYY-MM-DD\: ObtÃ©m o saldo consolidado diÃ¡rio para a data especificada.

## Tecnologias Utilizadas

- .NET 6
- InjeÃ§Ã£o de DependÃªncia
- BDD e TDD
- Clean Code
- SOLID
- Moq para testes
- Swagger para documentaÃ§Ã£o da API

## ContribuiÃ§Ãµes

Sinta-se Ã  vontade para contribuir com melhorias ou novas funcionalidades. Para isso, faÃ§a um fork do projeto, crie uma branch com sua feature e abra um pull request.

## LicenÃ§a

MIT
