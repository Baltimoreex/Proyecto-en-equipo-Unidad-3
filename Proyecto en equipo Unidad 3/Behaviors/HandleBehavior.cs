public class HandleBehavior : IWeaponBehavior
{
    public string Disparar(string nombre, int dano, int precision)
        => $"Disparo de: {nombre}, con daño de: {dano} y precision de: {precision}";

    public string Inspeccionar(string descripcion)
        => $"Inspeccion de: {descripcion} con empuñadura";

    public string Recargar(string nombre)
        => $"Recargando: {nombre}";
}