using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.WorkGroup
{
    /// <summary>
    /// AWS::Athena::WorkGroup ResultConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-resultconfiguration.html
    /// </summary>
    public class ResultConfiguration
    {

        /// <summary>
        /// EncryptionConfiguration
        /// If query results are encrypted in Amazon S3, indicates the encryption option used (for example,
        /// SSE-KMS or CSE-KMS) and key information. This is a client-side setting. If workgroup settings
        /// override client-side settings, then the query uses the encryption configuration that is specified
        /// for the workgroup, and also uses the location for storing query results specified in the workgroup.
        /// See EnforceWorkGroupConfiguration and Workgroup Settings Override Client-Side Settings.
        /// Required: No
        /// Type: EncryptionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// OutputLocation
        /// The location in Amazon S3 where your query results are stored, such as s3://path/to/query/bucket/.
        /// To run a query, you must specify the query results location using either a client-side setting for
        /// individual queries or a location specified by the workgroup. If workgroup settings override
        /// client-side settings, then the query uses the location specified for the workgroup. If no query
        /// location is set, Athena issues an error. For more information, see Working with Query Results,
        /// Output Files, and Query History and EnforceWorkGroupConfiguration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputLocation")]
        public Union<string, IntrinsicFunction> OutputLocation { get; set; }

    }
}
