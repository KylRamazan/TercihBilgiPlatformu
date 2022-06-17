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
  public class EFBolumRepository : IBolumDAL
  {
    private Context context;

    public EFBolumRepository()
    {
      context = new Context();
    }

    public void Ekle(Bolum item)
    {
      throw new NotImplementedException();
    }

    public Bolum GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Bolum> GetList()
    {
      return context.Bolums.Where(x => x.Silindi == false).ToList();
    }

    public void Guncelle(Bolum item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
