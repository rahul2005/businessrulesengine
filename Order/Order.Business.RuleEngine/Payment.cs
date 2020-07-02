using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Order.Business.RuleEngine
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string Purpose { get; set; }
        public string NextAction { get; set; }
    }
    
}
