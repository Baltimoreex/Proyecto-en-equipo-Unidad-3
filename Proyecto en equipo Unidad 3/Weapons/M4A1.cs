public class WeaponM4A1 : WeaponComponent
{
    public WeaponM4A1() => _behavior = new DefaultBehavior();

    public override string Nombre => "M4A1";
    public override int Dano => 80;
    public override int Precision => 60;
    public override int Precio => 2900;
    public override string Descripcion => "M4A4 con cargador de 30 rondas, y reservas de 90 rondas, con mira de hierro";
}