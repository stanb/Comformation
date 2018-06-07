using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DevEndpoint
{
    /// <summary>
    /// AWS::Glue::DevEndpoint
    /// The AWS::Glue::DevEndpoint resource specifies a development endpoint where a developer can remotely debug ETL
    /// scripts for AWS Glue. For more information, see DevEndpoint Structure in the AWS Glue Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html
    /// </summary>
    public class DevEndpointResource : ResourceBase
    {
        public class DevEndpointProperties
        {
            /// <summary>
            /// ExtraJarsS3Path
            /// The path to one or more Java Jars in an Amazon S3 bucket to load in your endpoint.
            /// 				
            /// Note You can currently use only pure Java/Scala libraries on a DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-extrajarss3path
            /// </summary>
			public Union<string, IntrinsicFunction> ExtraJarsS3Path { get; set; }

            /// <summary>
            /// EndpointName
            /// The name of the endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-endpointname
            /// </summary>
			public Union<string, IntrinsicFunction> EndpointName { get; set; }

            /// <summary>
            /// PublicKey
            /// The public key for the endpoint to use for authentication.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-publickey
            /// </summary>
			public Union<string, IntrinsicFunction> PublicKey { get; set; }

            /// <summary>
            /// NumberOfNodes
            /// The number of nodes that the endpoint uses.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-numberofnodes
            /// </summary>
			public Union<int, IntrinsicFunction> NumberOfNodes { get; set; }

            /// <summary>
            /// SubnetId
            /// The subnet ID for the endpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// ExtraPythonLibsS3Path
            /// The path to one or more Python libraries in an Amazon S3 bucket to load in your endpoint.
            /// 				
            /// Note You can currently use only pure Python libraries on a DevEndpoint. Libraries that rely on C
            /// extensions, such as the pandas Python data analysis library, aren't supported yet.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-extrapythonlibss3path
            /// </summary>
			public Union<string, IntrinsicFunction> ExtraPythonLibsS3Path { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of UTF-8 strings that specify the security group IDs for the endpoint.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-securitygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role for the endpoint. It must match the AWS ARN string
            /// pattern: arn:aws:iam::\d{12}:role/. *
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html#cfn-glue-devendpoint-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::DevEndpoint";
        
        public DevEndpointProperties Properties { get; } = new DevEndpointProperties();
    }
}
