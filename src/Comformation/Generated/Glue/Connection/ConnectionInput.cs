using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Connection
{
    /// <summary>
    /// AWS Glue Connection ConnectionInput
    /// The ConnectionInput property type specifies the AWS Glue connection to create.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html
    /// </summary>
    public class ConnectionInput
    {

        /// <summary>
        /// Description
        /// The description of the connection.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// ConnectionType
        /// The type of the connection. Valid values are JDBC or SFTP.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionType")]
        public Union<string, IntrinsicFunction> ConnectionType { get; set; }

        /// <summary>
        /// MatchCriteria
        /// A list of UTF-8 strings that specify the criteria that you can use in selecting this connection.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchCriteria")]
        public List<Union<string, IntrinsicFunction>> MatchCriteria { get; set; }

        /// <summary>
        /// PhysicalConnectionRequirements
        /// A map of physical connection requirements that are needed to make the connection, such as VPC and
        /// SecurityGroup.
        /// Required: Yes
        /// Type: PhysicalConnectionRequirements
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PhysicalConnectionRequirements")]
        public PhysicalConnectionRequirements PhysicalConnectionRequirements { get; set; }

        /// <summary>
        /// ConnectionProperties
        /// UTF-8 string–to–UTF-8 string key-value pairs that specify the parameters for this connection.
        /// Required: Yes
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionProperties")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ConnectionProperties { get; set; }

        /// <summary>
        /// Name
        /// The name of the connection.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
