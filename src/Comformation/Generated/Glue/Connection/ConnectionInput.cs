using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Connection
{
    /// <summary>
    /// AWS::Glue::Connection ConnectionInput
    /// A structure that is used to specify a connection to create or update.
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
        /// The type of the connection. Currently, only JDBC is supported; SFTP is not supported.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionType")]
        public Union<string, IntrinsicFunction> ConnectionType { get; set; }

        /// <summary>
        /// MatchCriteria
        /// A list of criteria that can be used in selecting this connection.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MatchCriteria")]
        public List<Union<string, IntrinsicFunction>> MatchCriteria { get; set; }

        /// <summary>
        /// PhysicalConnectionRequirements
        /// A map of physical connection requirements, such as virtual private cloud (VPC) and SecurityGroup,
        /// that are needed to successfully make this connection.
        /// Required: No
        /// Type: PhysicalConnectionRequirements
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PhysicalConnectionRequirements")]
        public PhysicalConnectionRequirements PhysicalConnectionRequirements { get; set; }

        /// <summary>
        /// ConnectionProperties
        /// These key-value pairs define parameters for the connection.
        /// Required: Yes
        /// Type: Json
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
