public class ExtendedMagBehavior : IWeaponBehavior
{
    public string Disparar(string nombre, int dano, int precision)
        => $"Disparo con: {nombre}, con daño de: {dano}, y precision de: {precision}";

    public string Inspeccionar(string descripcion)
        => $"Inspeccion de: {descripcion} con cargador extendido";

    public string Recargar(string nombre)
        => $"Recargando: {nombre} con cargador extendido";
}