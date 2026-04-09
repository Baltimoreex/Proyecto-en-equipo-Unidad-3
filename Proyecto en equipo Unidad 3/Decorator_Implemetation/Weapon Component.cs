public abstract class WeaponComponent
{

    protected IWeaponBehavior _behavior;

    public void SetBehavior(IWeaponBehavior behavior)
    {
        _behavior = behavior;
    }

    public abstract string Nombre { get; }
    public abstract int Dano { get; }
    public abstract int Precision { get; }
    public abstract int Precio { get; }
    public abstract string Descripcion { get; }

    public virtual string Disparar() => _behavior?.Disparar(Nombre, Dano, Precision) ?? "Sin comportamiento asignado.";
    public virtual string Inspeccionar() => _behavior?.Inspeccionar(Descripcion) ?? "Sin comportamiento asignado.";
    public virtual string Recargar() => _behavior?.Recargar(Nombre) ?? "Sin comportamiento asignado.";
}