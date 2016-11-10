using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenizerBase.Interfaces;

namespace TokenizerLogic
{
    public class TokenManager
    {
        protected ITokenManagerRepository repository = null;
        public TokenManager(ITokenManagerRepository repository)
        {
            this.repository = repository;
        }
    }
}
