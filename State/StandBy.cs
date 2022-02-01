using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class StandBy : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Nuevo_Estado());
        }

        public override string Describir()
        {
            return "Switch en stand by";
        }
    }
}
