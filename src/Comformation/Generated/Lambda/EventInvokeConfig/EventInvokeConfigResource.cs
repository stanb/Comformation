using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventInvokeConfig
{
    /// <summary>
    /// AWS::Lambda::EventInvokeConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventinvokeconfig.html
    /// </summary>
    public class EventInvokeConfigResource : ResourceBase
    {
        public class EventInvokeConfigProperties
        {
            /// <summary>
            /// FunctionName
            /// The name of the Lambda function.
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ([a-zA-Z0-9-_]+)
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// MaximumRetryAttempts
            /// The maximum number of times to retry when the function returns an error.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Maximum: 2
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumRetryAttempts { get; set; }

            /// <summary>
            /// DestinationConfig
            /// A destination for events after they have been sent to a function for processing.
            /// Destinations Function - The Amazon Resource Name (ARN) of a Lambda function. Queue - The ARN of an
            /// SQS queue. Topic - The ARN of an SNS topic. Event Bus - The ARN of an Amazon EventBridge event bus.
            /// Required: No
            /// Type: DestinationConfig
            /// Update requires: No interruption
            /// </summary>
            public DestinationConfig DestinationConfig { get; set; }

            /// <summary>
            /// Qualifier
            /// The identifier of a version or alias.
            /// Version - A version number. Alias - An alias name. Latest - To specify the unpublished version, use
            /// $LATEST.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: (|[a-zA-Z0-9$_-]+)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Qualifier { get; set; }

            /// <summary>
            /// MaximumEventAgeInSeconds
            /// The maximum age of a request that Lambda sends to a function for processing.
            /// Required: No
            /// Type: Integer
            /// Minimum: 60
            /// Maximum: 21600
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaximumEventAgeInSeconds { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::EventInvokeConfig";

        public EventInvokeConfigProperties Properties { get; } = new EventInvokeConfigProperties();

    }
}
