﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSPService
    {
        public List<LoaiSP> GetAll()
        {
            Model1 context = new Model1();
            return context.LoaiSPs.ToList();
        }
    }
}
