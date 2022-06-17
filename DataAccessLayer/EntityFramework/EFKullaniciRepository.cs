﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public class EFKullaniciRepository : IKullaniciDAL
  {
    private Context context;

    public EFKullaniciRepository()
    {
      context = new Context();
    }
    public void Ekle(Kullanici item)
    {
      item.Silindi = false;
      item.KayitTarihi = DateTime.Now;
      var entry = context.Entry(item);
      entry.State = EntityState.Added;
      context.SaveChanges();
    }

    public Kullanici GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Kullanici> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Kullanici item)
    {
      var kullanici = context.Kullanicis.FirstOrDefault(x => x.KullaniciID == item.KullaniciID);

      kullanici.Sifre = item.Sifre;

      var entry = context.Entry(kullanici);
      entry.State = EntityState.Modified;
      context.SaveChanges();
    }

    public void SifreGuncelle(string item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
