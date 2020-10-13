﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ZPastel.Model;
using ZPastel.Service.Contract;
using ZPastel.Service.Repositories;

namespace ZPastel.Service.Impl
{
    public class PastelService : IPastelService
    {
        private readonly IPastelRepository pastelRepository;

        public PastelService(IPastelRepository pastelRepository)
        {
            this.pastelRepository = pastelRepository;
        }

        public async Task<IReadOnlyList<Pastel>> FindAll()
        {
            return await pastelRepository.FindAll();
        }
    }
}
