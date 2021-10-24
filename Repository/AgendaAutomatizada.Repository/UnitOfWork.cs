using AgendaAutomatizada.Domain.SQL;
using AgendaAutomatizada.Interfaces;
using AgendaAutomatizada.Interfaces.IRepositories;
using AgendaAutomatizada.Repository.Repositories;
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

            Usuarios = new UsuarioRepository(_dbContext);
            Tandas = new TandaRepository(_dbContext);
            //NombreDelObjeto = new NombreDelRepository(_dbContext);
        }

        public IUsuarioRepository Usuarios { get; private set; }
        public ITandaRepository Tandas { get; private set; }
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
 