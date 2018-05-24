using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html
    /// </summary>
    public class Ingress
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-cidrip
        /// </summary>
        [JsonProperty("CidrIp")]
        public Union<string, IntrinsicFunction> CidrIp { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-cidripv6
        /// </summary>
        [JsonProperty("CidrIpv6")]
        public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-description
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-fromport
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int?, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-ipprotocol
        /// </summary>
        [JsonProperty("IpProtocol")]
        public Union<string, IntrinsicFunction> IpProtocol { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-sourcesecuritygroupid
        /// </summary>
        [JsonProperty("SourceSecurityGroupId")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-sourcesecuritygroupname
        /// </summary>
        [JsonProperty("SourceSecurityGroupName")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-sourcesecuritygroupownerid
        /// </summary>
        [JsonProperty("SourceSecurityGroupOwnerId")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupOwnerId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html#cfn-ec2-security-group-rule-toport
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int?, IntrinsicFunction> ToPort { get; set; }

    }
}
