using JaysData.DTO;
using JaysData.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaysCore.Service
{
    public interface IOrderRepo
    {
        void CreateOrder(CreateOrderDTO order);
        Order GetOrderById(string Id);

        void DeleteOrderById(string Id);
    }
}
