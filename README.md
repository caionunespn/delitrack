# DELITRACK

Bem-vindo ao projeto DELITRACK - Rastreador de Entrega! Este projeto foi desenvolvido como uma aplicação de estudo para aprimorar habilidades em ASP.NET Core. Utilizei as tecnologias .NET 8, ASP.NET Core, Entity Framework, SignalR e Next.js para o frontend.

![Funcionamento do Frontend - Uma moto percorrendo um caminho de entrega no Google Maps](https://github.com/caionunespn/delitrack/blob/master/delitrack.gif?raw=true)

## Funcionalidades

O backend oferece as seguintes funcionalidades:

### Motoristas
- **Criar Motorista:** Registre novos motoristas no sistema.
- **Listar Motoristas:** Obtenha uma lista de todos os motoristas cadastrados.
- **Atualizar Motorista:** Modifique informações de um motorista existente.

### Clientes
- **Criar Cliente:** Cadastre novos clientes no sistema.
- **Listar Clientes:** Visualize uma lista de todos os clientes cadastrados.

### Lojas
- **Criar Loja:** Adicione novas lojas ao sistema.
- **Listar Lojas:** Veja todas as lojas disponíveis.

### Pedidos
- **Criar Pedido:** Realize pedidos associados a um cliente e uma loja.
- **Listar Pedidos:** Obtenha uma lista de todos os pedidos efetuados.

### Rastreamento em Tempo Real
- Utilização do SignalR para comunicação em tempo real.
- Um WebSocket que comunica o rastreamento do motorista para o cliente no frontend.

## Tecnologias Utilizadas

- [**Backend:**](https://github.com/caionunespn/delitrack)
  - .NET 8 com ASP.NET Core
  - Entity Framework para persistência de dados
  - SignalR para comunicação em tempo real

- [**Frontend:**](https://github.com/caionunespn/delitrackapp)
  - Next.js para a construção da interface do usuário
  - Google Maps para a apresentação interativa do mapa