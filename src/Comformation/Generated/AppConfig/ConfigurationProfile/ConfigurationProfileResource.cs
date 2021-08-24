using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.ConfigurationProfile
{
    /// <summary>
    /// AWS::AppConfig::ConfigurationProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-configurationprofile.html
    /// </summary>
    public class ConfigurationProfileResource : ResourceBase
    {
        public class ConfigurationProfileProperties
        {
            /// <summary>
            /// LocationUri
            /// A URI to locate the configuration. You can specify the AWS AppConfig hosted configuration store,
            /// Systems Manager (SSM) document, an SSM Parameter Store parameter, or an Amazon S3 object. For the
            /// hosted configuration store, specify hosted. For an SSM document, specify either the document name in
            /// the format ssm-document://&amp;lt;Document_name&amp;gt; or the Amazon Resource Name (ARN). For a parameter,
            /// specify either the parameter name in the format ssm-parameter://&amp;lt;Parameter_name&amp;gt; or the ARN.
            /// For an Amazon S3 object, specify the URI in the following format:
            /// s3://&amp;lt;bucket&amp;gt;/&amp;lt;objectKey&amp;gt; . Here is an example:
            /// s3://my-bucket/my-app/us-east-1/my-config. json
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LocationUri { get; set; }

            /// <summary>
            /// Description
            /// A description of the configuration profile.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Validators
            /// A list of methods for validating the configuration.
            /// Required: No
            /// Type: List of Validators
            /// Maximum: 2
            /// Update requires: No interruption
            /// </summary>
            public List<Validators> Validators { get; set; }

            /// <summary>
            /// RetrievalRoleArn
            /// The ARN of an IAM role with permission to access the configuration at the specified LocationUri.
            /// Important A retrieval role ARN is not required for configurations stored in the AWS AppConfig hosted
            /// configuration store. It is required for all other sources that store your configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: ^((arn):(aws|aws-cn|aws-iso|aws-iso-[a-z]{1}|aws-us-gov):(iam)::\d{12}:role[/]. *)$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RetrievalRoleArn { get; set; }

            /// <summary>
            /// ApplicationId
            /// The application ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// Tags
            /// Metadata to assign to the configuration profile. Tags help organize and categorize your AWS
            /// AppConfig resources. Each tag consists of a key and an optional value, both of which you define.
            /// Required: No
            /// Type: List of Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tags> Tags { get; set; }

            /// <summary>
            /// Name
            /// A name for the configuration profile.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::AppConfig::ConfigurationProfile";

        public ConfigurationProfileProperties Properties { get; } = new ConfigurationProfileProperties();

    }
}
