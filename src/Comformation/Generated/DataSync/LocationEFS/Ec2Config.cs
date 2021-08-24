using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationEFS
{
    /// <summary>
    /// AWS::DataSync::LocationEFS Ec2Config
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationefs-ec2config.html
    /// </summary>
    public class Ec2Config
    {

        /// <summary>
        /// SecurityGroupArns
        /// The Amazon Resource Names (ARNs) of the security groups that are configured for the Amazon EC2
        /// resource.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroupArns")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupArns { get; set; }

        /// <summary>
        /// SubnetArn
        /// The ARN of the subnet that DataSync uses to access the target EFS file system.
        /// Required: Yes
        /// Type: String
        /// Maximum: 128
        /// Pattern: ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):ec2:[a-z\-0-9]*:[0-9]{12}:subnet/. *$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubnetArn")]
        public Union<string, IntrinsicFunction> SubnetArn { get; set; }

    }
}
