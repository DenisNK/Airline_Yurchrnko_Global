﻿using System.Linq;
using Airline.DAL.IRepository.IEntityRepository;
using Airline.DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Airline.BLL.Repository.EntityRepository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DbContext context) : base(context) { }
        public IQueryable<Teacher> GetAllOrderedByName()
        {
            return _dbSet
                .OrderBy(c => c.Name)
                .AsNoTracking();
        }
        public SelectList SelectListTeacherName()
        {
            var a = _dbSet
                .OrderBy(c => c.Name)
                .AsNoTracking();

            return new SelectList(a, "Id", "Name");
        }

        public SelectList SelectListTeacherName(int? selectId)
        {
            return new SelectList(_dbSet.OrderBy(c => c.Name)
                .AsNoTracking(), "Id", "Name", selectId);
        }
    }
}