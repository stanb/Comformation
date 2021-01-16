using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.RotationSchedule
{
    /// <summary>
    /// AWS::SecretsManager::RotationSchedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html
    /// </summary>
    public class RotationScheduleResource : ResourceBase
    {
        public class RotationScheduleProperties
        {
            /// <summary>
            /// SecretId
            /// Specifies the ARN or the friendly name of the secret that you want to rotate. To reference a secret
            /// also created in this template, use the Ref function with the secret&#39;s logical ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// HostedRotationLambda
            /// To use these values, you must specify Transform: AWS::SecretsManager-2020-07-23 at the beginning of
            /// the CloudFormation template.
            /// When you enter valid values for RotationSchedule. HostedRotationLambda, Secrets Manager launches a
            /// Lambda that performs rotation on the secret specified in the secret-id property. The template
            /// creates a Lambda as part of a nested stack within the current stack.
            /// Required: No
            /// Type: HostedRotationLambda
            /// Update requires: No interruption
            /// </summary>
            public HostedRotationLambda HostedRotationLambda { get; set; }

            /// <summary>
            /// RotationLambdaARN
            /// Specifies the ARN of the Lambda function that can rotate the secret. If you don&#39;t specify this
            /// parameter, then the secret must already have the ARN of a Lambda function configured. To reference a
            /// Lambda function also created in this template, use the Ref function with the function&#39;s logical ID.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RotationLambdaARN { get; set; }

            /// <summary>
            /// RotationRules
            /// Specifies a structure that defines the rotation schedule for this secret.
            /// Required: No
            /// Type: RotationRules
            /// Update requires: No interruption
            /// </summary>
            public RotationRules RotationRules { get; set; }

        }

        public string Type { get; } = "AWS::SecretsManager::RotationSchedule";

        public RotationScheduleProperties Properties { get; } = new RotationScheduleProperties();

    }
}
