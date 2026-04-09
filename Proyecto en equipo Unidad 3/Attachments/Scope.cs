public class AttScope : WeaponDecorator
{
    public AttScope(WeaponComponent weapon) : base(weapon) 
    {
        _behavior = new ScopeBehavior();
    }

    public override string Nombre => _weapon.Nombre;
    public override int Dano => _weapon.Dano;
    public override int Precision => _weapon.Precision + 30;
    public override int Precio => _weapon.Precio + 600;
    public override string Descripcion => $"{_weapon.Descripcion}, Mira (+30 de precision, y +600 de costo)";
}