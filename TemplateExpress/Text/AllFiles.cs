namespace TemplateExpress.Text;

static class AllFilesText
{
    public static string App = @"import express from ""express""
const app = express

const port = process.env.PORT || 2006

app.listen(port, ()=> console.log(`Runnig on: http://localhost:${port}`))";
}