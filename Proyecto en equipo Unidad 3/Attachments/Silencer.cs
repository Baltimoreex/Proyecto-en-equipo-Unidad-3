public class AttSilencer : WeaponDecorator
{
    public AttSilencer(WeaponComponent weapon) : base(weapon) 
    {
        _behavior = new SilencerBehavior();
    }

    public override string Nombre => _weapon.Nombre;
    public override int Dano => _weapon.Dano -20;
    public override int Precision => _weapon.Precision + 20;
    public override int Precio => _weapon.Precio + 500;
    public override string Descripcion => $"{_weapon.Descripcion}, Silenciador (- 20 de daño, +20 de precisicion y + 500 de costo)";
}