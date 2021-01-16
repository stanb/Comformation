using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.Resolver
{
    /// <summary>
    /// AWS::AppSync::Resolver SyncConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html
    /// </summary>
    public class SyncConfig
    {

        /// <summary>
        /// ConflictHandler
        /// The Conflict Resolution strategy to perform in the event of a conflict.
        /// OPTIMISTIC_CONCURRENCY: Resolve conflicts by rejecting mutations when versions do not match the
        /// latest version at the server. AUTOMERGE: Resolve conflicts with the Automerge conflict resolution
        /// strategy. LAMBDA: Resolve conflicts with a Lambda function supplied in the
        /// LambdaConflictHandlerConfig.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConflictHandler")]
        public Union<string, IntrinsicFunction> ConflictHandler { get; set; }

        /// <summary>
        /// ConflictDetection
        /// The Conflict Detection strategy to use.
        /// VERSION: Detect conflicts based on object versions for this resolver. NONE: Do not detect conflicts
        /// when executing this resolver.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConflictDetection")]
        public Union<string, IntrinsicFunction> ConflictDetection { get; set; }

        /// <summary>
        /// LambdaConflictHandlerConfig
        /// The LambdaConflictHandlerConfig when configuring LAMBDA as the Conflict Handler.
        /// Required: No
        /// Type: LambdaConflictHandlerConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaConflictHandlerConfig")]
        public LambdaConflictHandlerConfig LambdaConflictHandlerConfig { get; set; }

    }
}
