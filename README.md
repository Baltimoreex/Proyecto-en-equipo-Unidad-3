# Introducción

En el desarrollo de videojuegos, la personalización de armas requiere sistemas flexibles que permitan crear variaciones sin generar una gran cantidad de clases. Para lograrlo, se combinan dos patrones de diseño: **Decorador** y **Bridge**.  

El patrón **Decorador** permite añadir accesorios al arma de manera dinámica, como miras, empuñaduras o cargadores, modificando sus características sin alterar la estructura del arma base.  

Por otro lado, el patrón **Bridge** separa la abstracción del arma (su tipo, como rifle, pistola o escopeta) de su implementación interna (cómo dispara, cómo calcula daño o cómo gestiona la munición).  

La combinación de ambos patrones permite construir armas altamente configurables, reutilizables y fáciles de expandir, manteniendo una arquitectura clara y organizada.

---

# Objetivo

El objetivo de integrar los patrones **Decorador** y **Bridge** en este proyecto es crear un sistema de personalización de armas modular y escalable.  

Con **Bridge** se busca separar la lógica general del arma de su forma de funcionamiento, permitiendo cambiar o agregar nuevas implementaciones sin modificar la estructura principal.  

Con **Decorador**, se pretende permitir la adición de accesorios de forma dinámica, evitando crear múltiples variantes de armas.  

En conjunto, ambos patrones proporcionan una arquitectura que facilita la extensión del sistema, mejora la reutilización del código y mantiene el control sobre la complejidad conforme se agregan más tipos de armas y accesorios.

---

# Conclusión

La combinación de los patrones de diseño **Decorador** y **Bridge** proporciona una solución robusta y bien estructurada para la personalización de armas en videojuegos.  

**Bridge** permite separar la abstracción del arma de su implementación, facilitando la creación de nuevos tipos de armas sin afectar el funcionamiento interno del sistema.  

Por su parte, **Decorador** permite añadir accesorios de manera dinámica y flexible, evitando la creación de múltiples clases rígidas para cada variación posible.  

Al trabajar juntos, ambos patrones ofrecen una arquitectura modular, extensible y fácil de mantener, que se adapta a las necesidades de un sistema de personalización complejo.  

Esto permite desarrollar armas más configurables, mejorar la reutilización del código y garantizar un crecimiento ordenado del proyecto conforme se integran nuevas mecánicas o accesorios.

---

# GitHub

Repositorio del proyecto:  
https://github.com/Baltimoreex/Proyecto-en-equipo-Unidad-3  

El código de **Bridge** se encuentra en las ramas:
- `Puente-Decorador-Interfaz`
- `Bridge_Implementation`
