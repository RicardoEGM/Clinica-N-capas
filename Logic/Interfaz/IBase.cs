using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaz
{
    public interface IBase<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity GetbyID(int ID);
        bool Add(TEntity entity);
        bool AddDiagnóstico(int IDCita, string diagnóstico);
    }
}
