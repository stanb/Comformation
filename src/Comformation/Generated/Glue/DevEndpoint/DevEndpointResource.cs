using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DevEndpoint
{
    /// <summary>
    /// AWS::Glue::DevEndpoint
    /// The AWS::Glue::DevEndpoint resource specifies a development endpoint where a developer can remotely debug ETL
    /// scripts for AWS Glue. For more information, see DevEndpoint Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html
    /// </summary>
    public class DevEndpointResource : ResourceBase
    {
        public class DevEndpointProperties
        {
            /// <summary>
            /// ExtraJarsS3Path
            /// The path to one or more Java . jar files in an S3 bucket that should be loaded in your DevEndpoint.
            /// Note You can only use pure Java/Scala libraries with a DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExtraJarsS3Path { get; set; }

            /// <summary>
            /// EndpointName
            /// The name of the DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointName { get; set; }

            /// <summary>
            /// PublicKey
            /// The public key to be used by this DevEndpoint for authentication. This attribute is provided for
            /// backward compatibility because the recommended attribute to use is public keys.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PublicKey { get; set; }

            /// <summary>
            /// NumberOfNodes
            /// The number of AWS Glue Data Processing Units (DPUs) allocated to this DevEndpoint.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> NumberOfNodes { get; set; }

            /// <summary>
            /// SubnetId
            /// The subnet ID for this DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// ExtraPythonLibsS3Path
            /// The paths to one or more Python libraries in an Amazon S3 bucket that should be loaded in your
            /// DevEndpoint. Multiple values must be complete paths separated by a comma.
            /// Note You can only use pure Python libraries with a DevEndpoint. Libraries that rely on C extensions,
            /// such as the pandas Python data analysis library, are not currently supported.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExtraPythonLibsS3Path { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of security group identifiers used in this DevEndpoint.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role used in this DevEndpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::Glue::DevEndpoint";

        public DevEndpointProperties Properties { get; } = new DevEndpointProperties();

    }
}
