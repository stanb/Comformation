using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.ConnectorDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::ConnectorDefinitionVersion
    /// The AWS::Greengrass::ConnectorDefinitionVersion resource represents a connector definition version for AWS IoT
    /// Greengrass. A connector definition version contains a list of connectors.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinitionversion.html
    /// </summary>
    public class ConnectorDefinitionVersionResource : ResourceBase
    {
        public class ConnectorDefinitionVersionProperties
        {
            /// <summary>
            /// Connectors
            /// The connectors in this version. Only one instance of a given connector can be added to the connector
            /// definition version at a time.
            /// Required: Yes
            /// Type: List of Connector
            /// Update requires: Replacement
            /// </summary>
			public List<Connector> Connectors { get; set; }

            /// <summary>
            /// ConnectorDefinitionId
            /// The ID of the connector definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConnectorDefinitionId { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::ConnectorDefinitionVersion";

        public ConnectorDefinitionVersionProperties Properties { get; } = new ConnectorDefinitionVersionProperties();

    }
}
