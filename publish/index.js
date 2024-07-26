#!/usr/bin/env node
//executar o:   npx "name" (comando equivalente ao executando junto ao run)
const { execFileSync } = require('child_process');
const path = require('path');

const exePath = path.join(__dirname+"\\app", './TemplateExpress.exe');

const args = process.argv.slice(2);

execFileSync(exePath, args, { stdio: 'inherit' });
