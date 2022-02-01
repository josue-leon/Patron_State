using System;
using System.Collections.Generic;
using System.Text;

namespace State {
    public class Nuevo_Estado : Estado {
        public override void ControlarEstado(Switch sw) {
            sw.DefinirEstado(new Encendido());
        }

        public override string Describir() {
            return "SW Nuevo Estado";
        }
    }
}
