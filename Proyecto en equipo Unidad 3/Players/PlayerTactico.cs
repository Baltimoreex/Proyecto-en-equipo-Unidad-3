using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_en_equipo_Unidad_3
{
    public class PlayerTactico : Player
    {
        public PlayerTactico(string nombre, Image avatar)
            : base(nombre, "Master Guardian", 25, avatar) { }

        public override string Disparar() =>
            "Disparo calculado: " + base.Disparar();

        public override string Inspeccionar() =>
            "Revisión táctica: " + base.Inspeccionar();
    }
}
