# 🏢 Proyecto Edifia

Este repositorio contiene el sistema **Edifia**, desarrollado en Visual Studio con arquitectura por capas y utilizando SQL Server como base de datos.

---

## 📁 Estructura del proyecto

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

---

## 🚀 Despliegue del proyecto

### 1. Clonar o descargar el repositorio

Puedes usar Git:

```bash```
git clone https://github.com/tu-usuario/Edifia.git

---

## Para la Base de Datos

Descomprime el archivo BDD.rar, que contiene:

  Edifia.mdf
  Edifia_log.ldf

Mueve los archivos a una ubicación de tu preferencia (ej: C:\Edifia\BD)

Abre SQL Server Management Studio (SSMS).

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
En el proyecto, busca el archivo de configuración (App.config) y edita la cadena de conexión:

<connectionStrings>
  <add name="Conexion"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=Edifia;Integrated Security=True" />
</connectionStrings>


