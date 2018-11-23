using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Fleet
{
    /// <summary>
    /// Amazon AppStream 2. 0 Fleet ComputeCapacity
    /// The ComputeCapacity property type specifies the desired capacity for an Amazon AppStream 2. 0 fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-fleet-computecapacity.html
    /// </summary>
    public class ComputeCapacity
    {

        /// <summary>
        /// DesiredInstances
        /// The desired number of streaming instances.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DesiredInstances")]
        public Union<int, IntrinsicFunction> DesiredInstances { get; set; }

    }
}
