using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.ParameterGroup
{
    /// <summary>
    /// AWS::DAX::ParameterGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-parametergroup.html
    /// </summary>
    public class ParameterGroupResource : ResourceBase
    {
        public class ParameterGroupProperties
        {
            /// <summary>
            /// ParameterNameValues
            /// An array of name-value pairs for the parameters in the group. Each element in the array represents a
            /// single parameter.
            /// Note record-ttl-millis and query-ttl-millis are the only supported parameter names. For more
            /// details, see Configuring TTL Settings.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ParameterNameValues { get; set; }

            /// <summary>
            /// Description
            /// A description of the parameter group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ParameterGroupName
            /// The name of the parameter group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ParameterGroupName { get; set; }

        }

        public string Type { get; } = "AWS::DAX::ParameterGroup";

        public ParameterGroupProperties Properties { get; } = new ParameterGroupProperties();

    }
}
