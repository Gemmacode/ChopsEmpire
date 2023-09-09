using JaysData.DTO;
using JaysData.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaysCore.Service
{
    public interface ICustomerRepo
    {
        void CreateCustomer(CreateCustomerDTO createCustomerDTO);
        Customer GetCustomerById(string id);
        void DeleteCustomerById(string id);
        
    }
}
