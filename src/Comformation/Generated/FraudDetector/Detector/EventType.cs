using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FraudDetector.Detector
{
    /// <summary>
    /// AWS::FraudDetector::Detector EventType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-frauddetector-detector-eventtype.html
    /// </summary>
    public class EventType
    {

        /// <summary>
        /// Name
        /// The event type name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Inline
        /// Indicates whether the resource is defined within this CloudFormation template and impacts the
        /// create, update, and delete behavior of the stack. If the value is true, CloudFormation will
        /// create/update/delete the resource when creating/updating/deleting the stack. If the value is false,
        /// CloudFormation will validate that the object exists and then use it within the resource without
        /// making changes to the object.
        /// For example, when creating AWS::FraudDetector::Detector you must define at least two variables. You
        /// can set Inline=true for these variables and CloudFormation will create/update/delete the Variables
        /// as part of stack operations. However, if you set Inline=false, CloudFormation will associate the
        /// variables to your detector but not execute any changes to the variables.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Inline")]
        public Union<bool, IntrinsicFunction> Inline { get; set; }

        /// <summary>
        /// Tags
        /// An array of key-value pairs to apply to this resource.
        /// For more information, see Tag.
        /// Required: No
        /// Type: List of Tag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Description
        /// The event type description.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// EventVariables
        /// The event type event variables.
        /// Required: No
        /// Type: List of EventVariable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventVariables")]
        public List<EventVariable> EventVariables { get; set; }

        /// <summary>
        /// Labels
        /// The event type labels.
        /// Required: No
        /// Type: List of Label
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Labels")]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// EntityTypes
        /// The event type entity types.
        /// Required: No
        /// Type: List of EntityType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntityTypes")]
        public List<EntityType> EntityTypes { get; set; }

        /// <summary>
        /// Arn
        /// The entity type ARN.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^arn\:aws[a-z-]{0,15}\:frauddetector\:[a-z0-9-]{3,20}\:[0-9]{12}\:[^\s]{2,128}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// CreatedTime
        /// Timestamp of when the event type was created.
        /// Required: No
        /// Type: String
        /// Minimum: 11
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreatedTime")]
        public Union<string, IntrinsicFunction> CreatedTime { get; set; }

        /// <summary>
        /// LastUpdatedTime
        /// Timestamp of when the event type was last updated.
        /// Required: No
        /// Type: String
        /// Minimum: 11
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LastUpdatedTime")]
        public Union<string, IntrinsicFunction> LastUpdatedTime { get; set; }

    }
}
