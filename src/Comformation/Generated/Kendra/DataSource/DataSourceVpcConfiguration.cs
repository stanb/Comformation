using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DataSourceVpcConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-datasourcevpcconfiguration.html
    /// </summary>
    public class DataSourceVpcConfiguration
    {

        /// <summary>
        /// SubnetIds
        /// A list of identifiers for subnets within your Amazon VPC. The subnets should be able to connect to
        /// each other in the VPC, and they should have outgoing access to the Internet through a NAT device.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 6
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// A list of identifiers of security groups within your Amazon VPC. The security groups should enable
        /// Amazon Kendra to connect to the data source.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

    }
}
