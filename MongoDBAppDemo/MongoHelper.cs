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
        public MongoCollection<T> Collection { get; private set; }

        public MongoHelper()
        {
            MongoUrl mongoUrl = new MongoUrl(ConfigurationManager.ConnectionStrings["MongoDBConnString"].ConnectionString);
            MongoClientSettings settings = MongoClientSettings.FromUrl(mongoUrl);
            //TODO
            var client = new MongoClient(settings);
            var db = client.GetDatabase(mongoUrl.DatabaseName);
            Collection = (MongoCollection<T>)(db.GetCollection<T>(typeof(T).Name.ToLower()));
        }
    }
}
