using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.ElasticLoadBalancerAttachment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html
    /// </summary>
    public class ElasticLoadBalancerAttachmentResource : ResourceBase
    {
        public class ElasticLoadBalancerAttachmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html#cfn-opsworks-elbattachment-elbname
            /// </summary>
			public Union<string, IntrinsicFunction> ElasticLoadBalancerName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-elbattachment.html#cfn-opsworks-elbattachment-layerid
            /// </summary>
			public Union<string, IntrinsicFunction> LayerId { get; set; }

        }
    
        public string Type { get; } = "AWS::OpsWorks::ElasticLoadBalancerAttachment";
        
        public ElasticLoadBalancerAttachmentProperties Properties { get; } = new ElasticLoadBalancerAttachmentProperties();
    }
}
