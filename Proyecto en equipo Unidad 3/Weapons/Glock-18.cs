public class WeaponGlock18 : WeaponComponent
{
    public WeaponGlock18() => _behavior = new DefaultBehavior();

    public override string Nombre => "Glock-18";
    public override int Dano => 25;
    public override int Precision => 30;
    public override int Precio => 200;
    public override string Descripcion => "Pistola Glock-18";
}