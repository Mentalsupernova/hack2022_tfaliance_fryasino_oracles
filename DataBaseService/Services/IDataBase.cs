using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO create timestamp fiueld for user arived
//TODO create field with timestamp last user communication
namespace DataBaseService.Services
{
    interface IDataBase
    {
        string GetUserMessageFromBase(string userID);

        void AddUserToDataBase(string userId);

        void AddMessageFromUser(string userId, string Message,DateTime time);

        string GetMessageFromUser(string userId);

        string GetAllMesageFromUser(string userId);


    }
}
