using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecreateGeneric
{
    public class NodeClass <T> //To make the NodeClass Generic
    {
        //Property: The data that the  NodeClass is going to store
        public T Data { get; set; }

        //Link: Pointing to the next item

        public NodeClass<T> Next { get; set; }
        public T NextItem { get;  set; }

        public T AddFirstItem { get; set; }

        public T AddLastItem { get; set; }


        //Constructor
        public NodeClass(T data)
        {
            this.Data = data; // this.Data = data as a parameter
        }



    }
}
