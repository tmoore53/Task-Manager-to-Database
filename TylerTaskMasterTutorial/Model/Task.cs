using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerTaskMasterTutorial.Model
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }

        //relationship between the 2 classes

        public int StatusId { get; set; }

        //Navigation Property, Reference to the status class itself

        public Status Status { get; set; }
    }
}
