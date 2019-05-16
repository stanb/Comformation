using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    /// AWS::Glue::Database DatabaseInput
    /// The structure used to create or update a database.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-databaseinput.html
    /// </summary>
    public class DatabaseInput
    {

        /// <summary>
        /// LocationUri
        /// The location of the database (for example, an HDFS path).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LocationUri")]
        public Union<string, IntrinsicFunction> LocationUri { get; set; }

        /// <summary>
        /// Description
        /// A description of the database.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Parameters
        /// These key-value pairs define parameters and properties of the database.
        /// These key-value pairs define parameters and properties of the database.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Parameters { get; set; }

        /// <summary>
        /// Name
        /// The name of the database. For Hive compatibility, this is folded to lowercase when it is stored.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
