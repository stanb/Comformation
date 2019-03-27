using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeCommit.Repository
{
    /// <summary>
    /// CodeCommit Repository Trigger
    /// Trigger is a property of the AWS::CodeCommit::Repository resource that defines the actions to take in response
    /// to events that occur in the CodeCommit repository.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-triggers.html
    /// </summary>
    public class RepositoryTrigger
    {

        /// <summary>
        /// Events
        /// The repository events for which CodeCommit sends information to the target, which you specified in
        /// the DestinationArn property. If you don&#39;t specify events, the trigger runs for all repository
        /// events. For valid values, see the RepositoryTrigger data type in the AWS CodeCommit API Reference.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Events")]
        public List<Union<string, IntrinsicFunction>> Events { get; set; }

        /// <summary>
        /// Branches
        /// The names of the branches in the CodeCommit repository that contain events that you want to include
        /// in the trigger. If you don&#39;t specify at least one branch, the trigger applies to all branches.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Branches")]
        public List<Union<string, IntrinsicFunction>> Branches { get; set; }

        /// <summary>
        /// CustomData
        /// When an event is triggered, additional information that CodeCommit includes when it sends
        /// information to the target.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CustomData")]
        public Union<string, IntrinsicFunction> CustomData { get; set; }

        /// <summary>
        /// DestinationArn
        /// The Amazon Resource Name (ARN) of the resource that is the target for this trigger. For valid
        /// targets, see Manage Triggers for an CodeCommit Repository in the AWS CodeCommit User Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

        /// <summary>
        /// Name
        /// A name for the trigger.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
