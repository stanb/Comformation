using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DirectoryService.MicrosoftAD
{
    /// <summary>
    /// AWS::DirectoryService::MicrosoftAD VpcSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-microsoftad-vpcsettings.html
    /// </summary>
    public class VpcSettings
    {

        /// <summary>
        /// SubnetIds
        /// The identifiers of the subnets for the directory servers. The two subnets must be in different
        /// Availability Zones. AWS Directory Service specifies a directory server and a DNS server in each of
        /// these subnets.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// VpcId
        /// The identifier of the VPC in which to create the directory.
        /// Required: Yes
        /// Type: String
        /// Pattern: ^(vpc-[0-9a-f]{8}|vpc-[0-9a-f]{17})$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

    }
}
