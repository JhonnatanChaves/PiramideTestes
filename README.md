# 🔺 Pirâmide de Testes 🚀

Este projeto visa colocar em prática os aprendizados do curso **Construindo uma Pirâmide de Testes com .NET: Estratégias e Implementação Prática**.  

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

## 📂 **Estrutura do Projeto**

```
PiramideTestes/

📚 Biblioteca de classes principal  
├── Pyramid.Core/               
│   ├── Dominio/              
│   │   ├── Produto.cs         
│   │   ├── ProdutoItem.cs     
│   ├── Pyramid.Core.csproj    
│
🧪 Projeto de testes automatizados  
├── Pyramid.Testes/            
│   ├── Pyramid.Testes.csproj    
│   ├── 1-UnitTests/            
│   │   ├── PedidosTestes.cs   
│   ├── 2-IntegrationTests/     
│   │   ├── PedidoTestesIntegracao.cs  
│   ├── 3-SystemTests/        
│   │   ├── TestesSistema.cs   
│   ├── 4-Features/           
│   │   ├── Pedido.feature     
│   ├── 5-Steps/              
│   │   ├── PedidoSteps.cs     
│   ├── 6-TestResults/        
│   │   ├── TestResults.trx    
│  
├── PiramideTestes.sln


```


---

🚀 **Bora testar?** 💪✨

Para a execução do projeto de Piramide.Testes use uma das seguintes opções:

- Para rodar os testes e coletar a cobertura, execute: dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=json
  
- Você também pode executar o projeto com o relatório de testes, basta fazer: dotnet test --logger "trx;LogFileName=TestResults.trx"

Caso você esteja usando o visual studio 2022 e opite pela geração do relatório de testes, você pode acessar o arquivo TestResults.trx no visual studio 2022 e se deparar com a seguinte exibição:

![image](https://github.com/user-attachments/assets/41f8e2cc-e7e8-4159-b28e-ce5394959463)



