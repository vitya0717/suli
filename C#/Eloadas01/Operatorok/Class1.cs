using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    internal class CustomObject
    {
        private string name;
        private ObjType objtype;
        private int id;

        public CustomObject()
        {

        }

        public CustomObject(string name)
        {
            this.name = name;
        }
        public CustomObject(int id, string name, ObjType type)
        {
            this.id = id;
            this.name = name;
            this.objtype = type;
        }

        public string getName()
        {
            return name;
        }
        
        public ObjType getType()
        {
            return objtype;
        }

    }
}
