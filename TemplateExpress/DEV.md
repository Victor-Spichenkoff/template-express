# Todo
- line 155 AllFile > import type { Request, Response } from 'express'; opcional no noJS
- need fix on js (falta module, novo dev <- ambos package; app.mjs?)
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
- and: dev: nodemon --watch src --ext ts,json --exec \"node --loader ts-node/esm src/app.ts\"
- app.ts:
    - import mainRouter from "./routes/index.js"
    - Removi isso do completão:
    import mainRouter from ""./routes{(Options.OnlyJs ? "/index.mjs" : "")}""
- route:
    import { Router } from 'express';
    import type { Request, Response } from 'express';- 

### Change on JS:
- package:   "type": "module",
    - and: 
- não usa mais .mjs, só js

# Mandar para o npm:
- dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true
- Pegar os arquivos em bin/Release/publish
- copiar a pasta publish para a minha pulish e renomear para app (só o db e .exe)
- npm publish (mudar a versão)


# DEV PROCESS
- dotnet run at the Program.cs file