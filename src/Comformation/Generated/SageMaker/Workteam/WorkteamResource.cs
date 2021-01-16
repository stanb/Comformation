using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Workteam
{
    /// <summary>
    /// AWS::SageMaker::Workteam
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-workteam.html
    /// </summary>
    public class WorkteamResource : ResourceBase
    {
        public class WorkteamProperties
        {
            /// <summary>
            /// Description
            /// A description of the work team.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 200
            /// Pattern: . +
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// NotificationConfiguration
            /// Configures SNS notifications of available or expiring work items for work teams.
            /// Required: No
            /// Type: NotificationConfiguration
            /// Update requires: No interruption
            /// </summary>
            public NotificationConfiguration NotificationConfiguration { get; set; }

            /// <summary>
            /// WorkteamName
            /// The name of the work team.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkteamName { get; set; }

            /// <summary>
            /// MemberDefinitions
            /// A list of MemberDefinition objects that contains objects that identify the workers that make up the
            /// work team.
            /// Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private
            /// workforces created using Amazon Cognito use CognitoMemberDefinition. For workforces created using
            /// your own OIDC identity provider (IdP) use OidcMemberDefinition.
            /// Required: No
            /// Type: List of MemberDefinition
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public List<MemberDefinition> MemberDefinitions { get; set; }

            /// <summary>
            /// Tags
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::Workteam";

        public WorkteamProperties Properties { get; } = new WorkteamProperties();

    }

    public static class WorkteamAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> WorkteamName = new ResourceAttribute<Union<string, IntrinsicFunction>>("WorkteamName");
    }
}
