using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDBAppDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBAppDemo
{
    public static class MongoCollectionExtension
    {
        /// <summary>  
        /// ObjectId - Default Key
        /// </summary>  
        readonly static string OBJECTID_KEY = "_id";

        public static bool Update<T>(this MongoCollection<T> collection, IMongoQuery query, IMongoUpdate update) where T : BaseEntity
        {
            WriteConcernResult result = collection.Update(query, update, UpdateFlags.Multi);            
            return result.HasLastErrorMessage;
        }

        public static bool Insert<T>(this MongoCollection<T> collection, T document) where T : BaseEntity
        {
            BsonDocument bd = document.ToBsonDocument();
            WriteConcernResult result = collection.Insert(bd);
            return result.HasLastErrorMessage;
        }

        public static bool Insert<T>(this MongoCollection<T> collection, List<T> documents) where T : BaseEntity
        {
            List<BsonDocument> bsonList = new List<BsonDocument>();
            documents.ForEach(t => bsonList.Add(t.ToBsonDocument()));
            IEnumerable<WriteConcernResult> results = collection.InsertBatch(bsonList);
            return results.ToList().Exists(x => x.HasLastErrorMessage);
        }

        public static T Find<T>(this MongoCollection<T> collection, IMongoQuery query) where T : BaseEntity
        {
            return collection.FindOne(query);
        }

        public static List<T> FindMany<T>(this MongoCollection<T> collection, IMongoQuery query) where T : BaseEntity
        {
            MongoCursor<T> mongoCursor = collection.Find(query);
            return mongoCursor.ToList();
        }

        public static List<T> FindMany<T>(this MongoCollection<T> collection, IMongoQuery query, SortByDocument sortby, int pageIndex, int pageSize) where T : BaseEntity
        {
            if (query == null)
            {
                query = Query.Exists(OBJECTID_KEY);
            }

            if (sortby == null)
            {
                sortby = new SortByDocument(OBJECTID_KEY, -1);
            }

            MongoCursor<T> cursor = collection.FindAs<T>(query).SetSortOrder(sortby).SetSkip(Math.Max(1, pageIndex)).SetLimit(pageSize);
            return cursor.ToList();
        }

        public static long Count<T>(this MongoCollection<T> collection, IMongoQuery query) where T : BaseEntity
        {
            if (query == null)
            {
                query = Query.Exists(OBJECTID_KEY);
            }
            return collection.Count(query);
        }

        /*
             var post = _posts.Collection.Find(Query.EQ("_id", postId)).SetFields(Fields.Exclude("Date", "Title", "Url", "Summary", "Details", "Author", "TotalComments").Slice("Comments", -skip, limit)).Single();
    return post.Comments.OrderByDescending(c => c.Date).ToList();
         */

    }
}
