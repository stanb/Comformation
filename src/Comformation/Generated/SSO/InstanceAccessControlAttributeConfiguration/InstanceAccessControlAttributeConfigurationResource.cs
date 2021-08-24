using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSO.InstanceAccessControlAttributeConfiguration
{
    /// <summary>
    /// AWS::SSO::InstanceAccessControlAttributeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-instanceaccesscontrolattributeconfiguration.html
    /// </summary>
    public class InstanceAccessControlAttributeConfigurationResource : ResourceBase
    {
        public class InstanceAccessControlAttributeConfigurationProperties
        {
            /// <summary>
            /// InstanceArn
            /// The ARN of the AWS SSO instance under which the operation will be executed.
            /// Required: Yes
            /// Type: String
            /// Minimum: 10
            /// Maximum: 1224
            /// Pattern: arn:aws:sso:::instance/(sso)?ins-[a-zA-Z0-9-. ]{16}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceArn { get; set; }

            /// <summary>
            /// AccessControlAttributes
            /// Lists the attributes that are configured for ABAC in the specified AWS SSO instance.
            /// Required: No
            /// Type: List of AccessControlAttribute
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<AccessControlAttribute> AccessControlAttributes { get; set; }

        }

        public string Type { get; } = "AWS::SSO::InstanceAccessControlAttributeConfiguration";

        public InstanceAccessControlAttributeConfigurationProperties Properties { get; } = new InstanceAccessControlAttributeConfigurationProperties();

    }
}
