using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.SimpleAD
{
    /// <summary>
    /// AWS Directory Service SimpleAD VpcSettings
    /// VpcSettings is a property of the AWS::DirectoryService::SimpleAD resource that specifies the VPC settings for
    /// a directory server.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-simplead-vpcsettings.html
    /// </summary>
    public class VpcSettings
    {

        /// <summary>
        /// SubnetIds
        /// A list of two subnet IDs for the directory servers. Each subnet must be in different Availability
        /// Zones (AZ). AWS Directory Service creates a directory server and a DNS server in each subnet.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// VpcId
        /// The VPC ID in which to create the Simple AD directory.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

    }
}
