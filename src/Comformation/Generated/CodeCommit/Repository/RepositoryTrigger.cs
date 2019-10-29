using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// AWS::CodeCommit::Repository RepositoryTrigger
    /// Information about a trigger for a repository.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html
    /// </summary>
    public class RepositoryTrigger
    {

        /// <summary>
        /// Events
        /// The repository events that will cause the trigger to run actions in another service, such as sending
        /// a notification through Amazon SNS.
        /// Note The valid value &quot;all&quot; cannot be used with any other values.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Events")]
        public List<Union<string, IntrinsicFunction>> Events { get; set; }

        /// <summary>
        /// Branches
        /// The branches that will be included in the trigger configuration. If you specify an empty array, the
        /// trigger will apply to all branches.
        /// Note Although no content is required in the array, you must include the array itself.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Branches")]
        public List<Union<string, IntrinsicFunction>> Branches { get; set; }

        /// <summary>
        /// CustomData
        /// Any custom data associated with the trigger that will be included in the information sent to the
        /// target of the trigger.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomData")]
        public Union<string, IntrinsicFunction> CustomData { get; set; }

        /// <summary>
        /// DestinationArn
        /// The ARN of the resource that is the target for a trigger. For example, the ARN of a topic in Amazon
        /// SNS.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

        /// <summary>
        /// Name
        /// The name of the trigger.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
