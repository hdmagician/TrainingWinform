using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    public class ChildClass : BaseClass, iParent // 인터페이스는 여러개 넣을 수 있다.
    {
        public ChildClass()
        {

        }

        public void AddMethod()
        {

        }

        public double GiveAccount() // ParentClass에 있었던 애가 왔음
        {
            throw new NotImplementedException();
        }
    }
}
