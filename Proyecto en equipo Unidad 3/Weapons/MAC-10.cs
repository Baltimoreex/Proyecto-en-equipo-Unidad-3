public class WeaponMAC10 : WeaponComponent
{
    public WeaponMAC10() => _behavior = new DefaultBehavior();

    public override string Nombre => "MAC-10";
    public override int Dano => 50;
    public override int Precision => 45;
    public override int Precio => 1050;
    public override string Descripcion => "Subfusil MAC-10";
}