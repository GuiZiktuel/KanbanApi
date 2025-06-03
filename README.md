# KanbanApi

API desenvolvida em .NET 8 para gerenciamento de cartões (cards) em um sistema Kanban. Permite criar, listar, atualizar e remover cards, facilitando o controle de tarefas e fluxos de trabalho.

## Funcionalidades

- **CRUD de Cards:**  
  - Criar, consultar, atualizar e deletar cartões.
- **Validações:**  
  - Campos obrigatórios e limites de tamanho para os dados dos cards.
- **Estrutura em Camadas:**  
  - Separação clara entre Controllers, Services, Repositories e Models.

## Modelo Card

O modelo principal da API é o `Card`, com os seguintes campos:

- `Id` (int): Identificador único.
- `Nome` (string, obrigatório, até 50 caracteres): Nome do card.
- `Tipo` (string, obrigatório): Tipo ou categoria do card.
- `DataCriacao` (DateTime, obrigatório): Data de criação do card.
- `DataEntrega` (DateTime?, opcional): Data de entrega prevista ou realizada.

