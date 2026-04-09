public class SilencerBehavior : IWeaponBehavior
{
    public string Disparar(string nombre, int dano, int precision)
        => $"Disparo silenciado de: {nombre}, con daño de: {dano}, y precision de: {precision}";

    public string Inspeccionar(string descripcion)
        => $"Inspeccion de: {descripcion} silenciada";

    public string Recargar(string nombre)
        => $"Recargando: {nombre} silenciada";
}