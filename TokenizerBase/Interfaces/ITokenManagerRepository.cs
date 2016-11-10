using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenizerBase.BussinessObjects;

namespace TokenizerBase.Interfaces
{
    public interface ITokenManagerRepository
    {
        Project AddProject(string name);

        bool UpdateProject(Project project);

        bool RemoveProject(int idProject);

        Project[] GetProjects();


        DeployEnviroment AddEnviroment(string name);

        bool UpdateEnviroment(DeployEnviroment enviroment);

        bool RenoveEnviroment(int idEnviroment);

        DeployEnviroment GetEnviroments();


        Token AddToken(string name, int idProject);

        bool UpdateToken(Token token);

        bool RemoveToken(int idToken);

        Token[] GetProjectTokens(int projectId);


        TokenValue AddTokenValue(int idProject, int idEnviroment, int idToken, string Value);

        bool UpdateTokenValue(TokenValue tokenValue);

        bool RemoveTokenValue(int idTokenValue);

        SortedDictionary<Token, Dictionary<DeployEnviroment, TokenValue>> GetTokenValueDictionary(int idProject);

        TokenValue[] GetTokenValues(int idProject);
    }
}
