using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.FeatureGroup
{
    /// <summary>
    /// AWS::SageMaker::FeatureGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-featuregroup.html
    /// </summary>
    public class FeatureGroupResource : ResourceBase
    {
        public class FeatureGroupProperties
        {
            /// <summary>
            /// FeatureGroupName
            /// The name of the FeatureGroup.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,63}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FeatureGroupName { get; set; }

            /// <summary>
            /// RecordIdentifierFeatureName
            /// The name of the Feature whose value uniquely identifies a Record defined in the FeatureGroup
            /// FeatureDefinitions.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ^[a-zA-Z0-9]([-_]*[a-zA-Z0-9]){0,63}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RecordIdentifierFeatureName { get; set; }

            /// <summary>
            /// EventTimeFeatureName
            /// The name of the feature that stores the EventTime of a Record in a FeatureGroup.
            /// A EventTime is point in time when a new event occurs that corresponds to the creation or update of a
            /// Record in FeatureGroup. All Records in the FeatureGroup must have a corresponding EventTime.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: ^[a-zA-Z0-9]([-_]*[a-zA-Z0-9]){0,63}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventTimeFeatureName { get; set; }

            /// <summary>
            /// FeatureDefinitions
            /// A list of Features. Each Feature must include a FeatureName and a FeatureType.
            /// Valid FeatureTypes are Integral, Fractional and String.
            /// FeatureNames cannot be any of the following: is_deleted, write_time, api_invocation_time.
            /// You can create up to 2,500 FeatureDefinitions per FeatureGroup.
            /// Required: Yes
            /// Type: List of FeatureDefinition
            /// Maximum: 2500
            /// Update requires: Replacement
            /// </summary>
            public List<FeatureDefinition> FeatureDefinitions { get; set; }

            /// <summary>
            /// OnlineStoreConfig
            /// The configuration of an OnlineStore.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> OnlineStoreConfig { get; set; }

            /// <summary>
            /// OfflineStoreConfig
            /// 	
            /// The configuration of an OfflineStore.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> OfflineStoreConfig { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM execution role used to create the feature group.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Description
            /// A free form description of a FeatureGroup.
            /// Required: No
            /// Type: String
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// Tags used to define a FeatureGroup.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::FeatureGroup";

        public FeatureGroupProperties Properties { get; } = new FeatureGroupProperties();

    }
}
