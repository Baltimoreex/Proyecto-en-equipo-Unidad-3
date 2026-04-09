public class WeaponMP9 : WeaponComponent
{
    public WeaponMP9() => _behavior = new DefaultBehavior();

    public override string Nombre => "MP9";
    public override int Dano => 50;
    public override int Precision => 40;
    public override int Precio => 1250;
    public override string Descripcion => "Subfusil MP9";
}