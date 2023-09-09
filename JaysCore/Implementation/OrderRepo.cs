using JaysCore.Service;
using JaysData.DTO;
using JaysData.Entitties;
using JaysData.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaysCore.Implementation
{
    public class OrderRepo : IOrderRepo
    {
        private readonly UserDbContext myDbContext;

        public OrderRepo(UserDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }
        public void CreateOrder(CreateOrderDTO createOrderDto)
        {
            var result = new Order()
            {
                
                OrderType = createOrderDto.OrderType,
                Price = createOrderDto.Price,
                Quantity = createOrderDto.Quantity,
                Id = Guid.NewGuid().ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsDeleted = false,
                CustomerId = createOrderDto.CustomerId
            };
            myDbContext.Add(result);
            myDbContext.SaveChanges();
        }
        public Order GetOrderById(string Id)
        {
            var result = myDbContext.Order1.SingleOrDefault(x => x.Id == Id);
            return result;
        }

        public void DeleteOrderById(string Id)
        {
            var order = myDbContext.Order1.SingleOrDefault(x => x.Id == Id);
            myDbContext.Order1.Remove(order);
            myDbContext.SaveChanges();
            
        }
    }
}


