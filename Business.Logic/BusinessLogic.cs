using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class BusinessLogic
    {
        private UsuarioAdapter _UsuarioData;

        public UsuarioAdapter UsuarioData
        {
            get 
            {
                return _UsuarioData;
            }
            set 
            {
                _UsuarioData = value;
            }
        }

    }
}
