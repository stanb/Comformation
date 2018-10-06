using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.MicrosoftAD
{
    /// <summary>
    /// AWS Directory Service MicrosoftAD VpcSettings
    /// VpcSettings is a property of the AWS::DirectoryService::MicrosoftAD resource that specifies the VPC settings
    /// for a Microsoft directory server.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-microsoftad-vpcsettings.html
    /// </summary>
    public class VpcSettings
    {

        /// <summary>
        /// SubnetIds
        /// A list of two subnet IDs for the directory servers. Each subnet must be in different Availability
        /// Zones (AZs). AWS Directory Service creates a directory server and a DNS server in each subnet.
        /// Required: Yes
        /// Type: List of String values
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// VpcId
        /// The VPC ID in which to create the Microsoft Active Directory server.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

    }
}
