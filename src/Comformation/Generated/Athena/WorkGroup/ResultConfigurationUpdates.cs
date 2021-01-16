using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.WorkGroup
{
    /// <summary>
    /// AWS::Athena::WorkGroup ResultConfigurationUpdates
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-resultconfigurationupdates.html
    /// </summary>
    public class ResultConfigurationUpdates
    {

        /// <summary>
        /// EncryptionConfiguration
        /// The encryption configuration for the query results.
        /// Required: No
        /// Type: EncryptionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// OutputLocation
        /// The location in Amazon S3 where your query results are stored, such as s3://path/to/query/bucket/.
        /// For more information, see Query Results If workgroup settings override client-side settings, then
        /// the query uses the location for the query results and the encryption configuration that are
        /// specified for the workgroup. The &quot;workgroup settings override&quot; is specified in
        /// EnforceWorkGroupConfiguration (true/false) in the WorkGroupConfiguration. See
        /// EnforceWorkGroupConfiguration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputLocation")]
        public Union<string, IntrinsicFunction> OutputLocation { get; set; }

        /// <summary>
        /// RemoveEncryptionConfiguration
        /// If set to &quot;true&quot;, indicates that the previously-specified encryption configuration (also known as
        /// the client-side setting) for queries in this workgroup should be ignored and set to null. If set to
        /// &quot;false&quot; or not set, and a value is present in the EncryptionConfiguration in
        /// ResultConfigurationUpdates (the client-side setting), the EncryptionConfiguration in the workgroup&#39;s
        /// ResultConfiguration will be updated with the new value. For more information, see Workgroup Settings
        /// Override Client-Side Settings.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveEncryptionConfiguration")]
        public Union<bool, IntrinsicFunction> RemoveEncryptionConfiguration { get; set; }

        /// <summary>
        /// RemoveOutputLocation
        /// If set to &quot;true&quot;, indicates that the previously-specified query results location (also known as a
        /// client-side setting) for queries in this workgroup should be ignored and set to null. If set to
        /// &quot;false&quot; or not set, and a value is present in the OutputLocation in ResultConfigurationUpdates (the
        /// client-side setting), the OutputLocation in the workgroup&#39;s ResultConfiguration will be updated with
        /// the new value. For more information, see Workgroup Settings Override Client-Side Settings.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RemoveOutputLocation")]
        public Union<bool, IntrinsicFunction> RemoveOutputLocation { get; set; }

    }
}
