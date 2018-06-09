using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet IamInstanceProfile
    /// IamInstanceProfile is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications property
    /// that specifies the IAM instance profile to associate with the instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-iaminstanceprofile.html
    /// </summary>
    public class IamInstanceProfileSpecification
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the instance profile to associate with the instances. The instance
        /// profile contains the IAM role that is associated with the instances.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
