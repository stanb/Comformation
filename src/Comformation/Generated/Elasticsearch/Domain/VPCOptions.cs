using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain VPCOptions
    /// The virtual private cloud (VPC) configuration for the Amazon ES domain. For more information, see VPC Support
    /// for Amazon Elasticsearch Service Domains in the Amazon Elasticsearch Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-vpcoptions.html
    /// </summary>
    public class VPCOptions
    {

        /// <summary>
        /// SecurityGroupIds
        /// The list of security group IDs that are associated with the VPC endpoints for the domain. If you
        /// don&#39;t provide a security group ID, Amazon ES uses the default security group for the VPC. To learn
        /// more, see Security Groups for your VPC in the Amazon VPC User Guide.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// Provide one subnet ID for each Availability Zone that your domain uses. For example, you must
        /// specify three subnet IDs for a three Availability Zone domain. To learn more, see VPCs and Subnets
        /// in the Amazon VPC User Guide.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
