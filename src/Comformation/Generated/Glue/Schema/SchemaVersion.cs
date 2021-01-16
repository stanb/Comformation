using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Schema
{
    /// <summary>
    /// AWS::Glue::Schema SchemaVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schema-schemaversion.html
    /// </summary>
    public class SchemaVersion
    {

        /// <summary>
        /// IsLatest
        /// 	
        /// Indicates if this version is the latest version of the schema.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsLatest")]
        public Union<bool, IntrinsicFunction> IsLatest { get; set; }

        /// <summary>
        /// VersionNumber
        /// 	
        /// The version number of the schema.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VersionNumber")]
        public Union<int, IntrinsicFunction> VersionNumber { get; set; }

    }
}
