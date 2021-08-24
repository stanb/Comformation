using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition NetworkConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// AssignPublicIp
        /// Indicates whether the job should have a public IP address. For a job that is running on Fargate
        /// resources in a private subnet to send outbound traffic to the internet (for example, to pull
        /// container images), the private subnet requires a NAT gateway be attached to route requests to the
        /// internet. For more information, see Amazon ECS task networking. The default value is &quot;DISABLED&quot;.
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssignPublicIp")]
        public Union<string, IntrinsicFunction> AssignPublicIp { get; set; }

    }
}
