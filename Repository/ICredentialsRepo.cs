using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationService.KaniniModel;

namespace AuthorizationService.Repository
{
    public interface ICredentialsRepo
    {
        public List<Logintabl> GetCredentials();
    }
}
