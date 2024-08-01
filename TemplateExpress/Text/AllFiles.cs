using TemplateExpress.Utils;

namespace TemplateExpress.Text;

static class AllFilesText
{
  public static string App(UserInitalizationArgs Options)
  {
    if (Options.Stock || Options.NoMiddlewares)
      return @"import express from ""express""
const app = express()

const port = process.env.PORT || 2006

app.listen(port, ()=> console.log(`Runnig on: http://localhost:${port}`))";


// COMPLETÃO
    return $@"import express from ""express""
import cors from ""cors""
import mainRouter from ""./routes{(Options.OnlyJs ? "/index.mjs" : "")}""

const app = express()

//basic middlwares
app.use(cors())
app.use(express.urlencoded({{ extended: true }}));
app.use(express.json())

//router
app.use(mainRouter)


const port = process.env.PORT || 2006

app.listen(port, ()=> console.log(`Runnig on: http://localhost:${{port}}`))";
  }

  public static string Package(bool onlyJs = false)
  {
    if (onlyJs)
      return @"{
  ""name"": ""app"",
  ""version"": ""1.0.0"",
  ""main"": ""src/app.mjs"",
  ""scripts"": {
    ""start"": ""node src/app.js"",
    ""dev"": ""nodemon --exec node  src/app.mjs"",
    ""test"": ""echo \""Error: no test specified\"" && exit 1""
  },
  ""keywords"": [],
  ""author"": """",
  ""license"": ""ISC"",
  ""description"": """"
}
";

    return @"{
  ""name"": ""app"",
  ""version"": ""1.0.0"",
  ""main"": ""src/app.ts"",
  ""scripts"": {
    ""start"": ""ts-node src/app.ts"",
    ""dev"": ""nodemon --exec ts-node src/app.ts"",
    ""test"": ""echo \""Error: no test specified\"" && exit 1""
  },
  ""keywords"": [],
  ""author"": """",
  ""license"": ""ISC"",
  ""description"": """"
}
";

  }


  public static string PrismaClient(bool onlyJs = false)
  {


    if (onlyJs)
      return @"import { PrismaClient } from '@prisma/client'

export const db =  globalThis.prisma || new PrismaClient()

if(process.env.NODE_ENV != 'production') {
    globalThis.prisma = db
}";




    return @"import { PrismaClient } from '@prisma/client'

declare global {
    var prisma: PrismaClient | undefined
}


export const db =  globalThis.prisma || new PrismaClient()

if(process.env.NODE_ENV != 'production') {
    globalThis.prisma = db
}";


  }


  public static string DotEnv = @"DATABASE_URL=""file:./dev.db""";

  public static string SchemaDotPrisma = @"// This is your Prisma schema file,
// learn more about it in the docs: https://pris.ly/d/prisma-schema

// Looking for ways to speed up your queries, or scale easily with your serverless or edge functions?
// Try Prisma Accelerate: https://pris.ly/cli/accelerate-init

generator client {
  provider = ""prisma-client-js""
}

datasource db {
  provider = ""sqlite""
  url      = env(""DATABASE_URL"")
}


model User {
  id    Int     @id @default(autoincrement())
  name  String
  email String  @unique
}";


  public static string Router(bool OnlyJs = false, bool NoMiddleware = false)
  {
    if(OnlyJs || NoMiddleware)
      return @"import { Router } from 'express'
const router = Router()

router.get('/', (req, res) => {
    res.send('Hello')
})

export default router";

    return $@"import {{ Router, Request, Response }} from 'express';
const router = Router();

router.get('/', (req: Request, res: Response) => {{
    res.send('Hello')
}})

export default router";
  }
}