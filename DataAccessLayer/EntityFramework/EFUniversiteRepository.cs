using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public class EFUniversiteRepository : IUniversiteDAL
  {
    private Context context;

    public EFUniversiteRepository()
    {
      context = new Context();
    }

    public void Ekle(Universite item)
    {
      throw new NotImplementedException();
    }

    public Universite GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Universite> GetList()
    {
      return context.Universites.Where(x => x.Silindi == false).ToList();
    }

    public void Guncelle(Universite item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
