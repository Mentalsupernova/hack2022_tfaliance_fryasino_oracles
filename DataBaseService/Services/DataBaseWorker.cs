using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Services
{
    public class DataBaseWorker : IDataBase
    {
        public DataBaseWorker()
        {
            
        }

        public void AddMessageFromUser(string userId, string Message)
        {
            throw new NotImplementedException();
        }

        public void AddUserToDataBase(string userId)
        {
            throw new NotImplementedException();
        }

        public string GetAllMesageFromUser(string userId)
        {
            throw new NotImplementedException();
        }

        public string GetMessageFromUser(string userId)
        {
            throw new NotImplementedException();
        }

        public string GetUserMessageFromBase()
        {
            throw new NotImplementedException();
        }
    }
}
