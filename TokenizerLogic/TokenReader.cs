using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenizerBase.BussinessObjects;
using TokenizerBase.Interfaces;

namespace TokenizerLogic
{
    public class TokenReader
    {
        protected ITokenValuesReaderRepository repository = null;
        public TokenReader(ITokenValuesReaderRepository repository)
        {
            this.repository = repository;
        }

        public Project GetProject(string projectName)
        {
            return repository.GetProject(projectName);
        }

        public DeployEnviroment GetEnviromentForProject(string enviromentName)
        {
            throw new NotImplementedException();
        }
    }
}
