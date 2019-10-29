using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroup
{
    /// <summary>
    /// AWS::RDS::DBSecurityGroup Ingress
    /// The Ingress property type specifies an individual ingress rule within an AWS::RDS::DBSecurityGroup resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html
    /// </summary>
    public class Ingress
    {

        /// <summary>
        /// CIDRIP
        /// The IP range to authorize.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CIDRIP")]
        public Union<string, IntrinsicFunction> CIDRIP { get; set; }

        /// <summary>
        /// EC2SecurityGroupId
        /// Id of the EC2 security group to authorize. For VPC DB security groups, EC2SecurityGroupId must be
        /// provided. Otherwise, EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId
        /// must be provided.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EC2SecurityGroupId")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupId { get; set; }

        /// <summary>
        /// EC2SecurityGroupName
        /// Name of the EC2 security group to authorize. For VPC DB security groups, EC2SecurityGroupId must be
        /// provided. Otherwise, EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId
        /// must be provided.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EC2SecurityGroupName")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

        /// <summary>
        /// EC2SecurityGroupOwnerId
        /// AWS account number of the owner of the EC2 security group specified in the EC2SecurityGroupName
        /// parameter. The AWS access key ID isn&#39;t an acceptable value. For VPC DB security groups,
        /// EC2SecurityGroupId must be provided. Otherwise, EC2SecurityGroupOwnerId and either
        /// EC2SecurityGroupName or EC2SecurityGroupId must be provided.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EC2SecurityGroupOwnerId")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

    }
}
