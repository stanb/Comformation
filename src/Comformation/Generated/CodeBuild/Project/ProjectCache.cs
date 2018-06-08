using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project ProjectCache
    /// The ProjectCache property type specifies settings that AWS CodeBuild uses to store and reuse build
    /// dependencies.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectcache.html
    /// </summary>
    public class ProjectCache
    {

        /// <summary>
        /// Type
        /// The type of cache for the build project to use. Valid values are:
        /// NO_CACHE: The build project doesn't use any cache. S3: The build project reads from and writes to
        /// Amazon S3.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Location
        /// The Amazon S3 bucket name and prefix—for example, mybucket/prefix. This value is ignored when Type
        /// is set to NO_CACHE.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

    }
}
