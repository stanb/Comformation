using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SQS.QueuePolicy
{
    /// <summary>
    /// AWS::SQS::QueuePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html
    /// </summary>
    public class QueuePolicyResource : ResourceBase
    {
        public class QueuePolicyProperties
        {
            /// <summary>
            /// PolicyDocument
            /// A policy document that contains the permissions for the specified Amazon SQS queues. For more
            /// information about Amazon SQS policies, see Using custom policies with the Amazon SQS access policy
            /// language in the Amazon SQS Developer Guide.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            /// Queues
            /// The URLs of the queues to which you want to add the policy. You can use the Ref function to specify
            /// an AWS::SQS::Queue resource.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Queues { get; set; }

        }

        public string Type { get; } = "AWS::SQS::QueuePolicy";

        public QueuePolicyProperties Properties { get; } = new QueuePolicyProperties();

    }
}
