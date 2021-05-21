using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic :BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData;
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }
        public UsuarioLogic() 
        {
            UsuarioData = new UsuarioAdapter();
        }

        public List<Usuario> GetAll()
        {
            List <Usuario> lista = UsuarioData.GetAll();


            return lista;
        }
        public Usuario GetOne(int id)
        {
            Usuario user = UsuarioData.GetOne(id);


            return user;
        }
        public void Delete(int id)
        {
         UsuarioData.Delete(id);


            
        }
        public void Save(Usuario user)
        {
            UsuarioData.Save(user);
        }




    }


}
