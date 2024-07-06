# Holi.

Este repo contiene todo el código de mis streams de live coding con stacks bizarros.
La idea es implementar, usando stacks de cuatro letras (una por componente), la siguiente arquitectura básica:
![Architecture](https://github.com/MarianoVilla/AToZChallenge/assets/44660612/9ac662ec-33d1-45da-b2db-73a13d1c1b27)

Originalmente la idea era usar un stack por letra (AAAA, BBBB, etc), pero probablemente nos gane la tentación de stacks más troll (e.g., Python, Elasticsearch, Node, Ember -PENE-).

*Todo lo que se haga en este repo va a estar documentado en YT; en [esta](https://www.youtube.com/playlist?list=PL6ZpaevWeaf95AXzBKY-w_SqJ_R5wQFiQ) lista de reproducción.*

## Stacks terminados.

### AAAA

- [Axios.js](https://axios-http.com/) para el cliente, usando API REST que devuelve un "cat fact" por cada GET que le hagas -> [https://catfact.ninja/](https://catfact.ninja/fact)
- [ArangoDB](https://arangodb.com/), una DB NoSQL orientada a grafos para como capa de persistencia. Usamos varias interfaces para interactuar con la base, incluyendo el CLI (Arangosh), la web UI que provee el motor de la base localmente, y los drivers para JS y .NET.
- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0) para el server. En este ejemplo incluimos una explicación de patrones de IoC, usando dependency injection como ejemplo de utilización de interfaces para evitar coupling.
- [Angular](https://angular.dev/) para el front-end. En el último video del stack atravesamos de comienzo a fin la documentación del framework -que yo jamás había usado-, e implementamos un front *HERMOSO*.

### PENE

- [Python](https://www.python.org/)
- [Excel](https://youtu.be/dQw4w9WgXcQ)
- [Node.js](https://nodejs.org/en)
- [ECharts](https://echarts.apache.org/en/index.html)


## Colaborar.

### Código.
Si querés colaborar con alguno de los proyectos, sentite libre de abrir una PR. Tené en cuenta que los cambios van a ser revisados en stream, para mantener el requerimiento de que todo esté documentado en YT.

### Sugerir stacks.
Si se te ocurre algún stack divertido, podés abrir un issue, o hablarme por cualquier otra vía.



