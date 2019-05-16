using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationRecorder
{
    /// <summary>
    /// AWS::Config::ConfigurationRecorder
    /// The AWS::Config::ConfigurationRecorder resource describes the AWS resource types for which AWS Config records
    /// configuration changes. The configuration recorder stores the configurations of the supported resources in your
    /// account as configuration items.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationrecorder.html
    /// </summary>
    public class ConfigurationRecorderResource : ResourceBase
    {
        public class ConfigurationRecorderProperties
        {
            /// <summary>
            /// Name
            /// A name for the configuration recorder. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique physical ID and uses that ID for the configuration recorder name. For more information, see
            /// Name Type.
            /// Note After you create a configuration recorder, you cannot rename it. If you don&#39;t want a name that
            /// AWS CloudFormation generates, specify a value for this property.
            /// Updates are not supported.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RecordingGroup
            /// Indicates whether to record configurations for all supported resources or for a list of resource
            /// types. The resource types that you list must be supported by AWS Config.
            /// 	
            /// Required: No
            /// Type: RecordingGroup
            /// Update requires: No interruption
            /// </summary>
			public RecordingGroup RecordingGroup { get; set; }

            /// <summary>
            /// RoleARN
            /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that is used to
            /// make read or write requests to the delivery channel that you specify and to get configuration
            /// details for supported AWS resources. For more information, see Permissions for the IAM Role Assigned
            /// to AWS Config in the AWS Config Developer Guide.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleARN { get; set; }

        }

        public string Type { get; } = "AWS::Config::ConfigurationRecorder";

        public ConfigurationRecorderProperties Properties { get; } = new ConfigurationRecorderProperties();

    }
}
