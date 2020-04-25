using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerTaskMasterTutorial.Model
{
    class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Intead of returning the namespace and class, we override the ToString method to give us the actual name of the status from the DB.
        public override string ToString()
        {
            return Name;
        }

    }
}
