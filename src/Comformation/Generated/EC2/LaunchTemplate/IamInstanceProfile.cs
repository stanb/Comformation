using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate IamInstanceProfile
    /// Specifies an IAM instance profile. You must provide either the name or the ARN of the instance profile.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-iaminstanceprofile.html
    /// </summary>
    public class IamInstanceProfile
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the instance profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// Name
        /// The name of the instance profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
