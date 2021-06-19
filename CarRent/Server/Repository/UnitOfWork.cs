﻿using CarRent.Server.Data;
using CarRent.Server.iRepository;
using CarRent.Server.IRepository;
using CarRent.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Make> Makes => 
                _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Model> Models =>
                _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Vehicle> Vehicles =>
                _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Color> Colors =>
                _colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Booking> Bookings =>
                _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers =>
                _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);
            
            foreach(var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdateBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
