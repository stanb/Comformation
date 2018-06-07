using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cloud9.EnvironmentEC2
{
    /// <summary>
    /// AWS::Cloud9::EnvironmentEC2
    /// The AWS::Cloud9::EnvironmentEC2 resource creates an Amazon EC2 development environment in AWS Cloud9. For more
    /// information, see Creating an Environment in the AWS Cloud9 User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html
    /// </summary>
    public class EnvironmentEC2Resource : ResourceBase
    {
        public class EnvironmentEC2Properties
        {
            /// <summary>
            /// Repositories
            /// Any AWS CodeCommit source code repositories to be cloned into the development environment.
            /// Required: No
            /// Type: List of AWS Cloud9 EnvironmentEC2 Repository
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-repositories
            /// </summary>
			public Union<List<Repository>, IntrinsicFunction> Repositories { get; set; }

            /// <summary>
            /// OwnerArn
            /// The Amazon Resource Name (ARN) of the environment owner. If this value is not specified, the ARN
            /// defaults to this environment's creator.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-ownerarn
            /// </summary>
			public Union<string, IntrinsicFunction> OwnerArn { get; set; }

            /// <summary>
            /// Description
            /// The description of the environment to create.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AutomaticStopTimeMinutes
            /// The number of minutes until the running instance is shut down after the environment has last been
            /// used.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-automaticstoptimeminutes
            /// </summary>
			public Union<int, IntrinsicFunction> AutomaticStopTimeMinutes { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet in Amazon Virtual Private Cloud (Amazon VPC) to use.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// InstanceType
            /// The type of instance to host the environment on (for example, t2. micro).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-instancetype
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Name
            /// The name of the environment to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloud9-environmentec2.html#cfn-cloud9-environmentec2-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::Cloud9::EnvironmentEC2";
        
        public EnvironmentEC2Properties Properties { get; } = new EnvironmentEC2Properties();
    }

	public static class EnvironmentEC2Attributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
