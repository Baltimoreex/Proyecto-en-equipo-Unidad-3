
public class Player
{
    public string Nombre { get; }
    public string Rango { get; }
    public int Nivel { get; }
    public Image Avatar { get; }   

    private WeaponComponent _weapon;

    public Player(string nombre, string rango, int nivel, Image avatar)
    {
        Nombre = nombre;
        Rango = rango;
        Nivel = nivel;
        Avatar = avatar;
    }

    private static Image CargarImagen(string nombre)
    {
        string ruta = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,"Images",
            "Profile_Images",
            nombre
        );
        return File.Exists(ruta) ? Image.FromFile(ruta) : null;
    }

    public static Player[] ObtenerPerfiles() => new Player[]
{
    new PlayerAgresivo("CS_Player01", CargarImagen("player1")),
    new PlayerTactico ("SniperKing",  CargarImagen("player2")),
    new PlayerNovato  ("Rookie99",    CargarImagen("player3")),
};

    public void EquiparArma(WeaponComponent weapon) => _weapon = weapon;

    public virtual string Disparar() => _weapon != null ? _weapon.Disparar() : "Sin arma equipada.";
    public virtual string Inspeccionar() => _weapon != null ? _weapon.Inspeccionar() : "Sin arma equipada.";
    public virtual string Recargar() => _weapon != null ? _weapon.Recargar() : "Sin arma equipada.";
}