using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Connection
{
    /// <summary>
    /// AWS::Events::Connection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-connection.html
    /// </summary>
    public class ConnectionResource : ResourceBase
    {
        public class ConnectionProperties
        {
            /// <summary>
            /// Name
            /// The name for the connection to create.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\. \-_A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// A description for the connection to create.
            /// Required: No
            /// Type: String
            /// Maximum: 512
            /// Pattern: . *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AuthorizationType
            /// The type of authorization to use for the connection.
            /// Required: Yes
            /// Type: String
            /// Allowed values: API_KEY | BASIC | OAUTH_CLIENT_CREDENTIALS
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizationType { get; set; }

            /// <summary>
            /// AuthParameters
            /// A CreateConnectionAuthRequestParameters object that contains the authorization parameters to use to
            /// authorize with the endpoint.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AuthParameters { get; set; }

        }

        public string Type { get; } = "AWS::Events::Connection";

        public ConnectionProperties Properties { get; } = new ConnectionProperties();

    }

    public static class ConnectionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SecretArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SecretArn");
    }
}
