using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private string _descComision;
        private Anios _anioEspecialidad;

        public string DescComision
        {
            get
            {
                return _descComision;
            }
            set
            {
                _descComision = value;
            }
        }
        public Anios AnioEspecialidad
        {
            get
            {
                return _anioEspecialidad;
            }
            set
            {
                _anioEspecialidad = value;
            }
        }
        public int IdPlan { get; set; }

        public enum Anios
        {
            Primero=1,
            Segundo=2,
            Tercero=3,
            Cuarto=4,
            Quinto=5,
            Sexto=6
        }
    }
}