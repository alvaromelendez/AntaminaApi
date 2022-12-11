using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class ModelWorkOrder
    {
        public Guid IdWorkOrder { get; set; }
        public string ShortText { get; set; }
        public int Quantity { get; set; }
        public int Duration { get; set; }
        List<Component> Components { get; set; }
    }

    public class Component
    {
        public Guid IdComponent { get; set; }
        public int Quantity { get; set; }
        public string Operation { get; set; }


    }
}
