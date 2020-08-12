using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Outside : Location 
    {

        public bool Hot { get; }

        public Outside(string name, bool hot) : base(name)
        {
            Hot = hot;
        }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (Hot)
                {
                    NewDescription += " Тут очень жарко.";
                }
                return NewDescription;
            }
        }
    }
}
