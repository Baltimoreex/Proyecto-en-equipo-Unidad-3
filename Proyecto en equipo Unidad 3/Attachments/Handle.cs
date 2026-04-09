public class AttHandle : WeaponDecorator
{
    public AttHandle(WeaponComponent weapon) : base(weapon) 
    {
        _behavior = new HandleBehavior();
    }

    public override string Nombre => _weapon.Nombre;
    public override int Dano => _weapon.Dano;
    public override int Precision => _weapon.Precision + 20;
    public override int Precio => _weapon.Precio + 400;
    public override string Descripcion => $"{_weapon.Descripcion}, Empuñadura (+20 de precision, y +400 de costo)";
}