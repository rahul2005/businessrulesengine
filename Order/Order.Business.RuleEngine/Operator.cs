using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Order.Business.RuleEngine
{
    public static class Operator
    {
        private static Dictionary<string, Func<object, string>> s_operators;
        private static Dictionary<string, PropertyInfo> s_properties;
        static Operator()
        {
            s_operators = new Dictionary<string, Func<object, string>>();
            s_operators["purpose"] = new Func<object, string>(s_opPurpose);

            s_properties = typeof(Payment).GetProperties().ToDictionary(propInfo => propInfo.Name);
        }

        public static void Apply(this Payment payment, string op, string prop)
        {
            payment.NextAction = s_operators[op](GetPropValue(payment, prop));
        }

        private static object GetPropValue(Payment user, string prop)
        {
            PropertyInfo propInfo = s_properties[prop];
            return propInfo.GetGetMethod(false).Invoke(user, null);
        }

        #region Operators

        static string s_opPurpose(object o1)
        {
            string nextAction = string.Empty;
            switch (o1)
            {
                case "PhysicalProduct":
                    nextAction = "Generate a packing slip for shipping.";
                    break;
                case "Book":
                    nextAction = "Create a duplicate packing slip for the royalty department.";
                    break;
                case "Membership":
                    nextAction = "Activate the membership.";
                    break;
                case "UpgradeMembership":
                    nextAction = "Apply for upgrade.";
                    break;
                case "ActiveOrUpdateMembership":
                    nextAction = "e-mail the owner and inform them of the activation/upgrade.";
                    break;
                case "Video":
                    nextAction = "Add a free 'First Aid' video to the packaging slip.";
                    break;
                case "PhysicalProductOrBook":
                    nextAction = "Generate a commission payment to the agent.";
                    break;
                default:
                    break;
            }

            return nextAction;
        }

        //etc.

        #endregion       
    }
}
