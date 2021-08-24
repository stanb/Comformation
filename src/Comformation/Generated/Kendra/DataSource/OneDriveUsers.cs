using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource OneDriveUsers
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-onedriveusers.html
    /// </summary>
    public class OneDriveUsers
    {

        /// <summary>
        /// OneDriveUserList
        /// A list of users whose documents should be indexed. Specify the user names in email format, for
        /// example, username@tenantdomain. If you need to index the documents of more than 100 users, use the
        /// OneDriveUserS3Path field to specify the location of a file containing a list of users.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OneDriveUserList")]
        public List<Union<string, IntrinsicFunction>> OneDriveUserList { get; set; }

        /// <summary>
        /// OneDriveUserS3Path
        /// The S3 bucket location of a file containing a list of users whose documents should be indexed.
        /// Required: No
        /// Type: S3Path
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OneDriveUserS3Path")]
        public S3Path OneDriveUserS3Path { get; set; }

    }
}
