using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaAutomatizada.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AgendaDbContext _dbContext;

        public UnitOfWork(AgendaDbContext dbContext)
        {
            _dbContext = dbContext;

            //NombreDelObjeto = new NombreDelRepository(_dbContext);
        }

        //public INombreDelInterfazDelRepositorio NombreDelObjeto { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
 