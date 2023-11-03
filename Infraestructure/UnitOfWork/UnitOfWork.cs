using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repository;

namespace Infraestructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbFirstContext _context;
        private TeamRepository _teams;
        private DriverRepository _drivers;

        public UnitOfWork(DbFirstContext context)
        {
            _context = context;
        }

        public ITeam Teams
        {
            get
            {
                if (_teams == null)
                {
                    _teams = new TeamRepository(_context);
                }
                return _teams;
            }
        }

         public IDriver Drivers
        {
            get
            {
                if (_drivers == null)
                {
                    _drivers = new DriverRepository(_context);
                }
                return _drivers;
            }
        }

          public void Dispose()
        {
            _context.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}