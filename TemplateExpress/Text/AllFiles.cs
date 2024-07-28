namespace TemplateExpress.Text;

static class AllFilesText
{
    public static string App = @"import express from ""express""
const app = express()

const port = process.env.PORT || 2006

app.listen(port, ()=> console.log(`Runnig on: http://localhost:${port}`))";


    public static string Package(bool onlyJs = false)
    {
        if(onlyJs)
return @"{
  ""name"": ""app"",
  ""version"": ""1.0.0"",
  ""type"": ""module"",
  ""main"": ""src/app.js"",
  ""scripts"": {
    ""start"": ""node src/app.js"",
    ""dev"": ""nodemon --exec node  src/app.js"",
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
  ""type"": ""module"",
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


    public static string PrismaClient(bool onlyJs= false)  {


    if(onlyJs)
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
}