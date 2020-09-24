﻿using System.Collections.Generic;
using System.IO;
using ZPastel.Persistence;
using ZPastel.Persistence.Model;

namespace ZPastel.Test.DbSeed.DataSeed
{
    public class DataSeedService
    {

        private const string PastelDataFilePath = "./DbSeed/JSON/PastelEntities.json";
        private const string OrderDataFilePath = "./DbSeed/JSON/OrderEntities.json";

        private readonly IDataContext dataContext;

        public DataSeedService(DataContext dataContext)
        {
            dataContext.Database.EnsureDeleted();
            dataContext.Database.EnsureCreated();

            this.dataContext = dataContext;
        }

        public void Seed()
        {
            SeedEntities<PastelEntity>(PastelDataFilePath);
            SeedEntities<OrderEntity>(OrderDataFilePath);

            dataContext.SaveChanges();
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
