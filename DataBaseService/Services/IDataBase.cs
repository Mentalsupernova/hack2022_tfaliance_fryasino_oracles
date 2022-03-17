using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseService.Services
{
    interface IDataBase
    {
        string GetUserMessageFromBase();

        void AddUserToDataBase(string userId);

        void AddMessageFromUser(string userId, string Message);

        string GetMessageFromUser(string userId);

        string GetAllMesageFromUser(string userId);
    }
}
