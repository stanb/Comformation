using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBSecurityGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html
    /// </summary>
    public class Ingress
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-cidrip
        /// </summary>
        [JsonProperty("CIDRIP")]
        public Union<string, IntrinsicFunction> CIDRIP { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-ec2securitygroupid
        /// </summary>
        [JsonProperty("EC2SecurityGroupId")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-ec2securitygroupname
        /// </summary>
        [JsonProperty("EC2SecurityGroupName")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-ec2securitygroupownerid
        /// </summary>
        [JsonProperty("EC2SecurityGroupOwnerId")]
        public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

    }
}
