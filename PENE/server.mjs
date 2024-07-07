import { createServer } from 'node:http';
import XLSX from 'xlsx';

const server = createServer((req, res) => {
    if (req.url === '/dbz') {
        res.setHeader('Access-Control-Allow-Origin', '*');
        res.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE');
        res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
        res.setHeader('Access-Control-Allow-Credentials', true);
        res.writeHead(200, { 'Content-Type': 'application/json' });

        const workbook = XLSX.readFile('characters.xlsx');
        const sheetName = workbook.SheetNames[0];
        const worksheet = workbook.Sheets[sheetName];
        const jsonData = XLSX.utils.sheet_to_json(worksheet);
        
        res.end(JSON.stringify(jsonData, null, 2));
        
      } else {
        res.writeHead(200, { 'Content-Type': 'text/plain' });
        res.end('Hello World!\n');
      }
});

server.listen(3000, '127.0.0.1', () => {
  console.log('Listening on 127.0.0.1:3000');
});