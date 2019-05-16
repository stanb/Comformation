using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.RotationSchedule
{
    /// <summary>
    /// AWS::SecretsManager::RotationSchedule
    /// The AWS::SecretsManager::RotationSchedule resource configures rotation for a secret. The secret must already
    /// be configured with the details of the database or service. If you define both the secret and the database or
    /// service in an AWS CloudFormation template, then define the AWS::SecretsManager::SecretTargetAttachment
    /// resource to populate the secret with the connection details of the database or service before you attempt to
    /// configure rotation.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html
    /// </summary>
    public class RotationScheduleResource : ResourceBase
    {
        public class RotationScheduleProperties
        {
            /// <summary>
            /// SecretId
            /// Specifies the Amazon Resource Name (ARN) or the friendly name of the secret that you want to rotate.
            /// To reference a secret also that&#39;s created in this template, use the Ref function with the secret&#39;s
            /// logical ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SecretId { get; set; }

            /// <summary>
            /// RotationLambdaARN
            /// Specifies the ARN of the Lambda function that can rotate the secret. If you don&#39;t specify this
            /// parameter, then the secret must already have the ARN of a Lambda function configured. To reference a
            /// Lambda function that&#39;s also created in this template, use the Ref function with the function&#39;s
            /// logical ID.
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
