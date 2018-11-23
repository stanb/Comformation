using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// Elastic Load Balancing Listener Certificate
    /// The Certificate property type specifies the default SSL server certificate that Elastic Load Balancing will
    /// deploy on an listener. For more information, see Create an HTTPS Listener for Your Application Load Balancer
    /// in the User Guide for Application Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-certificates.html
    /// </summary>
    public class Certificate
    {

        /// <summary>
        /// CertificateArn
        /// The Amazon Resource Name (ARN) of the certificate to associate with the listener.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CertificateArn")]
        public Union<string, IntrinsicFunction> CertificateArn { get; set; }

    }
}
