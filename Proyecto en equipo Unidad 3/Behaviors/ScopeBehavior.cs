public class ScopeBehavior : IWeaponBehavior
{
    public string Disparar(string nombre, int dano, int precision)
        => $"Disparo apuntando con: {nombre}, con daño de: {dano}, y precision de: {precision}";

    public string Inspeccionar(string descripcion)
        => $"Inspeccion de: {descripcion} con mira";

    public string Recargar(string nombre)
        => $"Recargando: {nombre}";
}