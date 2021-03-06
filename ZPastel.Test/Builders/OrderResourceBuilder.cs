﻿using System.Collections.Generic;
using ZPastel.API.Resources;

namespace ZPastel.Test.Builders
{
    public class OrderResourceBuilder
    {
        private readonly OrderResource orderResource;

        public OrderResourceBuilder()
        {
            orderResource = new OrderResource();
        }

        public OrderResourceBuilder WithDefaultValues()
        {
            orderResource.CreatedById = 1;
            orderResource.CreatedByUsername = "Tester";
            orderResource.TotalPrice = 4;
            orderResource.OrderItems = new[]
            {
                new OrderItemResource
                {
                    CreatedById = 1,
                    Ingredients = "Queijo",
                    PastelId = 1,
                    Price = 4,
                    Quantity = 1,
                    Name = "4 Queijos"
                }
            };

            return this;
        }

        public OrderResourceBuilder WithCreatedById(long createdById)
        {
            orderResource.CreatedById = createdById;

            return this;
        }

        public OrderResourceBuilder WithTotalPrice(long totalPrice)
        {
            orderResource.TotalPrice = totalPrice;

            return this;
        }

        public OrderResourceBuilder WithCreatedByUsername(string createdByUsername)
        {
            orderResource.CreatedByUsername = createdByUsername;

            return this;
        }

        public OrderResourceBuilder WithOrderItems(IList<OrderItemResource> orderItemResources)
        {
            orderResource.OrderItems = orderItemResources;

            return this;
        }

        public OrderResource Build() => orderResource;
    }
}
