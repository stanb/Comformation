using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Authorizer
{
    /// <summary>
    /// AWS::IoT::Authorizer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html
    /// </summary>
    public class AuthorizerResource : ResourceBase
    {
        public class AuthorizerProperties
        {
            /// <summary>
            /// AuthorizerFunctionArn
            /// The authorizer&#39;s Lambda function ARN.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizerFunctionArn { get; set; }

            /// <summary>
            /// AuthorizerName
            /// The authorizer name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizerName { get; set; }

            /// <summary>
            /// SigningDisabled
            /// Specifies whether AWS IoT validates the token signature in an authorization request.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> SigningDisabled { get; set; }

            /// <summary>
            /// Status
            /// The status of the authorizer.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// TokenKeyName
            /// The key used to extract the token from the HTTP headers.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TokenKeyName { get; set; }

            /// <summary>
            /// TokenSigningPublicKeys
            /// The public keys used to validate the token signature returned by your custom authentication service.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> TokenSigningPublicKeys { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the custom authorizer.
            /// Note For URI Request parameters use format: . . . key1=value1&amp;amp;key2=value2. . . For the CLI
            /// command-line parameter use format: &amp;amp;&amp;amp;tags &quot;key1=value1&amp;amp;key2=value2. . . &quot; For the
            /// cli-input-json file use format: &quot;tags&quot;: &quot;key1=value1&amp;amp;key2=value2. . . &quot;
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::Authorizer";

        public AuthorizerProperties Properties { get; } = new AuthorizerProperties();

    }

    public static class AuthorizerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
