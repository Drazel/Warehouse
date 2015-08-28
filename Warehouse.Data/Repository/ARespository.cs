using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Warehouse.Data.Repository
{
    public abstract class ARespository<T>
    {
        #region Constants

        private const string connectionString = "mongodb://localhost";
        private const string DatabaseName = "Warehouse";

        #endregion

        #region Properties

        protected IMongoDatabase _database { get; set; }

        #endregion

        #region Constructors

        public ARespository()
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(DatabaseName);
            
        }

        #endregion

        #region Methods

        protected abstract string GetCollectionName();
        public abstract bool Update(T item);
        public abstract bool Update(List<T> item);

        protected IMongoCollection<T> GetCollection()
        {
            return _database.GetCollection<T>(GetCollectionName());
        }

        private async Task<IEnumerable<T>> GetItemsListAsync()
        {
            var collection = GetCollection();
            var filter = new BsonDocument();
            return await collection.Find(filter).ToListAsync();
        }

        public IEnumerable<T> GetItemsList()
        {
            return GetItemsListAsync().Result;
        }

        private async Task<T> GetByIdAsync(ObjectId id)
        {
            var collection = GetCollection();
            var list = collection.Find(GetFilterById(id));
            return await list.FirstOrDefaultAsync();
        }

        public T GetById(string id)
        {
            return GetByIdAsync(ObjectId.Parse(id)).Result;
        }

        public T GetById(ObjectId id)
        {
            return GetByIdAsync(id).Result;
        }

        private async Task<bool> AddAsync(T item)
        {
            var result = false;
            try
            {
                var collection = GetCollection();
                await collection.InsertOneAsync(item);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public bool Add(T item)
        {
            return AddAsync(item).Result;
        }

        public async Task<bool> RemoveAsync(ObjectId id)
        {

            var result = false;
            try
            {
                var collection = GetCollection();
                var filter = GetFilterById(id);
                await collection.DeleteOneAsync(filter);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public bool Remove(ObjectId id)
        {
            return RemoveAsync(id).Result;
        }

        public bool Remove(string id)
        {
            return RemoveAsync(ObjectId.Parse(id)).Result;
        }

        public FilterDefinition<T> GetFilterById(ObjectId id)
        {
            return Builders<T>.Filter.Eq("_id", id);
        }
        #endregion
    }
}