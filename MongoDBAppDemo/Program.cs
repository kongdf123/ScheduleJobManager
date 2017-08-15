using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://demo:demo@localhost:27017/firstdb");//mongodb://demo:demo@localhost:27017/firstdb
            var firstDB = client.GetDatabase("firstdb");

            var collection = firstDB.GetCollection<BsonDocument>("bar");

            var doc = new BsonDocument {
                { "name","MongoDB"},
                { "type","database"},
                { "count",1},
                { "info",new BsonDocument {
                    { "x",203},
                    { "y",102}
                }}
            };

            collection.InsertOne(doc);
             


        }
    }
}
