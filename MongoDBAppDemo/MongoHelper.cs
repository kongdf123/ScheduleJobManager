using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBAppDemo
{
    public class MongoHelper<T> where T : BaseEntity
    {
        IMongoDatabase database;
        MongoUrl mongoUrl = new MongoUrl(ConfigurationManager.AppSettings["MongoDBConnString"]);

        public MongoHelper()
        {
            MongoClientSettings settings = MongoClientSettings.FromUrl(mongoUrl);
            //TODO
            var client = new MongoClient(settings);
            database = client.GetDatabase(mongoUrl.DatabaseName);
        }

        IMongoCollection<T> GetCollection(string collectionName)
        {
            return database.GetCollection<T>(collectionName);
        }

        public T Find(string collectionName, Expression<Func<T, bool>> filter)
        {
            var collection = GetCollection(collectionName);
            return collection.Find(filter).FirstOrDefault();
        }

        public IFindFluent<T,T> FindMany(string collectionName, Expression<Func<T, bool>> filter)
        {
            var collection = GetCollection(collectionName);
            return collection.Find(filter);
        }

        public void Insert(string collectionName, T document)
        {
            var collection = GetCollection(collectionName);
            collection.InsertOne(document);
        }

        public void Insert(string collectionName, IEnumerable<T> documents)
        {
            var collection = GetCollection(collectionName);
            collection.InsertMany(documents);
        }

        public long Update(string collectionName, T document, Expression<Func<T, bool>> filter)
        {
            var collection = GetCollection(collectionName);
            BsonDocument docUpdate = document.ToBsonDocument<T>();
            docUpdate.Remove("_id");

            UpdateDocument updateDifinition = new UpdateDocument("$set", docUpdate);
            var result = collection.UpdateMany(filter, updateDifinition, new UpdateOptions { IsUpsert = false });

            return result.ModifiedCount;
        }

        public long Delete(string collectionName, Expression<Func<T, bool>> filter)
        {
            var collection = GetCollection(collectionName);
            DeleteResult result = collection.DeleteOne(filter);
            return result.DeletedCount;
        }
    }
}
