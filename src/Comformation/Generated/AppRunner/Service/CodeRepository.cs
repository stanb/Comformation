using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service CodeRepository
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-coderepository.html
    /// </summary>
    public class CodeRepository
    {

        /// <summary>
        /// RepositoryUrl
        /// The location of the repository that contains the source code.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 51200
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepositoryUrl")]
        public Union<string, IntrinsicFunction> RepositoryUrl { get; set; }

        /// <summary>
        /// SourceCodeVersion
        /// The version that should be used within the source code repository.
        /// Required: Yes
        /// Type: SourceCodeVersion
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceCodeVersion")]
        public SourceCodeVersion SourceCodeVersion { get; set; }

        /// <summary>
        /// CodeConfiguration
        /// Configuration for building and running the service from a source code repository.
        /// Required: No
        /// Type: CodeConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeConfiguration")]
        public CodeConfiguration CodeConfiguration { get; set; }

    }
}
