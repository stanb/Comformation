using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project BatchRestrictions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html
    /// </summary>
    public class BatchRestrictions
    {

        /// <summary>
        /// ComputeTypesAllowed
        /// An array of strings that specify the compute types that are allowed for the batch build. See Build
        /// environment compute types in the AWS CodeBuild User Guide for these values.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeTypesAllowed")]
        public List<Union<string, IntrinsicFunction>> ComputeTypesAllowed { get; set; }

        /// <summary>
        /// MaximumBuildsAllowed
        /// Specifies the maximum number of builds allowed.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumBuildsAllowed")]
        public Union<int, IntrinsicFunction> MaximumBuildsAllowed { get; set; }

    }
}
