using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class Node
    {
        public CompanyShares Data;
        public Node Next;
        public Node(CompanyShares data) 
        {
            Data = data;
            this.Next = Next;
        }
    }
}
