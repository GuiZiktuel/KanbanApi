# KanbanApi

API desenvolvida em .NET 8 para gerenciamento de cart�es (cards) em um sistema Kanban. Permite criar, listar, atualizar e remover cards, facilitando o controle de tarefas e fluxos de trabalho.

## Funcionalidades

- **CRUD de Cards:**  
  - Criar, consultar, atualizar e deletar cart�es.
- **Valida��es:**  
  - Campos obrigat�rios e limites de tamanho para os dados dos cards.
- **Estrutura em Camadas:**  
  - Separa��o clara entre Controllers, Services, Repositories e Models.

## Modelo Card

O modelo principal da API � o `Card`, com os seguintes campos:

- `Id` (int): Identificador �nico.
- `Nome` (string, obrigat�rio, at� 50 caracteres): Nome do card.
- `Tipo` (string, obrigat�rio): Tipo ou categoria do card.
- `DataCriacao` (DateTime, obrigat�rio): Data de cria��o do card.
- `DataEntrega` (DateTime?, opcional): Data de entrega prevista ou realizada.

