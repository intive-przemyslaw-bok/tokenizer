using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenizerBase.BussinessObjects;
using TokenizerBase.Interfaces;

namespace TokenizerRepository
{
    public class TokenizerSQLRepository : ITokenManagerRepository, ITokenValuesReaderRepository
    {
        public DeployEnviroment AddEnviroment(string name)
        {
            throw new NotImplementedException();
        }

        public Project AddProject(string name)
        {
            throw new NotImplementedException();
        }

        public Token AddToken(string name, int idProject)
        {
            throw new NotImplementedException();
        }

        public TokenValue AddTokenValue(int idProject, int idEnviroment, int idToken, string Value)
        {
            throw new NotImplementedException();
        }

        public Project GetEnviroment(string name)
        {
            throw new NotImplementedException();
        }

        public DeployEnviroment GetEnviroments()
        {
            throw new NotImplementedException();
        }

        public Project GetProject(string name)
        {
            throw new NotImplementedException();
        }

        public Project[] GetProjects()
        {
            throw new NotImplementedException();
        }

        public Token[] GetProjectTokens(int projectId)
        {
            throw new NotImplementedException();
        }

        public SortedDictionary<Token, Dictionary<DeployEnviroment, TokenValue>> GetTokenValueDictionary(int idProject)
        {
            throw new NotImplementedException();
        }

        public SortedDictionary<Token, TokenValue> GetTokenValueDictionary(int idProject, int idEnviroment)
        {
            throw new NotImplementedException();
        }

        public TokenValue[] GetTokenValues(int idProject)
        {
            throw new NotImplementedException();
        }

        public TokenValue[] GetTokenValues(int idProject, int idEnviroment)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProject(int idProject)
        {
            throw new NotImplementedException();
        }

        public bool RemoveToken(int idToken)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTokenValue(int idTokenValue)
        {
            throw new NotImplementedException();
        }

        public bool RenoveEnviroment(int idEnviroment)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEnviroment(DeployEnviroment enviroment)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public bool UpdateToken(Token token)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTokenValue(TokenValue tokenValue)
        {
            throw new NotImplementedException();
        }
    }
}
