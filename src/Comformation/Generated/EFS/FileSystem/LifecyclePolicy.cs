using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.FileSystem
{
    /// <summary>
    /// AWS::EFS::FileSystem LifecyclePolicy
    /// Describes a policy used by EFS lifecycle management to transition files to the Infrequent Access (IA) storage
    /// class.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticfilesystem-filesystem-lifecyclepolicy.html
    /// </summary>
    public class LifecyclePolicy
    {

        /// <summary>
        /// TransitionToIA
        /// A value that describes the period of time that a file is not accessed, after which it transitions to
        /// the IA storage class. Metadata operations such as listing the contents of a directory don&#39;t count as
        /// file access events.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: AFTER_14_DAYS | AFTER_30_DAYS | AFTER_60_DAYS | AFTER_90_DAYS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitionToIA")]
        public Union<string, IntrinsicFunction> TransitionToIA { get; set; }

    }
}
