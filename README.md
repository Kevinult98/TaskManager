TaskManager – Aplicación de Gestión de Tareas
Descripción
TaskManager es una aplicación de escritorio desarrollada en WinForms con .NET 8, cuyo propósito es administrar tareas de forma sencilla y ordenada.
La aplicación permite crear, editar, eliminar y dar seguimiento a tareas, aplicando validaciones y reglas de negocio para asegurar un uso correcto de la información.
El proyecto fue desarrollado utilizando una arquitectura por capas, con una separación clara entre la interfaz de usuario, la lógica de negocio y el acceso a datos.
________________________________________
Funcionalidades
La aplicación permite:
•	Crear nuevas tareas.
•	Editar tareas únicamente cuando se encuentran en estado Pendiente.
•	Eliminar tareas mediante eliminación lógica.
•	Cambiar el estado de las tareas siguiendo el flujo:
o	Pendiente → En Proceso → Terminada.
•	Visualizar las tareas en una tabla ordenada por fecha de compromiso.
•	Aplicar filtros por estado y por rango de fechas.
•	Mostrar mensajes informativos cuando una acción no está permitida o no existen resultados.
________________________________________
Información de la tarea
Cada tarea maneja la siguiente información:
•	Descripción
•	Usuario asignado
•	Estado
•	Prioridad
•	Fecha de compromiso
•	Notas adicionales
________________________________________
Reglas de negocio
•	Solo se pueden editar tareas en estado Pendiente.
•	No se pueden eliminar tareas en estado En Proceso.
•	Las tareas Terminadas no pueden modificarse.
•	No se permiten fechas de compromiso anteriores a la fecha actual.
•	La eliminación de tareas es lógica, conservando los datos en la base de datos.
________________________________________
Estructura del proyecto
El proyecto se encuentra organizado por capas:
•	TaskManager.UI
Contiene los formularios y la interacción con el usuario.
•	TaskManager.ViewModels
Contiene la lógica de negocio, validaciones y control del flujo de la aplicación.
•	TaskManager.Domain
Contiene las entidades y enumeraciones del sistema.
•	TaskManager.Data
Contiene el acceso a datos, repositorios y la inicialización de la base de datos.
Esta estructura permite mantener el código ordenado y facilitar futuras mejoras.
________________________________________
Base de datos
•	Se utiliza SQLite como base de datos.
•	La base de datos se crea automáticamente al ejecutar la aplicación.
•	Se utiliza un campo IsActive para manejar la eliminación lógica.
•	La interfaz solo muestra tareas activas.
Ubicación del archivo de base de datos
El archivo de base de datos se genera en la carpeta de salida del proyecto de la interfaz de usuario.
Ruta típica en modo Debug:
C:\Users\<UsuarioWindows>\source\repos\TaskManager.UI\TaskManager.UI\bin\Debug\net8.0\taskmanager.db

El archivo puede abrirse con herramientas como SQLiteStudio.
________________________________________
Ejecución del proyecto
1.	Clonar el repositorio.
2.	Abrir la solución en Visual Studio.
3.	Establecer TaskManager.UI como proyecto de inicio.
4.	Ejecutar la aplicación.
________________________________________
Observaciones
Como mejora futura, el sistema podría incorporar un módulo de autenticación de usuarios, de forma que cada tarea se asigne automáticamente al usuario que haya iniciado sesión.
Esta funcionalidad no fue implementada en esta versión para mantener el alcance del proyecto acorde a los requerimientos solicitados.
________________________________________
Comentario final
El proyecto fue desarrollado cumpliendo los requerimientos planteados, priorizando una estructura clara, validaciones correctas y una experiencia de usuario simple.

