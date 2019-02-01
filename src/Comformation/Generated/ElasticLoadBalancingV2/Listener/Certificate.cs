using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// Elastic Load Balancing V2 Certificate
    /// The Certificate property type specifies the default server certificate that Elastic Load Balancing deploys on
    /// an HTTPS or TLS listener. For more information, see Create an HTTPS Listener for Your Application Load
    /// Balancer in the User Guide for Application Load Balancers or Create a TLS Listener for Your Network Load
    /// Balancer in the User Guide for Network Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-certificates.html
    /// </summary>
    public class Certificate
    {

        /// <summary>
        /// CertificateArn
        /// The Amazon Resource Name (ARN) of the certificate.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
