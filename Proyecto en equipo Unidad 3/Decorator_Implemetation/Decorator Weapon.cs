public abstract class WeaponDecorator : WeaponComponent
{
    protected WeaponComponent _weapon;
    public WeaponDecorator(WeaponComponent weapon)
    {
        _weapon = weapon;
    }

    public override string Disparar() => _behavior != null ? _behavior.Disparar(Nombre, Dano, Precision) : _weapon.Disparar();
    public override string Inspeccionar() => _behavior != null ? _behavior.Inspeccionar(Descripcion) : _weapon.Inspeccionar();
    public override string Recargar() => _behavior != null ? _behavior.Recargar(Nombre) : _weapon.Recargar();
}