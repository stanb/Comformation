using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.CodeSigningConfig
{
    /// <summary>
    /// AWS::Lambda::CodeSigningConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html
    /// </summary>
    public class CodeSigningConfigResource : ResourceBase
    {
        public class CodeSigningConfigProperties
        {
            /// <summary>
            /// Description
            /// Code signing configuration description.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AllowedPublishers
            /// List of allowed publishers.
            /// Required: Yes
            /// Type: AllowedPublishers
            /// Update requires: No interruption
            /// </summary>
            public AllowedPublishers AllowedPublishers { get; set; }

            /// <summary>
            /// CodeSigningPolicies
            /// The code signing policy controls the validation failure action for signature mismatch or expiry.
            /// Required: No
            /// Type: CodeSigningPolicies
            /// Update requires: No interruption
            /// </summary>
            public CodeSigningPolicies CodeSigningPolicies { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::CodeSigningConfig";

        public CodeSigningConfigProperties Properties { get; } = new CodeSigningConfigProperties();

    }

    public static class CodeSigningConfigAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CodeSigningConfigId = new ResourceAttribute<Union<string, IntrinsicFunction>>("CodeSigningConfigId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CodeSigningConfigArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("CodeSigningConfigArn");
    }
}
