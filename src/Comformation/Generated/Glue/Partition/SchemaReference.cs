using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition SchemaReference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemareference.html
    /// </summary>
    public class SchemaReference
    {

        /// <summary>
        /// SchemaVersionId
        /// 	
        /// The unique ID assigned to a version of the schema. Either this or the SchemaId has to be provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaVersionId")]
        public Union<string, IntrinsicFunction> SchemaVersionId { get; set; }

        /// <summary>
        /// SchemaId
        /// 	
        /// A structure that contains schema identity fields. Either this or the SchemaVersionId has to be
        /// provided.
        /// Required: No
        /// Type: SchemaId
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaId")]
        public SchemaId SchemaId { get; set; }

        /// <summary>
        /// SchemaVersionNumber
        /// 	
        /// The version number of the schema.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaVersionNumber")]
        public Union<int, IntrinsicFunction> SchemaVersionNumber { get; set; }

    }
}
