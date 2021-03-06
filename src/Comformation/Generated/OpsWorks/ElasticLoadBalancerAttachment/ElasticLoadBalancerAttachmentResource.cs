using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.ElasticLoadBalancerAttachment
{
    /// <summary>
    /// AWS::OpsWorks::ElasticLoadBalancerAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html
    /// </summary>
    public class ElasticLoadBalancerAttachmentResource : ResourceBase
    {
        public class ElasticLoadBalancerAttachmentProperties
        {
            /// <summary>
            /// ElasticLoadBalancerName
            /// The Elastic Load Balancing instance&#39;s name.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ElasticLoadBalancerName { get; set; }

            /// <summary>
            /// LayerId
            /// The AWS OpsWorks layer ID that the Elastic Load Balancing load balancer will be attached to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LayerId { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorks::ElasticLoadBalancerAttachment";

        public ElasticLoadBalancerAttachmentProperties Properties { get; } = new ElasticLoadBalancerAttachmentProperties();

    }
}
