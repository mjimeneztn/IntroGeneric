using System.Collections.Generic;

namespace stations {
    public interface IStation<T>
    {
        int Capacity {get; set;}
        void Refuel(List<T> vehicles);
    }
}