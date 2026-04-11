using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_en_equipo_Unidad_3
{
    public class PlayerNovato : Player
    {
        public PlayerNovato(string nombre, Image avatar)
            : base(nombre, "Novato", 5, avatar) { }

        public override string Disparar() =>
            "¡Espero no fallar! " + base.Disparar();

        public override string Recargar() =>
            "¿Cómo era que se recargaba? " + base.Recargar();
    }
}
