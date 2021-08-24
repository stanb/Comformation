using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.StudioSessionMapping
{
    /// <summary>
    /// AWS::EMR::StudioSessionMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-studiosessionmapping.html
    /// </summary>
    public class StudioSessionMappingResource : ResourceBase
    {
        public class StudioSessionMappingProperties
        {
            /// <summary>
            /// IdentityName
            /// The name of the user or group. For more information, see UserName and DisplayName in the AWS SSO
            /// Identity Store API Reference.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IdentityName { get; set; }

            /// <summary>
            /// IdentityType
            /// Specifies whether the identity to map to the Amazon EMR Studio is a user or a group.
            /// Required: Yes
            /// Type: String
            /// Allowed values: GROUP | USER
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IdentityType { get; set; }

            /// <summary>
            /// SessionPolicyArn
            /// The Amazon Resource Name (ARN) for the session policy that will be applied to the user or group.
            /// Session policies refine Studio user permissions without the need to use multiple IAM user roles. For
            /// more information, see Create an EMR Studio user role with session policies in the Amazon EMR
            /// Management Guide.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SessionPolicyArn { get; set; }

            /// <summary>
            /// StudioId
            /// The ID of the Amazon EMR Studio to which the user or group will be mapped.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StudioId { get; set; }

        }

        public string Type { get; } = "AWS::EMR::StudioSessionMapping";

        public StudioSessionMappingProperties Properties { get; } = new StudioSessionMappingProperties();

    }
}
