using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    /// AWS::KinesisAnalytics::ApplicationReferenceDataSource
    /// Use the AWS CloudFormation AWS::KinesisAnalytics::ApplicationReferenceDataSource resource to add a reference
    /// data source to an existing Amazon Kinesis Data Analytics application. For more information, see
    /// AddApplicationReferenceDataSource in the Amazon Kinesis Data Analytics Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html
    /// </summary>
    public class ApplicationReferenceDataSourceResource : ResourceBase
    {
        public class ApplicationReferenceDataSourceProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of an existing application.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// ReferenceDataSource
            /// The reference data source, which is an object in your Amazon Simple Storage Service (Amazon S3)
            /// bucket.
            /// Required: Yes
            /// Type: Kinesis Data Analytics ApplicationReferenceDataSource ReferenceDataSource
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-referencedatasource
            /// </summary>
			public Union<ReferenceDataSource, IntrinsicFunction> ReferenceDataSource { get; set; }

        }
    
        public string Type { get; } = "AWS::KinesisAnalytics::ApplicationReferenceDataSource";
        
        public ApplicationReferenceDataSourceProperties Properties { get; } = new ApplicationReferenceDataSourceProperties();
    }
}
