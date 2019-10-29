using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Workteam
{
    /// <summary>
    /// AWS::SageMaker::Workteam
    /// Creates a new work team for labeling your data. A work team is defined by one or more Amazon Cognito user
    /// pools. You must first create the user pools before you can create a work team.
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
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> WorkteamName { get; set; }

            /// <summary>
            /// MemberDefinitions
            /// The Amazon Cognito user groups that make up the work team.
            /// Required: No
            /// Type: List of MemberDefinition
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
			public List<MemberDefinition> MemberDefinitions { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs to apply to this resource.
            /// For more information, see Resource Tag and Using Cost Allocation Tags in the AWS Billing and Cost
            /// Management User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
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
