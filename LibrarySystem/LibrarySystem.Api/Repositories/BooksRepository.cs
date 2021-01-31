﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Api.Context;
using LibrarySystem.Api.Interfaces;

namespace LibrarySystem.Api.Repositories
{
    public class BooksRepository:IBooksRepository
    {
        private readonly LibraryDbContext _context;
        public BooksRepository(LibraryDbContext context)
        {
            _context = context;
        }
    }
}
