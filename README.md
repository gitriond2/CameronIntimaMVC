# Indumentaria Íntima - Tienda en Línea

## Descripción

Este es un proyecto de tienda en línea para una tienda de indumentaria íntima, desarrollado con .NET Core MVC. La aplicación permite a los usuarios navegar, registrarse, iniciar sesión, agregar productos a un carrito de compras y realizar pagos utilizando Stripe.

## Funcionalidades

### 1. Configuración Inicial
- **Proyecto en .NET Core MVC**: Configuración de un nuevo proyecto.
- **Base de Datos**: Configuración de `ApplicationDbContext` con SQL Server.

### 2. Migraciones de Entity Framework
- **Migración Inicial**: Creación y aplicación de la migración inicial.

### 3. Funcionalidades de Registro e Inicio de Sesión
- **Modelos de Vista**: Creación de `RegisterViewModel` y `LoginViewModel`.
- **Controladores y Vistas**: Acciones y vistas en `AccountController` para el registro e inicio de sesión.

### 4. Gestión de Productos
- **CRUD**: Controlador y vistas generados con scaffolding para `Producto`.

### 5. Carrito de Compras
- **Modelo CarritoItem**: Definición del modelo.
- **Servicio CarritoService**: Lógica del carrito de compras.
- **Controlador CarritoController**: Manejo de operaciones en el carrito.
- **Vistas del Carrito**: Visualización y gestión de productos en el carrito.
- **Resumen del Carrito**: Visualización del resumen del carrito en todas las páginas.

### 6. Procesamiento de Pagos
- **Stripe SDK**: Integración del SDK de Stripe.
- **Configuración de Stripe**: Configuración de las credenciales y uso de la API.
- **Controlador PagosController**: Manejo de sesiones de pago.
- **Vistas de Pago**: Vistas de éxito y cancelación del pago.

### 7. Optimización del Rendimiento
- **Response Caching**: Implementación de caching para mejorar la velocidad de carga.

### 8. Mejorar la Interfaz de Usuario
- **Bootstrap**: Aplicación de Bootstrap para un diseño responsive.
- **CSS Personalizado**: Personalización del diseño con `site.css`.

## Instalación

1. **Clonar el Repositorio**:
    ```sh
    git clone https://github.com/usuario/nombre-del-repositorio.git
    cd nombre-del-repositorio
    ```

2. **Configurar la Base de Datos**:
    - Actualizar la cadena de conexión en `appsettings.json`.

3. **Aplicar Migraciones**:
    ```sh
    dotnet ef database update
    ```

4. **Ejecutar la Aplicación**:
    ```sh
    dotnet run
    ```

## Tecnologías Utilizadas

- **.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap**
- **Stripe**

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue o crea un pull request para sugerir mejoras o reportar problemas.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo `LICENSE` para obtener más detalles.

---

¡Gracias por utilizar nuestra tienda en línea de Indumentaria Íntima! Si tienes alguna pregunta o sugerencia, no dudes en contactarnos.
