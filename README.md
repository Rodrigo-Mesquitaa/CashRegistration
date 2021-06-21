# CashRegistration
Projeto com Arquitetura de Microsserviço desenvolvido usando .NET 6.0, Core e Entity Framework Core (In Memory).

## Características
- Salvar dados do cartão do cliente e gerar token para registro sem dinheiro.
- Validar o cartão do cliente e os dados do token

## Tecnologias, Arquitetura e Padrões
- ASP.NET Core
- Entity Framework Core (In-Memory)
- Arquitetura limpa com camadas de núcleo, infraestrutura, aplicação e API.
- Padrão de repositório para acesso a dados
- Teste de Unidade usando xUnit e Moq
- Tratamento de erros usando o gerenciador de exceções em ErrorController

## Responsabilidades das camadas
- Núcleo: contém as interfaces dos Serviços de Domínio, Entidades e Repositórios. As classes de entidade usam conjuntos privados em suas propriedades para reforço de imutabilidade.
- Infraestrutura: contém as implementações de Repositórios e a classe DbContext
- Aplicativo: contém os serviços de Aplicativo (responsáveis ​​pelos casos de uso) e Modelos de Visualização e Modelos de Entrada.
- API: contém os controladores e as configurações de injeção de dependência, Swagger, In-Memory DbContext e ErrorHandling.

