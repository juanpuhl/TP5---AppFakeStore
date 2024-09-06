using AppFakeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Services
{
   
        public interface IUsuariosService
        {
            Task<IEnumerable<Usuario>> GetUsuariosAsync();
        }
    
}

