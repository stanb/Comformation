using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service AuthenticationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-authenticationconfiguration.html
    /// </summary>
    public class AuthenticationConfiguration
    {

        /// <summary>
        /// ConnectionArn
        /// The Amazon Resource Name (ARN) of the App Runner connection that enables the App Runner service to
        /// connect to a source repository. It&#39;s required for GitHub code repositories.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1011
        /// Pattern: arn:aws(-[\w]+)*:[a-z0-9-\\. ]{0,63}:[a-z0-9-\\. ]{0,63}:[0-9]{12}:(\w|\/|-){1,1011}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionArn")]
        public Union<string, IntrinsicFunction> ConnectionArn { get; set; }

        /// <summary>
        /// AccessRoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that grants the App Runner service access to a source
        /// repository. It&#39;s required for ECR image repositories (but not for ECR Public repositories).
        /// Required: No
        /// Type: String
        /// Minimum: 29
        /// Maximum: 1024
        /// Pattern:
        /// arn:(aws|aws-us-gov|aws-cn|aws-iso|aws-iso-b):iam::[0-9]{12}:(role|role\/service-role)\/[\w+=,.
        /// @\-/]{1,1000}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessRoleArn")]
        public Union<string, IntrinsicFunction> AccessRoleArn { get; set; }

    }
}
