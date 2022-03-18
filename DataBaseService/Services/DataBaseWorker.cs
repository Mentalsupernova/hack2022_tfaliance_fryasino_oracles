using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataBaseService.Services
{
    public class DataBaseWorker : IDataBase
    {
        protected string ConnectStringToDataBase = "mongodb://undead_sheep:foxtrot_uniform@127.0.0.1:27017";
        MongoClient client;
        IMongoDatabase UsersTable;
        public DataBaseWorker()
        {
            /*client = new MongoClient(ConnectStringToDataBase);
            client.StartSession();*/
        }

        public void ConnectToDataBase()
        {


        }


        


        public void AddMessageFromUser(string userId, string Message,DateTime time)
        {
            UsersTable = client.GetDatabase("users");
            //UsersTable.data
            throw new NotImplementedException();
        }

        public void AddUserToDataBase(string userId)
        {
            var database = client.GetDatabase("Users");

            //get mongodb collection
            //var collection = database.GetCollection<string>("users");

            //await collection.InsertOneAsync(new <string> { Name = "Jack" });

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

        public string GetUserMessageFromBase(string userID)
        {
            throw new NotImplementedException();
        }
    }
}
