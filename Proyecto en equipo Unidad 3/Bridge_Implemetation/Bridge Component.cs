public interface IWeaponBehavior
{
    string Disparar(string nombreArma, int dano, int precision);
    string Inspeccionar(string descripcion);
    string Recargar(string nombreArma);
}