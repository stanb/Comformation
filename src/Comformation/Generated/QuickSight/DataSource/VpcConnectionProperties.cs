using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource VpcConnectionProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-vpcconnectionproperties.html
    /// </summary>
    public class VpcConnectionProperties
    {

        /// <summary>
        /// VpcConnectionArn
        /// The Amazon Resource Name (ARN) for the VPC connection.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcConnectionArn")]
        public Union<string, IntrinsicFunction> VpcConnectionArn { get; set; }

    }
}
