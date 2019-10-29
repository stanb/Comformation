using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition Secret
    /// The Secret property specifies an object representing the secret to expose to your container. For more
    /// information, see Specifying Sensitive Data in the Amazon Elastic Container Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-secret.html
    /// </summary>
    public class Secret
    {

        /// <summary>
        /// Name
        /// The name of the secret.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ValueFrom
        /// The secret to expose to the container. The supported values are either the full ARN of the AWS
        /// Secrets Manager secret or the full ARN of the parameter in the AWS Systems Manager Parameter Store.
        /// Note If the AWS Systems Manager Parameter Store parameter exists in the same Region as the task you
        /// are launching, then you can use either the full ARN or name of the parameter. If the parameter
        /// exists in a different Region, then the full ARN must be specified.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ValueFrom")]
        public Union<string, IntrinsicFunction> ValueFrom { get; set; }

    }
}
