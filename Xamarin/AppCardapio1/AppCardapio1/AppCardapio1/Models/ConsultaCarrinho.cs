using System;
using System.Collections.Generic;
using System.Text;

namespace AppCardapio1.Models
{
    public class ConsultaCarrinho
    {
        //static object locker = new object();

        //MySqlConnection s;

        //public ConsultaCarrinho()
        //{
        //    s = DependencyService.Get<Conexao>().GetConnection();
        //    s.CreateTable<GravarPedidos>();
        //}

        ////Insert 
        //public int InsertDetails(GravarPedidos custDB)
        //{
        //    lock (locker)
        //    {
        //        return s.Insert(custDB);
        //    }
        //}

        ////Update 
        //public int UpdateDetails(GravarPedidos custDB)
        //{
        //    lock (locker)
        //    {
        //        return s.Update(custDB);
        //    }
        //}

        ////Delete 
        //public int DeleteNote(int id)
        //{
        //    lock (locker)
        //    {
        //        return s.Delete<GravarPedidos>(id);
        //    }
        //}

        ////Get all
        //public IEnumerable<GravarPedidos> GetList()
        //{
        //    return (from i in s.Table<GravarPedidos>() select i).ToList();
        //}


        //public int GetTotal()
        //{
        //    int gtot = 0;
        //    lock (locker)
        //    {
        //        List<GravarPedidos> items = (from i in Table<GravarPedidos>() select i).ToList();

        //        foreach (GravarPedidos x in items)
        //        {
        //            gtot += Convert.ToInt32(x.Total);

        //        }
        //    }
        //    return gtot;
        //}

        ////Dispose
        //public void Dispose()
        //{
        //    s.Dispose();
        //}
    }
}
