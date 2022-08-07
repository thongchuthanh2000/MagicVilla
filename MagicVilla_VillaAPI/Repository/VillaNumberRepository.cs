﻿using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaNumberRepository :Repository<VillaNumber>,  IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

       
        public async Task<VillaNumber> UpdateAsync(VillaNumber villaNumber)
        {
            villaNumber.UpdateDate = DateTime.Now;             
            _db.VillaNumbers.Update(villaNumber);
            await _db.SaveChangesAsync();
            return villaNumber;
        }

    }
}
