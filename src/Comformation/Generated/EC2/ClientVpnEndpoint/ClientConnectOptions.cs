using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint ClientConnectOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientconnectoptions.html
    /// </summary>
    public class ClientConnectOptions
    {

        /// <summary>
        /// LambdaFunctionArn
        /// The Amazon Resource Name (ARN) of the AWS Lambda function used for connection authorization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionArn")]
        public Union<string, IntrinsicFunction> LambdaFunctionArn { get; set; }

        /// <summary>
        /// Enabled
        /// Indicates whether client connect options are enabled. The default is false (not enabled).
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
