using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource DocumentsMetadataConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-documentsmetadataconfiguration.html
    /// </summary>
    public class DocumentsMetadataConfiguration
    {

        /// <summary>
        /// S3Prefix
        /// A prefix used to filter metadata configuration files in the AWS S3 bucket. The S3 bucket might
        /// contain multiple metadata files. Use S3Prefix to include only the desired metadata files.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Prefix")]
        public Union<string, IntrinsicFunction> S3Prefix { get; set; }

    }
}
