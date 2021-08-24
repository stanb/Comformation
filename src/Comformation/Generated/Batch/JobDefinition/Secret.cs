using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition Secret
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-secret.html
    /// </summary>
    public class Secret
    {

        /// <summary>
        /// ValueFrom
        /// The secret to expose to the container. The supported values are either the full ARN of the AWS
        /// Secrets Manager secret or the full ARN of the parameter in the AWS Systems Manager Parameter Store.
        /// Note If the AWS Systems Manager Parameter Store parameter exists in the same Region as the job
        /// you&#39;re launching, then you can use either the full ARN or name of the parameter. If the parameter
        /// exists in a different Region, then the full ARN must be specified.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ValueFrom")]
        public Union<string, IntrinsicFunction> ValueFrom { get; set; }

        /// <summary>
        /// Name
        /// The name of the secret.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
