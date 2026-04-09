public class WeaponAWP : WeaponComponent
{
    public WeaponAWP() => _behavior = new DefaultBehavior();

    public override string Nombre => "AWP";
    public override int Dano => 150;
    public override int Precision => 100;
    public override int Precio => 4750;
    public override string Descripcion => "Rilfe francotirador AWP";
}