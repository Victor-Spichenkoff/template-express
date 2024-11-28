# Complete Template for Express + Prisma + TypeScript (portguês abaixo)

To create a complete project, just run:
```
npx vss-express create
```


## Execution
#### This behavior refers to the command without any parameters (default).

---
⚠️ Don't worry, you can change all of this! ⚠️

⚠️ At the end, there's an example of what the output will look like ⚠️

---

1. A subfolder named **express** will be created in the current directory.

2. A project will be initialized (creation of **package.json** and addition of basic commands).
3. The **src** folder will be created.
4. Express and the necessary types will be installed.
5. The **app.ts** file will be created, fully configured and ready to run.
6. Routing will be added.
7. Prisma and the database will be added.
8. Ensures the **secure** creation of a **Prisma client** instance.

---

## Want more control? Here are the available parameters
- ```-o [name]:``` Defines the name of the output folder (must be followed by the name).

- ```--js:``` Use JavaScript instead of TypeScript.
- ```--no-prisma:``` Do not use Prisma as ORM.
- ```--current-dir:``` Specifies that the project should be created in the current folder, without creating a new folder.
- ```--config:``` Creates a prompt to manually configure everything with a more user-friendly interface.
- ```--stock:``` Creates a minimalist project (only express and basic app); This option keeps TypeScript, use ```--js``` to switch.
- ```--no-middlewares:``` Creates the project without using middlewares.
- ```--code:``` Opens the project in Visual Studio Code.
- For a quick review: ```-h``` or ```--help```

---

## Default values
Here are the values used if the parameter is not provided:
- ```-o:``` express

- ```--js:``` OFF (use TypeScript)
- ```--no-prisma:``` OFF (use Prisma)
- ```--current-dir:``` OFF (creates a subfolder with the value of **-o**)
- ```--config:``` OFF
- ```--stock:``` OFF (creates the API completely)
- ```--no-middlewares:``` OFF (uses middlewares)
- ```--code:``` OFF (does not open with VSCode)

















<br><br><br>

# Template completo para Express + Prisma + Typescript

Para criar um projeto completo basta rodar:
```
npx vss-express create
```

## Execução
#### Esse comportamento se refere ao comando sem nenhum parâmetro (default).

---
⚠️ Fique tranquilo, pois você poderá alterar tudo isso! ⚠️

⚠️ No final, há um exemplo de como será a saída ⚠️

---

1. Será criada uma subpasta no diretório atual chamada **express**.

1. Um projeto será iniciado (criação do **package.json** e adição dos comandos básicos).
1. A pasta **src** será criada.
1. Será instalado o express e os devidos tipos.
1. O arquivo **app.ts** será criado, com tudo configurado e pronto para rodar.
1. Será adicionado o **roteamento**.
1. Será adicionado **Prisma** e o **banco de dados**.
1. Garante a criação **segura** de uma instância do **prisma client**.

---

## Quer mais controle? Aqui estão os parâmetros disponíveis
- ```-o [nome]:``` Define o nome da pasta de saída (deve ser seguido do nome).

- ```--js:``` Usar Javascript, ao invés de Typescript.
- ```--no-prisma:``` Não usar o Prisma como ORM.
- ```--current-dir:``` Define que o projeto deve ser criado na pasta atual, sem criar uma nova pasta.
- ```--config:``` Cria um prompt para configurar tudo de forma manual e com uma interface mais agradável.
- ```--stock:``` Cria de forma minimalista (apenas o express e app básico); Essa opção mantém o Typescript, use ***--js*** para mudar.
- ```--no-middlewares:``` Cria o projeto, mas não usa middlewares.
- ```--code:``` Abre o projeto no Visual Studio Code.
- Para uma revisão rápida: ```-h``` ou ```--help``` 

---

## Valores padrão
Segue os valores usados caso o parâmetro não seja fornecido:
- ```-o:``` express

- ```--js:``` OFF (usar TypeScript)
- ```--no-prisma:``` OFF (usar Prisma)
- ```--current-dir:``` OFF (cria uma subpasta com o valor de **-o**)
- ```--config:``` OFF
- ```--stock:``` OFF (cria a API de forma completa)
- ```--no-middlewares:``` OFF (usa middlewares)
- ```--code:``` OFF (não abrir com VSCode)

---

<br>

# Default exit
Command:  ```npx vss-express create```

Exit:

```
express/
│
├── node_modules/
│
├── prisma/
│   ├── migrations/
│   └── schema.prisma
│
├── src/
│   ├── lib/
│   │   └── db.ts
│   │
│   ├── routes/
│   │   └── index.ts
│   │
│   └── app.ts
│
├── .env
├── .gitignore
├── package.json
├── tsconfig.json

```
---

Command:  ```npx vss-express create -o MyProject --js --stock```
- Output folder name: MyProject
- Use JavaScript
- Do not use middleware or prisma


Exit:
```
MyProject/
│
├── node_modules/
│
├── src/
│   │
│   └── app.js
│
├── package.json

```