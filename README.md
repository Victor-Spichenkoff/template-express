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


## Quer mais controle? Aqui estão os parâmetros disponíveis
- **-o [nome]:**  Define o nome da pasta de saída (deve ser seguido do nome)

- **--js:** Usar Javascript, ao inves de Typescript
- **--no-prisma:** Não usar o prisma como ORM
- **--current-dir:** Define que o projeto deve ser criado na pasta atual, sem criar uma nova pasta
- **--config:** Cria um prompt para configurar tudo de forma manual e com uma interface mais agradável
- **--stock:** Cria um de forma minimalista (apenas o express e app básico); Essa opção mantém o typescript, use ```--js``` para mudar
- **--no-middlwares:** Cria o projeto, mas não usa middlewares
- **--code** Abre o projeto no Visual Studio Code


## Valores padrão
Segue os valores usados caso o parâmetro não seja fornecido
- **-o:**  express
- **--js:** no (usar TypeScript)
- **--no-prisma:** no (usar Prisma)
- **--current-dir:** no (cria uma subpasta com o valor de **-o**)
- **--config:** no
- **--stock:** no (cria a api de forma comlpleta)
- **--no-middlwares:** no (usa middlwares)