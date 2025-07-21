# 🏢 Proyecto Edifia

Este repositorio contiene el sistema **Edifia**, desarrollado en Visual Studio con arquitectura por capas y utilizando SQL Server como base de datos.

---

## 📁 Estructura del proyecto
```
/Edifia
├── Edifia.sln # Solución de Visual Studio
├── Edifia_GUI # Capa de presentación (interfaz gráfica)
├── Edifia_BL # Capa de lógica de negocio
├── Edifia_BE # Capa de entidades
├── Edifia_ADO # Capa de acceso a datos
├── BDD.rar # Base de datos (.mdf y .ldf comprimidos)
├── plantilla.xlsx # Archivo adicional del proyecto
├── README.md # Este archivo
└── .gitignore # Exclusión de archivos innecesarios
```
## 📁 Estructura del portable

```
/Edifia - Portable
├── Edifia # Carpeta con el ejecutable
├── BDD.rar # Base de datos (.mdf y .ldf comprimidos)

```
---

## 🚀 Despliegue del proyecto

### 1. Clonar, descargar el repositorio o versión portable

Puedes encontrar la versión portable en Releases de este mismo repositorio.

Puedes usar Git:

```bash```
git clone https://github.com/MontanoLlagas-Jose/Edifia.git

---

## Para la Base de Datos

Descomprime el archivo BDD.rar, que contiene:

  Edifia.mdf
  Edifia_log.ldf

Mueve los archivos a una ubicación de tu preferencia (ej: C:\Edifia\BD)

Abre SQL Server Management Studio (SSMS) o SQL Express (Importante ejecutar el programa en Administrador).

Ejecuta el siguiente script para adjuntar la base de datos:
```
CREATE DATABASE Edifia
ON (
    FILENAME = 'C:\Edifia\BD\Edifia.mdf'
), (
    FILENAME = 'C:\Edifia\BD\Edifia_log.ldf'
)
FOR ATTACH;

```
## Configurar la cadena de conexión

Recomendamos tener instalado SQL Express o SQL Server de Microsoft

Si usamos el repositorio:

En el proyecto, busca el archivo de configuración (App.config) y edita la cadena de conexión

Si usas la versión portable:

Modifica el archivo con nombre Edifia_GUI.dll.config (Puede usar notepad, Visual Studio o cualquier otro editor para este paso) y actualiza el connectionString

Si utilizamos SQL Server:

```
<connectionStrings>
   <add name ="Edifia" connectionString ="server=;Database=Edifia;Integrated Security=true"
           providerName="System.Data.SqlClient"/>
</connectionStrings>
```

Si usamos SQL Express:

```
<connectionStrings>
  <add name="Conexion"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Edifia;Integrated Security=True" />
</connectionStrings>
```
