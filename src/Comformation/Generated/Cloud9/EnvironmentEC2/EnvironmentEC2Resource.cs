using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cloud9.EnvironmentEC2
{
    /// <summary>
    /// AWS::Cloud9::EnvironmentEC2
    /// The AWS::Cloud9::EnvironmentEC2 resource creates an Amazon EC2 development environment in AWS Cloud9. For more
    /// information, see Creating an Environment in the AWS Cloud9 User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html
    /// </summary>
    public class EnvironmentEC2Resource : ResourceBase
    {
        public class EnvironmentEC2Properties
        {
            /// <summary>
            /// Repositories
            /// Any AWS CodeCommit source code repositories to be cloned into the development environment.
            /// Required: No
            /// Type: List of Repository
            /// Update requires: Replacement
            /// </summary>
			public List<Repository> Repositories { get; set; }

            /// <summary>
            /// OwnerArn
            /// The Amazon Resource Name (ARN) of the environment owner. This ARN can be the ARN of any AWS Identity
            /// and Access Management (IAM) principal. If this value is not specified, the ARN defaults to this
            /// environment&#39;s creator.
            /// Required: No
            /// Type: String
            /// Pattern: arn:aws:(iam|sts)::\d+:(root|user|federated-user|assumed-role)\/?\S*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> OwnerArn { get; set; }

            /// <summary>
            /// Description
            /// The description of the environment to create.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AutomaticStopTimeMinutes
            /// The number of minutes until the running instance is shut down after the environment was last used.
            /// Required: No
            /// Type: Integer
            /// Maximum: 20160
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> AutomaticStopTimeMinutes { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet in Amazon Virtual Private Cloud (Amazon VPC) that AWS Cloud9 will use to
            /// communicate with the Amazon Elastic Compute Cloud (Amazon EC2) instance.
            /// Required: No
            /// Type: String
            /// Minimum: 5
            /// Maximum: 30
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// InstanceType
            /// The type of instance to connect to the environment (for example, t2. micro).
            /// Required: Yes
            /// Type: String
            /// Minimum: 5
            /// Maximum: 20
            /// Pattern: ^[a-z][1-9][. ][a-z0-9]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Name
            /// The name of the environment.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Cloud9::EnvironmentEC2";

        public EnvironmentEC2Properties Properties { get; } = new EnvironmentEC2Properties();

    }

	public static class EnvironmentEC2Attributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
