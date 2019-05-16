using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ConnectorDefinition
{
    /// <summary>
    /// AWS::Greengrass::ConnectorDefinition ConnectorDefinitionVersion
    /// A connector definition version contains a list of connectors.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connectordefinitionversion.html
    /// </summary>
    public class ConnectorDefinitionVersion
    {

        /// <summary>
        /// Connectors
        /// The connectors in this version. Only one instance of a given connector can be added to a connector
        /// definition version at a time.
        /// Required: Yes
        /// Type: List of Connector
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Connectors")]
        public List<Connector> Connectors { get; set; }

    }
}
