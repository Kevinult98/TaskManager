TaskManager – Aplicación de Gestión de Tareas
Descripción general
TaskManager es una aplicación de escritorio desarrollada en WinForms con .NET 8, cuyo objetivo es administrar tareas de forma clara, ordenada y eficiente.
La aplicación permite crear, editar, eliminar y dar seguimiento a tareas, aplicando reglas de negocio y validaciones para garantizar un uso correcto de la información.
El proyecto fue desarrollado siguiendo una arquitectura por capas, utilizando una estructura basada en MVVM adaptado a WinForms, con el fin de mantener el código organizado, fácil de mantener y preparado para futuras mejoras.
________________________________________
Funcionalidades principales
La aplicación permite:
Crear nuevas tareas.
Editar tareas únicamente cuando se encuentran en estado Pendiente.
Eliminar tareas mediante eliminación lógica, conservando los registros en la base de datos.
Cambiar el estado de una tarea siguiendo el flujo:
Pendiente → En Proceso → Terminada.
Visualizar todas las tareas en una tabla ordenada por fecha de compromiso.
Aplicar filtros avanzados por:
Estado de la tarea.
Rango de fechas (inicio y fin).
Mostrar mensajes claros cuando una acción no está permitida o cuando no se encuentran resultados.
________________________________________
Información manejada por cada tarea
Cada tarea contiene los siguientes campos:
Descripción: Detalle de la tarea a realizar.
Usuario: Persona asignada a la tarea.
Estado: Pendiente, En Proceso o Terminada.
Prioridad: Baja, Media o Alta.
Fecha de compromiso: Fecha límite para completar la tarea.
Notas: Información adicional asociada a la tarea.
________________________________________
Reglas de negocio implementadas
Solo se pueden editar tareas en estado Pendiente.
No se pueden eliminar tareas que estén en estado En Proceso.
Las tareas en estado Terminada no pueden ser modificadas.
El cambio de estado debe respetar el flujo definido.
No se permiten fechas de compromiso en el pasado.
La eliminación de tareas es lógica, manteniendo el historial en la base de datos.
________________________________________
Filtros de búsqueda
La aplicación incluye un panel de filtros que permite:
Filtrar tareas por estado mediante botones de selección.
Filtrar tareas por un rango de fechas (inicio y fin).
Combinar filtros de estado y fecha.
Mostrar un mensaje informativo cuando no se encuentran resultados con los filtros aplicados.
________________________________________
Arquitectura y patrón utilizado
El proyecto está organizado en capas y sigue una estructura basada en MVVM adaptado a WinForms.
Aunque WinForms no soporta MVVM de forma nativa, esta adaptación permite separar la lógica de presentación de la interfaz gráfica, manteniendo una clara separación de responsabilidades y facilitando el mantenimiento y la escalabilidad del sistema.
Estructura por capas
TaskManager.UI
Contiene los formularios WinForms y se encarga únicamente de la interacción con el usuario, manejo de eventos y experiencia visual.
No contiene lógica de negocio ni acceso directo a datos.
TaskManager.ViewModels
Contiene los ViewModels, donde se implementan las reglas de negocio, validaciones y control del flujo de la aplicación.
La interfaz se comunica exclusivamente con esta capa.
TaskManager.Domain
Contiene las entidades y enumeraciones del dominio, representando el modelo de datos del sistema.
TaskManager.Data
Maneja el acceso a datos, repositorios, consultas SQL y la inicialización de la base de datos.
________________________________________
Base de datos
Se utiliza SQLite como motor de base de datos.
La base de datos se inicializa automáticamente al iniciar la aplicación.
Las tareas se almacenan en una tabla con soporte para eliminación lógica mediante el campo IsActive.
La aplicación solo muestra tareas activas en la interfaz.
________________________________________
Manejo de errores y experiencia de usuario
Todas las validaciones se realizan antes de ejecutar acciones críticas.
Los errores de negocio se muestran mediante mensajes claros y comprensibles.
La aplicación evita cierres inesperados y mantiene una experiencia de uso estable.
Los botones se habilitan o deshabilitan según el estado de la tarea seleccionada.
________________________________________
Requisitos para ejecutar el proyecto
.NET 8 SDK
Visual Studio 2022 o superior
Sistema operativo Windows
________________________________________
Ubicación del archivo de base de datos
La aplicación utiliza una base de datos SQLite, la cual se genera automáticamente al ejecutar el proyecto por primera vez.
El archivo de la base de datos es un archivo físico con extensión .db y se crea en la carpeta de salida del proyecto de la interfaz de usuario.
Ruta por defecto en modo Debug:
C:\Users\<UsuarioWindows>\source\repos\TaskManager.UI\TaskManager.UI\bin\Debug\net8.0\taskmanager.db
Donde <UsuarioWindows> corresponde al usuario con el que se ejecuta Visual Studio en el sistema operativo.
Nota: La ruta puede variar dependiendo del modo de ejecución (Debug o Release) y la ubicación del proyecto.
Este archivo puede abrirse y visualizarse utilizando herramientas como SQLiteStudio, permitiendo revisar las tablas, los datos almacenados y validar el correcto funcionamiento de la aplicación.
________________________________________
Ejecución del proyecto
Clonar el repositorio.
Abrir la solución en Visual Studio.
Establecer TaskManager.UI como proyecto de inicio.
Ejecutar la aplicación.
La base de datos se crea automáticamente en la primera ejecución.
________________________________________
Observaciones y mejoras futuras
Para un desarrollo más completo y orientado a un entorno real de producción, se considera importante implementar un módulo de autenticación y control de usuarios previo al uso de la aplicación.
La idea principal sería que cada usuario ingrese al sistema mediante un proceso de inicio de sesión (login), permitiendo identificar de forma automática qué usuario está utilizando la aplicación en cada momento.
Gestión de usuarios
Crear una tabla de Usuarios que contenga información como:
Identificador de usuario
Nombre
Apellidos
Cédula
Contraseña (almacenada de forma encriptada)
Identificador de perfil de usuario (clave foránea)
Campo IsActive para habilitar o deshabilitar usuarios sin eliminarlos físicamente
El campo Identificador de perfil de usuario funcionaría como una clave foránea hacia una tabla independiente de permisos.
Gestión de permisos y accesos
Crear una tabla llamada PermisosUsuarios, compuesta por campos como:
Identificador del permiso
Estado activo/inactivo
Permisos asignados
Estos permisos permitirían:
Controlar las acciones que un usuario puede realizar (crear, editar, eliminar tareas, cambiar estados).
Restringir el acceso a formularios o módulos del sistema.
Facilitar la expansión del sistema a nuevos módulos sin modificar la lógica principal.
Es importante indicar que los campos y valores definidos para las tablas de Usuarios, Permisos y Tareas fueron pensados con la información mínima necesaria para el correcto funcionamiento del sistema en esta versión.
No obstante, esta estructura permite que los modelos puedan extenderse fácilmente en el futuro, agregando nuevos campos o relaciones según las necesidades del negocio, sin afectar la lógica principal de la aplicación.
Este enfoque busca mantener un diseño simple, claro y funcional, evitando sobrecargar la solución con información que no fue requerida en el alcance inicial, pero dejando la base preparada para futuras ampliaciones.
Beneficios de esta estructura
Con esta implementación:
El sistema podría asignar automáticamente el usuario autenticado al campo Usuario de la tabla de tareas.
Se evitaría el ingreso manual del usuario al crear tareas.
Se tendría un mejor control de seguridad.
Se permitiría desactivar usuarios sin perder información histórica.
El sistema sería fácilmente escalable a un entorno multiusuario y modular.
Estas mejoras no fueron implementadas en esta versión con el fin de mantener el alcance del proyecto alineado con los requerimientos solicitados.
________________________________________
Observaciones finales
Este proyecto fue desarrollado cumpliendo los requerimientos funcionales solicitados, aplicando buenas prácticas de programación, una estructura clara y una experiencia de usuario intuitiva.


