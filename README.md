# SistemaVentas

Este proyecto es una **aplicación de escritorio Windows Forms** desarrollada en **.NET 8 para Windows**.  
El sistema está organizado en una arquitectura modular compuesta por tres proyectos:

- **SVPresentacion (Windows Forms)**: Interfaz gráfica del usuario.
- **SVServices**: Capa de servicios y lógica de negocio.
- **SVRespositorio**: Capa de acceso a datos (SQL Server).

## Tecnologías utilizadas

- [.NET 8.0 (Windows)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-8.0)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [CloudinaryDotNet 1.27.5](https://github.com/cloudinary/CloudinaryDotNet) (gestión de imágenes)
- [MailKit 4.11.0](https://github.com/jstedfast/MailKit) (envío de correos)
- [Microsoft.Data.SqlClient 6.0.1](https://learn.microsoft.com/en-us/sql/connect/ado-net/sqlclient/)
- [Microsoft.Extensions.Hosting 9.0.3](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host)
- [Microsoft.Extensions.Configuration 9.0.3](https://learn.microsoft.com/en-us/dotnet/core/extensions/configuration)
- [Microsoft.Extensions.DependencyInjection 9.0.3](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)

## Estructura del proyecto
/Solución
├── SVPresentacion(Windows Forms)
│   ├── appsettings.json (configuración)
│   ├── Referencias:
│   │   └── SVServices
│
├── SVServices (Servicios / Lógica de negocio)
│   ├── Referencias:
│   │   └── SVRespositorio
│
└── SVRespositorio (Acceso a datos / Repositorios)


## Requisitos previos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- **Visual Studio 2022** o superior (con soporte para Windows Forms en .NET 8)
- **Microsoft SQL Server** (local o remoto)
- Acceso correcto a las rutas relativas de los proyectos (`SVServices`, `SVRespositorio`).

## Instalación

1. Clona el repositorio:

    ```bash
    git clone https://github.com/Felipe10812/SistemaVentas.git
    ```

2. Restaura los paquetes NuGet:

    ```bash
    dotnet restore
    ```

3. Abre la solución `.sln` en **Visual Studio 2022** o superior.

4. Configura las conexiones y servicios en el archivo `appsettings.json`.

5. Compila la solución:

    - Menú `Compilar` > `Compilar solución`.

## Ejecución

Para ejecutar el proyecto:

- Desde Visual Studio: selecciona **SVPresentacion** como proyecto de inicio y presiona `F5`.
- O desde terminal:

    ```bash
    dotnet run --project Ruta/Al/SVPresentacion.csproj
    ```

El ejecutable generado estará en la carpeta:

- `bin/Debug/net8.0-windows/`
- o `bin/Release/net8.0-windows/` dependiendo del modo de compilación.

## Configuración (`appsettings.json`)

El proyecto utiliza un archivo `appsettings.json` para manejar configuraciones externas como:

- Cadena de conexión a la base de datos SQL Server
- Credenciales de Cloudinary
- Configuraciones SMTP para envío de correos

Ejemplo de `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=TU_SERVIDOR;Database=TU_BASE;User Id=TU_USUARIO;Password=TU_PASSWORD;"
  },
  "CloudinarySettings": {
    "CloudName": "tu-cloud-name",
    "ApiKey": "tu-api-key",
    "ApiSecret": "tu-api-secret"
  },
  "EmailSettings": {
    "SmtpServer": "smtp.tucorreo.com",
    "SmtpPort": 587,
    "SenderName": "Nombre del Remitente",
    "SenderEmail": "correo@tucorreo.com",
    "Username": "usuarioSMTP",
    "Password": "contraseñaSMTP"
  }
}
