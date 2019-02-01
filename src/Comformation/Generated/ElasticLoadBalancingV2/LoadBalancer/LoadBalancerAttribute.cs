using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing V2 LoadBalancerAttributes
    /// LoadBalancerAttributes is a property of the AWS::ElasticLoadBalancingV2::LoadBalancer resource that configures
    /// settings for an Application Load Balancer or a Network Load Balancer. For more information, see Load Balancer
    /// Attributes in the User Guide for Application Load Balancers or Load Balancer Attributes in the User Guide for
    /// Network Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-loadbalancerattributes.html
    /// </summary>
    public class LoadBalancerAttribute
    {

        /// <summary>
        /// Key
        /// The name of an attribute that you want to configure. For the list of attributes that you can
        /// configure, see the Key contents for the LoadBalancerAttribute data type in the Elastic Load
        /// Balancing API Reference version 2015-12-01.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// A value for the attribute.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
