using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SQS.QueuePolicy
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html
    /// </summary>
    public class QueuePolicyResource : ResourceBase
    {
        public class QueuePolicyProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html#cfn-sqs-queuepolicy-policydoc
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html#cfn-sqs-queuepolicy-queues
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Queues { get; set; }

        }
    
        public string Type { get; } = "AWS::SQS::QueuePolicy";
        
        public QueuePolicyProperties Properties { get; } = new QueuePolicyProperties();
    }
}
