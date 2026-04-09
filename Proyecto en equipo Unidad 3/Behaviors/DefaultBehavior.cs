public class DefaultBehavior : IWeaponBehavior
{
    public string Disparar(string nombre, int dano, int precision)
        => $"Disparo con: {nombre}, con daño de: {dano}, y precisión de: {precision}";

    public string Inspeccionar(string descripcion)
        => $"Inspeccion de: {descripcion}";

    public string Recargar(string nombre)
        => $"Recargando: {nombre}";
}