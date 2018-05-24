using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::Sub substitutes variables in an input string with values that you specify.
    /// In your templates, you can use this function to construct commands or outputs that include values that aren't
    /// available until you create or update a stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-sub.html
    /// </summary>
    public class Sub : IntrinsicFunction
    {
        private const string Name = "Fn::Sub";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pattern">
        /// A string with variables that AWS CloudFormation substitutes with their associated values at runtime.
        /// Write variables as ${MyVarName}. Variables can be template parameter names, resource logical IDs, resource
        /// attributes, or a variable in a key-value map. If you specify only template parameter names, resource logical
        /// IDs, and resource attributes, don't specify a key-value map.
        /// If you specify template parameter names or resource logical IDs, such as ${InstanceTypeParameter},
        /// AWS CloudFormation returns the same values as if you used the Ref intrinsic function. If you specify
        /// resource attributes, such as ${MyInstance.PublicIp}, AWS CloudFormation returns the same values as if you
        /// used the Fn::GetAtt intrinsic function.
        /// To write a dollar sign and curly braces (${}) literally, add an exclamation point (!) after the open curly
        /// brace, such as ${!Literal}. AWS CloudFormation resolves this text as ${Literal}.
        /// </param>
        /// <param name="items">
        /// List of literals' values.
        /// If you're substituting only template parameters, resource logical IDs, or resource attributes in the String
        /// parameter, don't specify a variable map.
        /// </param>
        public Sub(string pattern, params Item [] items)
        {
            if (items.Any())
            {
                var obj = new JObject();
                foreach (var item in items)
                {
                    obj.Add(item.Name, item.Value.ToJson());
                }
                Token = new JObject(new JProperty(Name, new JArray(pattern, obj)));
            }
            else
            {
                Token = new JObject(new JProperty(Name, pattern));
            }
        }

        public class Item
        {
            /// <summary>
            /// The name of a variable that you included in the String parameter.
            /// </summary>
            public string Name { get; set; }
            
            /// <summary>
            /// The value that AWS CloudFormation substitutes for the associated variable name at runtime.
            /// </summary>
            public Union<Base64, FindInMap, GetAtt, GetAZs, If, ImportValue, Join, Select, Ref> Value { get; set; }

            public Item()
            {
            }
            
            public Item(string name, Union<Base64, FindInMap, GetAtt, GetAZs, If, ImportValue, Join, Select, Ref> value)
            {
                Name = name;
                Value = value;
            }
        }
    }
}
