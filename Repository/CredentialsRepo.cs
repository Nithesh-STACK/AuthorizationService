using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationService.KaniniModel;

namespace AuthorizationService.Repository
{
    public class CredentialsRepo : ICredentialsRepo
    {
        private readonly stationaryContext db = new stationaryContext();
        public List<Logintabl> GetCredentials()
        {
            return db.Logintabls.ToList();

        }
    }
}
