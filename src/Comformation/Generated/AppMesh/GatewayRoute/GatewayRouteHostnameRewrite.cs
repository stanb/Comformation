using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteHostnameRewrite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutehostnamerewrite.html
    /// </summary>
    public class GatewayRouteHostnameRewrite
    {

        /// <summary>
        /// DefaultTargetHostname
        /// The default target host name to write to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultTargetHostname")]
        public Union<string, IntrinsicFunction> DefaultTargetHostname { get; set; }

    }
}
