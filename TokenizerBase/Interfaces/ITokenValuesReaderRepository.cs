using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenizerBase.BussinessObjects;

namespace TokenizerBase.Interfaces
{
    public interface ITokenValuesReaderRepository
    {

        Project[] GetProjects();

        Project GetProject(string name);

        Project GetEnviroment(string name);

        DeployEnviroment GetEnviroments();

        Token[] GetProjectTokens(int projectId);

        SortedDictionary<Token, TokenValue> GetTokenValueDictionary(int idProject, int idEnviroment);

        TokenValue[] GetTokenValues(int idProject, int idEnviroment);
    }
}
