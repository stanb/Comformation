using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FinSpace.Environment
{
    /// <summary>
    /// AWS::FinSpace::Environment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html
    /// </summary>
    public class EnvironmentResource : ResourceBase
    {
        public class EnvironmentProperties
        {
            /// <summary>
            /// Name
            /// The name of the FinSpace environment.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: ^[a-zA-Z0-9]+[a-zA-Z0-9-]*[a-zA-Z0-9]$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the FinSpace environment.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1000
            /// Pattern: ^[a-zA-Z0-9. ]{1,1000}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The KMS key id used to encrypt in the FinSpace environment.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1000
            /// Pattern: ^[a-zA-Z-0-9-:\/]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// FederationMode
            /// The authentication mode for the environment.
            /// Required: No
            /// Type: String
            /// Allowed values: FEDERATED | LOCAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FederationMode { get; set; }

            /// <summary>
            /// FederationParameters
            /// Configuration information when authentication mode is FEDERATED.
            /// Required: No
            /// Type: FederationParameters
            /// Update requires: No interruption
            /// </summary>
            public FederationParameters FederationParameters { get; set; }

        }

        public string Type { get; } = "AWS::FinSpace::Environment";

        public EnvironmentProperties Properties { get; } = new EnvironmentProperties();

    }

    public static class EnvironmentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EnvironmentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("EnvironmentId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AwsAccountId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AwsAccountId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EnvironmentUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("EnvironmentUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EnvironmentArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("EnvironmentArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SageMakerStudioDomainUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("SageMakerStudioDomainUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DedicatedServiceAccountId = new ResourceAttribute<Union<string, IntrinsicFunction>>("DedicatedServiceAccountId");
    }
}
