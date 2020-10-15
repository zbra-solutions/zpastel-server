﻿using System.Collections.Generic;
using System.IO;
using ZPastel.Model;
using ZPastel.Persistence;

namespace ZPastel.Test.DbSeed.DataSeed
{
    public class DataSeedService
    {

        private const string PastelDataFilePath = "./DbSeed/JSON/PastelEntities.json";
        private const string PasteleiroDataFilePath = "./DbSeed/JSON/PasteleiroEntities.json";
        private const string UseroDataFilePath = "./DbSeed/JSON/UserEntities.json";

        private readonly IDataContext dataContext;

        public DataSeedService(DataContext dataContext)
        {
            dataContext.Database.EnsureDeleted();
            dataContext.Database.EnsureCreated();

            this.dataContext = dataContext;
        }

        public void Seed()
        {
            SeedEntities<Pasteleiro>(PasteleiroDataFilePath);
            SeedEntities<User>(UseroDataFilePath);
            SeedEntities<Pastel>(PastelDataFilePath);
        }

        private void SeedEntities<T>(string filePath) where T : class
        {
            var jsonString = File.ReadAllText(filePath);

            var entities = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<T>>(jsonString);

            dataContext.AddRange(entities);
            dataContext.SaveChanges();
        }
    }
}
