public class WeaponUSP : WeaponComponent
{
    public WeaponUSP() => _behavior = new DefaultBehavior();

    public override string Nombre => "USP";
    public override int Dano => 40;
    public override int Precision => 30;
    public override int Precio => 200;
    public override string Descripcion => "Pistola USP";
}