using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Warehouse.Data.Helper;

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

        protected ARespository()
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(DatabaseName);
            
        }

        #endregion

        #region Methods

        protected string GetCollectionName()
        {
            return AttributeHelper.GetBsonCollectionAttributeName(typeof (T));
        }

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

        private async Task<T> GetByFiltrFirstAsync(FilterDefinition<T> filter)
        {
            var collection = GetCollection();
            var list = collection.Find(filter);
            return await list.FirstOrDefaultAsync();
        }

        public T GetByFiltrFirst(FilterDefinition<T> filter)
        {
            return GetByFiltrFirstAsync(filter).Result;
        }

        private async Task<List<T>> GetByFiltrAsync(FilterDefinition<T> filter)
        {
            var collection = GetCollection();
            var list = collection.Find(filter);
            return await list.ToListAsync();
        }

        public List<T> GetByFiltr(FilterDefinition<T> filter)
        {
            return GetByFiltrAsync(filter).Result;
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

        protected FilterDefinition<T> GetFilterById(ObjectId id)
        {
            return Builders<T>.Filter.Eq("_id", id);
        }

        protected FilterDefinition<T> GetFilterById(T item)
        {
            var type = typeof (T);
            var propertis = type.GetProperties();
            var properti = type.GetProperties().FirstOrDefault(x => x.PropertyType == typeof (ObjectId));
            var id = type.GetProperty(properti.Name).GetValue(item, null);
            return Builders<T>.Filter.Eq("_id", id);
        }

        protected UpdateDefinition<T> GetUpdateDefinition(T item)
        {
            UpdateDefinition<T> result = null;
            var elemnts = AttributeHelper.GetBsonElementAttributeList(item);

            var update = Builders<T>.Update;
            //return update.Set("Width", 1);
            foreach (var elemnt in elemnts)
            {
                if(result == null)
                    result = update.Set(elemnt.Key, elemnt.Value);
                else
                    result = result.Set(elemnt.Key, elemnt.Value);

            }
            return result;
        } 

        protected async Task<bool> UpdateAsync(T item)
        {
            var collection = GetCollection();
            var filter = GetFilterById(item);
            var update = GetUpdateDefinition(item);

            var result = await collection.UpdateOneAsync(filter, update);
            return result.IsModifiedCountAvailable;
        }

        public bool Update(T item)
        {
            return UpdateAsync(item).Result;
        }

        public bool Update(List<T> items)
        {
            var result = false;
            foreach (var item in items)
            {
                result = Update(item);
                if (!result)
                    break;
            }
            return result;
        }

     
        #endregion
    }
}