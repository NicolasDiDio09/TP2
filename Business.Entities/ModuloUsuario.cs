﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario: BusinessEntity
    {
        private int _IdUsuario;
        private int _IdModulo;
        private bool _PermiteAlta;
        private bool _PermititeBaja;
        private bool _PermititeModificacion;
        private bool _PermititeConsulta;

        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public bool PermiteAlta { get; set; }
        public bool PermiteBaja { get; set; }
        public bool PermiteModificacion { get; set; }
        public bool PermiteConsulta { get; set; }



    }
}
