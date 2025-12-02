# 🔗 DevEncurtaUrl.API

Uma API RESTful robusta para encurtamento de URLs e redirecionamento, desenvolvida em **C# com . NET 7.0**.  Este projeto oferece uma solução completa para gerenciar e redirecionar URLs encurtadas com logging avançado e documentação interativa.

---

## 📋 Índice

- [Visão Geral](#visão-geral)
- [Características](#características)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Pré-requisitos](#pré-requisitos)
- [Instalação e Configuração](#instalação-e-configuração)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Configuração do Banco de Dados](#configuração-do-banco-de-dados)
- [Endpoints da API](#endpoints-da-api)
- [Documentação Swagger](#documentação-swagger)
- [Logging](#logging)
- [CORS](#cors)
- [Como Contribuir](#como-contribuir)
- [Contato](#contato)

---

## 🎯 Visão Geral

O **DevEncurtaUrl.API** é uma solução completa para a criação, gerenciamento e redirecionamento de URLs encurtadas. A API foi desenvolvida seguindo os padrões de desenvolvimento moderno, com suporte a logging estruturado, persistência de dados com Entity Framework Core e documentação automática via Swagger/OpenAPI.

---

## ✨ Características

- ✅ **Encurtamento de URLs**: Converta URLs longas em URLs curtas e memoráveis
- ✅ **Redirecionamento Automático**: Redirecione para a URL original automaticamente
- ✅ **Logging Avançado**: Sistema de logging estruturado com Serilog, armazenando logs no SQL Server
- ✅ **Documentação Interativa**: Swagger UI integrada para testar endpoints em tempo real
- ✅ **CORS Habilitado**: Suporte a requisições de diferentes origens
- ✅ **Entity Framework Core**: ORM poderoso para gerenciar dados
- ✅ **SQL Server Integration**: Persistência de dados confiável
- ✅ **Migrations**: Versionamento automático do schema do banco de dados

---

## 🛠️ Tecnologias Utilizadas

### Framework e Runtime
- **[.NET 7.0](https://dotnet.microsoft.com/)** - Framework de desenvolvimento
- **C#** - Linguagem de programação
- **ASP.NET Core** - Framework web

### Pacotes NuGet
| Pacote | Versão | Descrição |
|--------|--------|-----------|
| `Microsoft.AspNetCore.OpenApi` | 7.0.11 | Suporte a OpenAPI/Swagger |
| `Microsoft.EntityFrameworkCore. SqlServer` | 7.0. 12 | Provedor SQL Server para EF Core |
| `Microsoft. EntityFrameworkCore.Design` | 7.0.12 | Ferramentas de design para EF Core |
| `Microsoft.EntityFrameworkCore.InMemory` | 7.0.12 | Provedor em memória para testes |
| `Serilog.AspNetCore` | 6.1.0 | Logging estruturado |
| `Serilog.Sinks. MSSqlServer` | 6.2. 0 | Sink para armazenar logs no SQL Server |
| `Swashbuckle.AspNetCore` | 6.5.0 | Gerador de documentação Swagger |

### Banco de Dados
- **SQL Server** - Banco de dados relacional para persistência
- **Entity Framework Core** - ORM para acesso aos dados

---

## 📦 Pré-requisitos

Antes de começar, certifique-se de ter os seguintes itens instalados:

- [.NET SDK 7.0](https://dotnet.microsoft.com/download) ou superior
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) (Express ou Premium)
- [Git](https://git-scm. com/)
- Um editor de código, como [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

---

## 🚀 Instalação e Configuração

### 1. Clonar o Repositório

```bash
git clone https://github. com/juliobacoli/DevEncurtaUrl.API. git
cd DevEncurtaUrl.API