using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Models;
using Catalog.API.Entities;

namespace Catalog.API.Service
{
    public class GroupOfDetailService
    {
        private readonly IMongoCollection<GroupOfDetail> _groupOf;

        public GroupOfDetailService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _groupOf = database.GetCollection<GroupOfDetail>(settings.GroupOfDetailCollectionName);
        }

        public List<GroupOfDetail> Get() =>
            _groupOf.Find(book => true).ToList();

        public GroupOfDetail Get(string id) =>
            _groupOf.Find<GroupOfDetail>(group => group.Id == id).FirstOrDefault();

        public GroupOfDetail Create(GroupOfDetail group)
        {
            _groupOf.InsertOne(group);
            return group;
        }

        public void Update(string id, GroupOfDetail group) =>
            _groupOf.ReplaceOne(group => group.Id == id, group);

        public void Remove(GroupOfDetail group) =>
            _groupOf.DeleteOne(groupOf => groupOf.Id == group.Id);

        public void Remove(string id) =>
            _groupOf.DeleteOne(group => group.Id == id);
    }
}
