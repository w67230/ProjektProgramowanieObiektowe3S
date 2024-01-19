using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKlas
{
    public interface Dzialania<T, ID>
    {

        T Get(ID id);
        List<T> GetAll();
        void Create(T t);
        void Update(T t);
        void Delete(ID id);
        void WriteFile(List<T> list);

    }
}
