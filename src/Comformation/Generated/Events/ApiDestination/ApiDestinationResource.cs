using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.ApiDestination
{
    /// <summary>
    /// AWS::Events::ApiDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-apidestination.html
    /// </summary>
    public class ApiDestinationResource : ResourceBase
    {
        public class ApiDestinationProperties
        {
            /// <summary>
            /// Name
            /// The name for the API destination to create.
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
            /// A description for the API destination to create.
            /// Required: No
            /// Type: String
            /// Maximum: 512
            /// Pattern: . *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ConnectionArn
            /// The ARN of the connection to use for the API destination. The destination endpoint must support the
            /// authorization type specified for the connection.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: ^arn:aws([a-z]|\-)*:events:([a-z]|\d|\-)*:([0-9]{12})?:connection\/[\.
            /// \-_A-Za-z0-9]+\/[\-A-Za-z0-9]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionArn { get; set; }

            /// <summary>
            /// InvocationRateLimitPerSecond
            /// The maximum number of requests per second to send to the HTTP invocation endpoint.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> InvocationRateLimitPerSecond { get; set; }

            /// <summary>
            /// InvocationEndpoint
            /// The URL to the HTTP invocation endpoint for the API destination.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: ^((%[0-9A-Fa-f]{2}|[-()_. !~*&#39;;/?:@\x26=+$,A-Za-z0-9])+)([). !&#39;;/?:,])?$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InvocationEndpoint { get; set; }

            /// <summary>
            /// HttpMethod
            /// The method to use for the request to the HTTP invocation endpoint.
            /// Required: Yes
            /// Type: String
            /// Allowed values: DELETE | GET | HEAD | OPTIONS | PATCH | POST | PUT
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HttpMethod { get; set; }

        }

        public string Type { get; } = "AWS::Events::ApiDestination";

        public ApiDestinationProperties Properties { get; } = new ApiDestinationProperties();

    }

    public static class ApiDestinationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
