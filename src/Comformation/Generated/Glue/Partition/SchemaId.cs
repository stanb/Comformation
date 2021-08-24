using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    /// AWS::Glue::Partition SchemaId
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemaid.html
    /// </summary>
    public class SchemaId
    {

        /// <summary>
        /// RegistryName
        /// 	
        /// The name of the schema registry that contains the schema.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegistryName")]
        public Union<string, IntrinsicFunction> RegistryName { get; set; }

        /// <summary>
        /// SchemaName
        /// 	
        /// The name of the schema. One of SchemaArn or SchemaName has to be provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaName")]
        public Union<string, IntrinsicFunction> SchemaName { get; set; }

        /// <summary>
        /// SchemaArn
        /// 	
        /// The Amazon Resource Name (ARN) of the schema. One of SchemaArn or SchemaName has to be provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchemaArn")]
        public Union<string, IntrinsicFunction> SchemaArn { get; set; }

    }
}
