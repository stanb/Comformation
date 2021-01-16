using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SchemaVersion
{
    /// <summary>
    /// AWS::Glue::SchemaVersion Schema
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schemaversion-schema.html
    /// </summary>
    public class Schema
    {

        /// <summary>
        /// SchemaArn
        /// 	
        /// The Amazon Resource Name (ARN) of the schema. Either SchemaArn, or SchemaName and RegistryName has
        /// to be provided.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SchemaArn")]
        public Union<string, IntrinsicFunction> SchemaArn { get; set; }

        /// <summary>
        /// SchemaName
        /// 	
        /// The name of the schema. Either SchemaArn, or SchemaName and RegistryName has to be provided.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SchemaName")]
        public Union<string, IntrinsicFunction> SchemaName { get; set; }

        /// <summary>
        /// RegistryName
        /// 	
        /// The name of the registry where the schema is stored. Either SchemaArn, or SchemaName and
        /// RegistryName has to be provided.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RegistryName")]
        public Union<string, IntrinsicFunction> RegistryName { get; set; }

    }
}
