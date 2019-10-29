using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.DedicatedIpPool
{
    /// <summary>
    /// AWS::PinpointEmail::DedicatedIpPool
    /// A request to create a new dedicated IP pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-dedicatedippool.html
    /// </summary>
    public class DedicatedIpPoolResource : ResourceBase
    {
        public class DedicatedIpPoolProperties
        {
            /// <summary>
            /// PoolName
            /// The name of the dedicated IP pool.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PoolName { get; set; }

            /// <summary>
            /// Tags
            /// An object that defines the tags (keys and values) that you want to associate with the dedicated IP
            /// pool.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
			public List<Tags> Tags { get; set; }

        }

        public string Type { get; } = "AWS::PinpointEmail::DedicatedIpPool";

        public DedicatedIpPoolProperties Properties { get; } = new DedicatedIpPoolProperties();

    }
}
