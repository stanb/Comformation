using System;
using System.Collections.Generic;

namespace Comformation.IntrinsicFunctions
{
    public static class Fn
    {
        /// <summary>
        /// The intrinsic function Fn::Base64 returns the Base64 representation of the input string. This function is typically used to pass encoded data to Amazon EC2 instances by way of the UserData property.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-base64.html
        /// </summary>
        /// <param name="valueToEncode">The string value you want to convert to Base64.</param>
        public static Base64 Base64(Union<string, IntrinsicFunction> valueToEncode) => new Base64(valueToEncode);

        /// <summary>
        /// The intrinsic function Fn::Cidr returns the specified Cidr address block.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-cidr.html
        /// </summary>
        /// <param name="ipBlock">The user-specified default Cidr address block.</param>
        /// <param name="count">The number of subnets' Cidr block wanted. Count can be 1 to 256.</param>
        /// <param name="sizeMask">Optional. The digit covered in the subnet.</param>
        public static Cidr Cidr(
            Union<string, Ref, Select> ipBlock, 
            Union<string, Ref, Select> count, 
            Union<string, Ref, Select> sizeMask)
        {
            return new Cidr(ipBlock, count, sizeMask);
        }

        /// <summary>
        /// The intrinsic function Fn::FindInMap returns the value corresponding to keys in a two-level map that is declared in the Mappings section.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-findinmap.html
        /// </summary>
        /// <param name="mapName">The logical name of a mapping declared in the Mappings section that contains the keys and values.</param>
        /// <param name="topLevelKey">The top-level key name. Its value is a list of key-value pairs.</param>
        /// <param name="secondLevelKey">The second-level key name, which is set to one of the keys from the list assigned to TopLevelKey.</param>
        public static FindInMap FindInMap(
            Union<string, Ref, FindInMap> mapName, 
            Union<string, Ref, FindInMap> topLevelKey, 
            Union<string, Ref, FindInMap> secondLevelKey)
        {
            return new FindInMap(mapName, topLevelKey, secondLevelKey);
        }

        /// <summary>
        /// The Fn::GetAtt intrinsic function returns the value of an attribute from a resource in the template.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
        /// </summary>
        /// <param name="logicalId">The logical name (also called logical ID) of the resource that contains the attribute that you want.</param>
        /// <param name="attributeName">The name of the resource-specific attribute whose value you want. See the resource's reference page for details about the attributes available for that resource type.</param>
        public static GetAtt GetAtt(string logicalId, ResourceAttribute attributeName) => new GetAtt(logicalId, attributeName);

        /// <summary>
        /// The Fn::GetAtt intrinsic function returns the value of an attribute from a resource in the template.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
        /// </summary>
        /// <param name="logicalId">The logical name (also called logical ID) of the resource that contains the attribute that you want.</param>
        /// <param name="attributeName">The name of the resource-specific attribute whose value you want. See the resource's reference page for details about the attributes available for that resource type.</param>
        public static GetAtt GetAtt(string logicalId, Ref attributeName) => new GetAtt(logicalId, attributeName);

        /// <summary>
        /// The intrinsic function Fn::GetAZs returns an array that lists Availability Zones for a specified region.
        /// Because customers have access to different Availability Zones, the intrinsic function Fn::GetAZs enables template authors to write templates that adapt to the calling user's access. That way you don't have to hard-code a full list of Availability Zones for a specified region.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
        /// </summary>
        /// <param name="region">The name of the region for which you want to get the Availability Zones. Specifying an empty string is equivalent to specifying AWS::Region.</param>
        public static GetAZs GetAZs(string region = "") => new GetAZs(region);

        /// <summary>
        /// The intrinsic function Fn::GetAZs returns an array that lists Availability Zones for a specified region.
        /// Because customers have access to different Availability Zones, the intrinsic function Fn::GetAZs enables template authors to write templates that adapt to the calling user's access. That way you don't have to hard-code a full list of Availability Zones for a specified region.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
        /// </summary>
        /// <param name="region">The name of the region for which you want to get the Availability Zones. You can use the AWS::Region pseudo parameter to specify the region in which the stack is created.</param>
        public static GetAZs GetAZs(Ref region) => new GetAZs(region);
        
        /// <summary>
        /// The intrinsic function Fn::GetAZs returns an array that lists Availability Zones for a specified region.
        /// Because customers have access to different Availability Zones, the intrinsic function Fn::GetAZs enables template authors to write templates that adapt to the calling user's access. That way you don't have to hard-code a full list of Availability Zones for a specified region.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
        /// </summary>
        /// <param name="region">The name of the region for which you want to get the Availability Zones.</param>
        public static GetAZs GetAZs(Amazon.RegionEndpoint region) => new GetAZs(region);

        /// <summary>
        /// The intrinsic function Fn::ImportValue returns the value of an output exported by another stack. You typically use this function to create cross-stack references. In the following example template snippets, Stack A exports VPC security group values and Stack B imports them.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html
        /// </summary>
        /// <param name="sharedValueToImport">The stack output value that you want to import.</param>
        public static ImportValue ImportValue(
            Union<string, Base64, FindInMap, If, Join, Select, Split, Sub, Ref> sharedValueToImport)
        {
            return new ImportValue(sharedValueToImport);
        }

        /// <summary>
        /// The intrinsic function Fn::Join appends a set of values into a single value, separated by the specified delimiter.
        /// If a delimiter is the empty string, the set of values are concatenated with no delimiter.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-join.html
        /// </summary>
        /// <param name="delimeter">The value you want to occur between fragments. The delimiter will occur between fragments only. It will not terminate the final value.</param>
        /// <param name="listOfValues">The list of values you want combined.</param>
        public static Join Join(string delimeter, IEnumerable<Union<string, IntrinsicFunction>> listOfValues)
        {
            return new Join(delimeter, listOfValues);
        }

        /// <summary>
        /// The intrinsic function Fn::Select returns a single object from a list of objects by index.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-select.html
        /// </summary>
        /// <remarks>
        /// Fn::Select does not check for null values or if the index is out of bounds of the array.
        /// Both conditions will result in a stack error, so you should be certain that the index you choose is valid,
        /// and that the list contains non-null values.
        /// </remarks>
        /// <param name="index">The index of the object to retrieve. This must be a value from zero to N-1, where N represents the number of elements in the array.</param>
        /// <param name="listOfObjects">The list of objects to select from. This list must not be null, nor can it have null entries.</param>
        public static Select Select(
            Union<string, Ref, FindInMap> index,
            Union<string, IEnumerable<string>, FindInMap, GetAtt, GetAZs, If, Split, Ref> listOfObjects)
        {
            return new Select(index, listOfObjects);
        }

        /// <summary>
        /// To split a string into a list of string values so that you can select an element from the resulting string
        /// list, use the Fn::Split intrinsic function. Specify the location of splits with a delimiter, such as ,
        /// (a comma). After you split a string, use the Fn::Select function to pick a specific element.
        /// For example, if a comma-delimited string of subnet IDs is imported to your stack template, you can split
        /// the string at each comma. From the list of subnet IDs, use the Fn::Select intrinsic function to specify a
        /// subnet ID for a resource.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-split.html
        /// </summary>
        /// <param name="delimiter">A string value that determines where the source string is divided.</param>
        /// <param name="listOfValues">The string value that you want to split.</param>
        public static Split Split(string delimiter,
            Union<string, Base64, FindInMap, GetAtt, GetAZs, If, Join, Select, Ref> listOfValues)
        {
            return new Split(delimiter, listOfValues);
        }
        
        /// <summary>
        /// The intrinsic function Fn::Sub substitutes variables in an input string with values that you specify.
        /// In your templates, you can use this function to construct commands or outputs that include values that aren't
        /// available until you create or update a stack.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-sub.html
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
        /// List of literals' values
        /// If you're substituting only template parameters, resource logical IDs, or resource attributes in the String
        /// parameter, don't specify a variable map.
        /// </param>
        /// <returns></returns>
        public static Sub Sub(string pattern, params Sub.Item [] items) => new Sub(pattern, items);

        public static Ref Ref(string logicalId) => new Ref(logicalId);
        public static Ref Ref(PseudoParameter pseudoParameter) => new Ref(pseudoParameter);


        #region Conditions
        
        public static Equals Equals(
            Union<object, FindInMap, Ref, ConditionFunction> value1,
            Union<object, FindInMap, Ref, ConditionFunction> value2)
        {
            return new Equals(value1, value2);
        }

        public static And And(params Union<string, FindInMap, Ref, ConditionFunction, ConditionRef>[] conditions)
        {
            return new And(conditions);
        }

        public static Or Or(params Union<string, FindInMap, Ref, ConditionFunction, ConditionRef>[] conditions)
        {
            return new Or(conditions);
        }

        public static Not Not(Union<string, FindInMap, Ref, ConditionFunction, ConditionRef> condition)
        {
            return new Not(condition);
        }

        public static If If(
            string conditionName,
            Union<object, Base64, FindInMap, GetAtt, GetAZs, If, Join, Select, Ref> valueIfTrue,
            Union<object, Base64, FindInMap, GetAtt, GetAZs, If, Join, Select, Ref> valueIfFalse)
        {
            return new If(conditionName, valueIfTrue, valueIfFalse);
        }
        
        #endregion
    }
}
