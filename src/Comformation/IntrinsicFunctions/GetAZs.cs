using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Comformation.IntrinsicFunctions
{
    /// <summary>
    /// The intrinsic function Fn::GetAZs returns an array that lists Availability Zones for a specified region.
    /// Because customers have access to different Availability Zones, the intrinsic function Fn::GetAZs enables template authors to write templates that adapt to the calling user's access. That way you don't have to hard-code a full list of Availability Zones for a specified region.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
    /// </summary>
    public class GetAZs : IntrinsicFunction
    {
        private const string Name = "Fn::GetAZs";

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="region">The name of the region for which you want to get the Availability Zones. Specifying an empty string is equivalent to specifying AWS::Region.</param>
        public GetAZs(string region = "")
        {
            Token = new JObject(new JProperty(Name, region));
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="region">The name of the region for which you want to get the Availability Zones. You can use the AWS::Region pseudo parameter to specify the region in which the stack is created.</param>
        public GetAZs(Ref region)
        {
            Token = new JObject(new JProperty(Name, region.ToJson()));
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="region">The name of the region for which you want to get the Availability Zones.</param>
        public GetAZs(Amazon.RegionEndpoint region)
        {
            Token = new JObject(new JProperty(Name, region.SystemName));
        }
    }
}
