using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint ConnectionLogOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html
    /// </summary>
    public class ConnectionLogOptions
    {

        /// <summary>
        /// CloudwatchLogStream
        /// 		
        /// The name of the CloudWatch Logs log stream to which the connection data is published.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudwatchLogStream")]
        public Union<string, IntrinsicFunction> CloudwatchLogStream { get; set; }

        /// <summary>
        /// Enabled
        /// 		
        /// Indicates whether connection logging is enabled.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// CloudwatchLogGroup
        /// 		
        /// The name of the CloudWatch Logs log group. Required if connection logging is enabled.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudwatchLogGroup")]
        public Union<string, IntrinsicFunction> CloudwatchLogGroup { get; set; }

    }
}
