using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTThingsGraph.FlowTemplate
{
    /// <summary>
    /// AWS::IoTThingsGraph::FlowTemplate DefinitionDocument
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotthingsgraph-flowtemplate-definitiondocument.html
    /// </summary>
    public class DefinitionDocument
    {

        /// <summary>
        /// Language
        /// The language used to define the entity. GRAPHQL is the only valid value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Language")]
        public Union<string, IntrinsicFunction> Language { get; set; }

        /// <summary>
        /// Text
        /// The GraphQL text that defines the entity.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Text")]
        public Union<string, IntrinsicFunction> Text { get; set; }

    }
}
