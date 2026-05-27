# El proyecto que nosotros el grupo 4 hicimos en GitHub.
## Su uso:
El proyecto esta pensado para ayudar con la organizacion y manejo de alumnos y sus tareas durante sus practicas.
- Para los profesores, facilita el añadir, borrar y editar datos de alumnos y ver el que han estado haciendo durante sus practicas.
- Para los alumnos, facilita el crear, borrar y editar sus tareas para mantenerlas mas facilmente al dia.
Para ello, el trabajo chequeara una base de datos y hara las operaciones que tenga que hacer.
## Lo que hace:
El programa al ejecutarse chequeara si hay una base de datos local en "." o en ".\SQLEXPRESS"
A partir de hay, cuando se crea un alumno se hara un **insert**, al borrar un alumno se hara un **delete**. Lo mismo aplica para tareas.
Tambien se hara un **select** en general cuando se intente ver informacion de alumnos o tareas.
- Si no hay ninguno avisara sobre ello, aunque avisara en general si es que no puede conectarse.
- El lugar es configurable, si quieres que busque por uno en otra ruta poner la ruta en el archivo MiServidor.vb.
- Obviamente ten en cuenta de que puede haber problemas si tu base de datos tiene un **trigger** *AFTER* o *INSTEAD OF*
- En caso de querer errores mas descriptivos, en Gestion.vb todos los returns tienen un return opcional en forma de comentario.En caso de quitarlo de comentario y ponerlo en vez del anterior, se dara que problema SQL se encontro al hacer el proceso.
## Requerimientos:
Un servidor SQL.
Visual Studio para editar el archivo facilmente para poner la ruta a otro servidor.
