# Organizador de Tarefas

## Link do Deploy

Aplicação CLI executada localmente via terminal conforme instruções abaixo.

---

## Descrição

Sistema de gerenciamento de tarefas desenvolvido em C# no console, com integração à API pública de frases motivacionais.

---

## Funcionalidades

- Adicionar tarefas
- Listar tarefas
- Remover tarefas
- Exibição de frases motivacionais
- Integração com API pública
- Teste de integração automatizado

---

## Tecnologias Utilizadas

- C#
- .NET
- Git e GitHub
- xUnit
- API ZenQuotes

---

## Integração com API

O projeto utiliza a API pública ZenQuotes para buscar frases motivacionais em tempo real.

---

## Teste de Integração

Foi implementado um teste automatizado para validar o funcionamento da integração com a API externa.

O teste verifica:

- conexão com a API;
- retorno de dados;
- funcionamento correto da integração.

---

## Como Executar o Projeto

### Clone o repositório

```bash
git clone https://github.com/heloizadiniz/TaskManager
```

### Execute o projeto

```bash
dotnet run
```

---

## Estrutura do Projeto

- Program.cs → Interface principal do sistema
- TaskService.cs → Regras de gerenciamento das tarefas
- MotivacaoService.cs → Integração com API motivacional
- Tarefa.cs → Modelo das tarefas
- TaskManager.Tests → Testes automatizados

---

## Fluxo Git Utilizado

Para desenvolvimento da entrega intermediária foi utilizada a branch:

```bash
entrega-intermediaria
```

O fluxo incluiu:

- criação de Issue;
- desenvolvimento em branch separada;
- Push para GitHub;
- Pull Request;
- Merge na branch principal.

---

## Autora

Heloiza Diniz Figueredo
