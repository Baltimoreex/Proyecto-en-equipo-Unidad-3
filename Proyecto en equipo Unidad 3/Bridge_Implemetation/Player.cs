
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
    new Player("CS_Player01", "Global Elite",    40, CargarImagen("player1.png")),
    new Player("SniperKing",  "Master Guardian", 25, CargarImagen("player2.png")),
    new Player("Rookie99",    "Novato",           5, CargarImagen("player3.png")),
    };

    public void EquiparArma(WeaponComponent weapon) => _weapon = weapon;

    public string Disparar() => _weapon != null ? _weapon.Disparar() : "Sin arma equipada.";
    public string Inspeccionar() => _weapon != null ? _weapon.Inspeccionar() : "Sin arma equipada.";
    public string Recargar() => _weapon != null ? _weapon.Recargar() : "Sin arma equipada.";
}