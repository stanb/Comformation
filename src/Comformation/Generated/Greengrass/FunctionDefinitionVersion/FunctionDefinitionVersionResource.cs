using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.FunctionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::FunctionDefinitionVersion
    /// The AWS::Greengrass::FunctionDefinitionVersion resource represents a function definition version for AWS IoT
    /// Greengrass. A function definition version contains contain a list of functions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-functiondefinitionversion.html
    /// </summary>
    public class FunctionDefinitionVersionResource : ResourceBase
    {
        public class FunctionDefinitionVersionProperties
        {
            /// <summary>
            /// DefaultConfig
            /// The default configuration that applies to all Lambda functions in the group. Individual Lambda
            /// functions can override these settings.
            /// Required: No
            /// Type: DefaultConfig
            /// Update requires: Replacement
            /// </summary>
			public DefaultConfig DefaultConfig { get; set; }

            /// <summary>
            /// Functions
            /// The functions in this version.
            /// Required: Yes
            /// Type: List of Function property types
            /// Update requires: Replacement
            /// </summary>
			public List<Function> Functions { get; set; }

            /// <summary>
            /// FunctionDefinitionId
            /// The ID of the function definition associated with this version. This value is a GUID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionDefinitionId { get; set; }

        }

        public string Type { get; } = "AWS::Greengrass::FunctionDefinitionVersion";

        public FunctionDefinitionVersionProperties Properties { get; } = new FunctionDefinitionVersionProperties();

    }
}
