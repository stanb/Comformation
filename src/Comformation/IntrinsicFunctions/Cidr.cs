using Newtonsoft.Json.Linq;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::Cidr returns the specified Cidr address block.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-cidr.html
    /// </summary>
    public class Cidr : IntrinsicFunction
    {
        private const string Name = "Fn::Cidr";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ipBlock">The user-specified default Cidr address block.</param>
        /// <param name="count">The number of subnets' Cidr block wanted. Count can be 1 to 256.</param>
        /// <param name="sizeMask">Optional. The digit covered in the subnet.</param>
        public Cidr(
            Union<string, Ref, Select> ipBlock, 
            Union<string, Ref, Select> count, 
            Union<string, Ref, Select> sizeMask = null)
        {
            var args = sizeMask == null ? new[] {ipBlock, count} : new[] {ipBlock, count, sizeMask};
            Token = new JObject(
                new JProperty(Name, 
                    JArray.FromObject(args)));
        }
    }
}
