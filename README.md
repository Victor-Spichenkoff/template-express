# Full template for express + prisma + Typescript

Para criar um projeto completo basta rodar:
```
npx vss-express create
```

## Execução
Esse comportamento se refere ao comando sem nenhum parâmetro (default)

Fique tranquilo, pois você poderá alterar tudo isso

1. Será crida uma subpasta no diretório atual chamada **express**
1. Um projeto será iniciado (criação do **package.json** e adição dos comandos básicos)
1. A pasta **src** será criada
1. Será instalado o express e os devidos tipos
1. O arquivo **app.ts** será criado, com tudo configurado e pronta para rodar
1. Será adicionado o **roteamento**
1. Será adicionado **Prisma** e o **banco de dados**
1. Garante a criação **segura** de uma instância do **prisma client**


## Quer mais controles? Aqui estão os parâmetros disponíveis
- **-o:**  Define o nome da pasta de saída (deve ser seguido do nome)
- **--js:** Usar Javascript, ao inves de Typescript
- **--no-prisma:** Não usar o prisma como ORM
- **--current-dir:** Define que o projeto deve ser criado na pasta atual, sem criar uma nova pasta
- **--config:** Cria um prompt para configurar tudo de forma manual e com uma interface mais agradável


## Valores padrão
Segue os valores usados caso o parâmetro não seja fornecido
- **-o:**  express
- **--js:** Sem  ele, usa-se Typescript
- **--no-prisma:** Sem ele, usa-se a biblioteca Prisma 
- **--current-dir:** Sem ele, cria uma subpasta no diretório atual com o valor de **-o** (express)
- **--config:** Sem ele, não se cria o prompt