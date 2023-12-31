﻿using Fatec.eComm.Domain.Core.Data;

namespace Fatec.eComm.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDataContext _context;
        public UnitOfWork(ApplicationDataContext context)
        {
            _context = context;
        }
        public void Dispose() => _context.Dispose();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
