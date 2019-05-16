using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SQS.QueuePolicy
{
    /// <summary>
    /// AWS::SQS::QueuePolicy
    /// The AWS::SQS::QueuePolicy type applies a policy to Amazon SQS queues. For an example snippet, see Declaring an
    /// Amazon SQS Policy in the AWS CloudFormation User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html
    /// </summary>
    public class QueuePolicyResource : ResourceBase
    {
        public class QueuePolicyProperties
        {
            /// <summary>
            /// PolicyDocument
            /// A policy document that contains the permissions for the specified Amazon SQS queues. For more
            /// information about Amazon SQS policies, see Creating Custom Policies Using the Access Policy Language
            /// in the Amazon Simple Queue Service Developer Guide.
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
