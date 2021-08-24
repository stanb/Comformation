using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html
    /// </summary>
    public class ConnectorProfileResource : ResourceBase
    {
        public class ConnectorProfileProperties
        {
            /// <summary>
            /// ConnectorProfileName
            /// The name of the connector profile. The name is unique for each ConnectorProfile in the AWS account.
            /// Required: Yes
            /// Type: String
            /// Maximum: 256
            /// Pattern: [\w/!@#+=. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectorProfileName { get; set; }

            /// <summary>
            /// KMSArn
            /// The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide for encryption.
            /// This is required if you do not want to use the Amazon AppFlow-managed KMS key. If you don&#39;t provide
            /// anything here, Amazon AppFlow uses the Amazon AppFlow-managed KMS key.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: arn:aws:kms:. *:[0-9]+:. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KMSArn { get; set; }

            /// <summary>
            /// ConnectorType
            /// The type of connector, such as Salesforce, Amplitude, and so on.
            /// Required: Yes
            /// Type: String
            /// Allowed values: Amplitude | CustomerProfiles | Datadog | Dynatrace | EventBridge | Googleanalytics |
            /// Honeycode | Infornexus | LookoutMetrics | Marketo | Redshift | S3 | Salesforce | Servicenow |
            /// Singular | Slack | Snowflake | Trendmicro | Upsolver | Veeva | Zendesk
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectorType { get; set; }

            /// <summary>
            /// ConnectionMode
            /// Indicates the connection mode and if it is public or private.
            /// Required: Yes
            /// Type: String
            /// Allowed values: Private | Public
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionMode { get; set; }

            /// <summary>
            /// ConnectorProfileConfig
            /// Defines the connector-specific configuration and credentials.
            /// Required: No
            /// Type: ConnectorProfileConfig
            /// Update requires: No interruption
            /// </summary>
            public ConnectorProfileConfig ConnectorProfileConfig { get; set; }

        }

        public string Type { get; } = "AWS::AppFlow::ConnectorProfile";

        public ConnectorProfileProperties Properties { get; } = new ConnectorProfileProperties();

    }

    public static class ConnectorProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConnectorProfileArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConnectorProfileArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CredentialsArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CredentialsArn");
    }
}
