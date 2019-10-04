using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test1.Infrastructure.EF.Repositories;

namespace test1.IoC
{
    public class Structuremap : Registry
    {
        public Structuremap()
        {
            For<IRepositoryCustomer>().Use<RepositoryCustomer>();
        }
    }
}
