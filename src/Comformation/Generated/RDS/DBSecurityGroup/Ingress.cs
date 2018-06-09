using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroup
{
    /// <summary>
    /// Amazon RDS Security Group Rule
    /// The Amazon RDS security group rule is an embedded property of the AWS::RDS::DBSecurityGroup type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html
    /// </summary>
    public class Ingress
    {

        /// <summary>
        /// CIDRIP
        /// The IP range to authorize.
        /// For an overview of CIDR ranges, go to the Wikipedia Tutorial.
        /// Type: String
        /// Required: No
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CIDRIP")]
        public Union<string, IntrinsicFunction> CIDRIP { get; set; }

        /// <summary>
        /// EC2SecurityGroupId
        /// Id of the VPC or EC2 Security Group to authorize.
        /// For VPC DB Security Groups, use EC2SecurityGroupId. For EC2 Security Groups, use
        /// EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId.
        /// Type: String
        /// Required: No
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EC2SecurityGroupId")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupId { get; set; }

        /// <summary>
        /// EC2SecurityGroupName
        /// Name of the EC2 Security Group to authorize.
        /// For VPC DB Security Groups, use EC2SecurityGroupId. For EC2 Security Groups, use
        /// EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId.
        /// Type: String
        /// Required: No
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EC2SecurityGroupName")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

        /// <summary>
        /// EC2SecurityGroupOwnerId
        /// AWS Account Number of the owner of the EC2 Security Group specified in the EC2SecurityGroupName
        /// parameter. The AWS Access Key ID is not an acceptable value.
        /// For VPC DB Security Groups, use EC2SecurityGroupId. For EC2 Security Groups, use
        /// EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId.
        /// Type: String
        /// Required: No
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EC2SecurityGroupOwnerId")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

    }
}
