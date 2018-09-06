using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// Amazon Elasticsearch Service Domain VPCOptions
    /// The VPCOptions property type specifies a virtual private cloud (VPC) configuration for an Amazon Elasticsearch
    /// Service (Amazon ES) domain.
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
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// A list of subnet IDs that are associated with the VPC endpoints for the domain. If your domain has
        /// zone awareness enabled, you need to provide two subnet IDs, one per zone. Otherwise, provide only
        /// one. To learn more, see VPCs and Subnets in the Amazon VPC User Guide.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public Union<List<string>, IntrinsicFunction> SubnetIds { get; set; }

    }
}
