using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamService
    {
        public List<Sanpham> GetAll()
        {
            Model1  context = new Model1();  
            return context.Sanphams.ToList();
        }
        //public List<Sanpham> FindByName(string TenSP)
        //{
        //    Model1 context = new Model1();
        //    return context.Sanphams.Where(p => p.TenSP.Contains(TenSP)).ToList();
        //}
        public Sanpham FindById(String SanPhamID)
        {
            Model1 context = new Model1();
            return context.Sanphams.FirstOrDefault(p => p.MaSP == SanPhamID);
        }
        public void InsertUpdate(Sanpham s)
        {
            Model1 context = new Model1();
            context.Sanphams.AddOrUpdate(s);
            context.SaveChanges();
        }
        // Xóa sinh viên
        public void DeleteStudent(string sanPhamID)
        {
            Model1 context = new Model1();
          
            var sanpham = context.Sanphams.Find(sanPhamID);
            if (sanpham != null)
            {
                context.Sanphams.Remove(sanpham);
                context.SaveChanges();
            }
        }
    }
}
