using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_en_equipo_Unidad_3.Players
{
    public class PlayerAgresivo : Player
    {
        public PlayerAgresivo(string nombre, Image avatar)
            : base(nombre, "Global Elite", 40, avatar) { }

        public override string Disparar() =>
            "¡FUEGO TOTAL! " + base.Disparar();
    }
}
