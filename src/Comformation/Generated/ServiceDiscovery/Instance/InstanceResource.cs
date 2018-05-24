using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Instance
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html
    /// </summary>
    public class InstanceResource : ResourceBase
    {
        public class InstanceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceattributes
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> InstanceAttributes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-serviceid
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceId { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceDiscovery::Instance";
        
        public InstanceProperties Properties { get; } = new InstanceProperties();
    }
}
