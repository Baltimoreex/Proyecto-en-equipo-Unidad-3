public class AttExtendedMag : WeaponDecorator
{
    public AttExtendedMag(WeaponComponent weapon) : base(weapon) 
    {
        _behavior = new ExtendedMagBehavior();
    }

    public override string Nombre => _weapon.Nombre;
    public override int Dano => _weapon.Dano;
    public override int Precision => _weapon.Precision;
    public override int Precio => _weapon.Precio + 300;
    public override string Descripcion => $"{_weapon.Descripcion}, Cargador extendido (+ 300 de costo)";
}