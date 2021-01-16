using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.FlowOutput
{
    /// <summary>
    /// AWS::MediaConnect::FlowOutput VpcInterfaceAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowoutput-vpcinterfaceattachment.html
    /// </summary>
    public class VpcInterfaceAttachment
    {

        /// <summary>
        /// VpcInterfaceName
        /// The name of the VPC interface that you want to send your output to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcInterfaceName")]
        public Union<string, IntrinsicFunction> VpcInterfaceName { get; set; }

    }
}
