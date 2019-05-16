using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.ImageBuilder
{
    /// <summary>
    /// AWS::AppStream::ImageBuilder VpcConfig
    /// The VPC configuration for the image builder.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// The identifiers of the security groups for the image builder.
        /// Required: No
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// The identifier of the subnet to which a network interface is attached from the image builder
        /// instance. An image builder instance can use one subnet.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
