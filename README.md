# 🏗️ Pirâmide de Testes 🚀

Este projeto visa colocar em prática os aprendizados do curso  
**"Construindo uma Pirâmide de Testes com .NET: Estratégias e Implementação Prática"**.  

## 🛒 Sobre a Aplicação  
A aplicação desenvolvida é um **sistema de pedidos**, onde as regras de negócio incluem:  

✅ Um **pedido** deve ter pelo menos **um item** para ser válido.  
✅ O **total do pedido** é a soma dos valores de cada item.  
✅ Um **item de pedido** deve ter quantidade maior que **zero**.  
✅ **Descontos aplicados** não podem gerar valores negativos.  
✅ Pedidos acima de **R$500** recebem **frete grátis**.  

---

## 🔍 **Testes Realizados** 🧪  

🔹 **Testes Unitários** – Validação de regras de negócio individuais.  
🔹 **Testes de Integração** – Verificação do funcionamento entre componentes.  
🔹 **Testes de Sistema** – Simulação do uso da aplicação de ponta a ponta.  
🔹 **Testes de Aceitação** – Validação dos requisitos do usuário final.  

---

## 🛠️ **Stack Tecnológica** 🚀  

⚙️ **XUnit** – Framework para testes unitários.  
⚙️ **SpecFlow** – Testes BDD baseados em comportamento.  
⚙️ **Coverlet** – Ferramenta para cobertura de código.  
⚙️ **.NET Core 9** – Plataforma principal do projeto.  
⚙️ **Moq** – Mocking framework para simulação de dependências.  

---

## 🔺 PiramideTestes

📂 **PiramideTestes/**
├── 📁 **Pyramid.Core/**  
│   ├── 📂 **Dominio/**  
│   │   ├── 📄 **Produto.cs**  
│   │   ├── 📄 **ProdutoItem.cs**  
│   ├── 📄 **Pyramid.Core.csproj**  
│  
├── 📁 **Pyramid.Testes/**  
│   ├── 📄 **Pyramid.Testes.csproj**  
│   ├── 📂 **1-UnitTests/**  
│   │   ├── 📄 **PedidosTestes.cs**  
│   ├── 📂 **2-IntegrationTests/**  
│   │   ├── 📄 **PedidoTestesIntegracao.cs**  
│   ├── 📂 **3-SystemTests/**  
│   │   ├── 📄 **TestesSistema.cs**  
│   ├── 📂 **4-Features/**  
│   │   ├── 📄 **Pedido.feature**  
│   ├── 📂 **5-Steps/**  
│   │   ├── 📄 **PedidoSteps.cs**  
│   ├── 📂 **6-TestResults/**  
│   │   ├── 📄 **TestResults.trx**  
│  
├── 📄 **PiramideTestes.sln**  
---

🚀 **Bora testar?** 💪✨

