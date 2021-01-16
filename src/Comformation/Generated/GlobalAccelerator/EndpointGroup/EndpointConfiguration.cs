using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GlobalAccelerator.EndpointGroup
{
    /// <summary>
    /// AWS::GlobalAccelerator::EndpointGroup EndpointConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-endpointconfiguration.html
    /// </summary>
    public class EndpointConfiguration
    {

        /// <summary>
        /// EndpointId
        /// 		
        /// An ID for the endpoint. If the endpoint is a Network Load Balancer or Application Load Balancer,
        /// this is the Amazon 			Resource Name (ARN) of the resource. If the endpoint is an Elastic IP address,
        /// this is the Elastic IP address 			allocation ID. For Amazon EC2 instances, this is the EC2 instance
        /// ID. A resource must be valid and active 			when you add it as an endpoint.
        /// 		
        /// An Application Load Balancer can be either internal or internet-facing.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointId")]
        public Union<string, IntrinsicFunction> EndpointId { get; set; }

        /// <summary>
        /// Weight
        /// 		
        /// The weight associated with the endpoint. When you add weights to endpoints, you configure AWS Global
        /// Accelerator to route traffic 			based on proportions that you specify. For example, you might
        /// specify endpoint weights of 4, 5, 5, and 6 (sum=20). The 			result is that 4/20 of your traffic, on
        /// average, is routed to the first endpoint, 5/20 is routed both to the second 			and third endpoints,
        /// and 6/20 is routed to the last endpoint. For more information, see Endpoint Weights in the 				AWS
        /// Global Accelerator Developer Guide.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Weight")]
        public Union<int, IntrinsicFunction> Weight { get; set; }

        /// <summary>
        /// ClientIPPreservationEnabled
        /// 		
        /// Indicates whether client IP address preservation is enabled for an Application Load Balancer
        /// endpoint. 			The value is true or false. The default value is true for new accelerators.
        /// 		
        /// If the value is set to true, the client&#39;s IP address is preserved in the X-Forwarded-For request
        /// header as 			traffic travels to applications on the Application Load Balancer endpoint fronted by
        /// the accelerator.
        /// 		
        /// For more information, see 			Preserve Client IP Addresses in AWS Global Accelerator in the AWS
        /// Global Accelerator Developer Guide.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientIPPreservationEnabled")]
        public Union<bool, IntrinsicFunction> ClientIPPreservationEnabled { get; set; }

    }
}
