using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearPopo.IDAL
{
    interface IBaseDAL<T>
    {
        T SelectByPK(int id);

        IList<T> SelectByContions(T obj);

        int AddObj(T obj);

        int UpdateObj(T obj);

        int DeleteObj(int id);
    }
}
