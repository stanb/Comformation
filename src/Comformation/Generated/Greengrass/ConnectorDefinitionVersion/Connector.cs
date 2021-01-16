using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ConnectorDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ConnectorDefinitionVersion Connector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinitionversion-connector.html
    /// </summary>
    public class Connector
    {

        /// <summary>
        /// ConnectorArn
        /// The Amazon Resource Name (ARN) of the connector.
        /// For more information about AWS-provided connectors, see AWS-Provided Greengrass Connectors.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConnectorArn")]
        public Union<string, IntrinsicFunction> ConnectorArn { get; set; }

        /// <summary>
        /// Parameters
        /// The parameters or configuration that the connector uses.
        /// 				 				
        /// For more information about AWS-provided connectors, see AWS-Provided Greengrass Connectors.
        /// Required: No
        /// Type: Json
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the connector. This value must be unique within the connector
        /// definition version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}
