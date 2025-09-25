# Todo
Changes to fix

- package: "type": "commonjs"
´´´
 "target": "ES2019",                  // ou ES2020
    "module": "CommonJS",                // 🔑 força CJS
    "moduleResolution": "node",          // 🔑 resolve do jeito antigo
    "esModuleInterop": true,

´´´
- Em compile option (tsconfig):
- "verbatimModuleSyntax": false


### changing files:
- packege:  "type": "module",
- app.ts



# Mandar para o npm:
- dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
- Pegar os arquivos em bin/Release/publish
- copiar a pasta publish para a minha pulish e renomear para app (só o db e .exe)
- npm publish (mudar a versão)


# DEV PROCESS
- dotnet run at the Program.cs file