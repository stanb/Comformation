using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.ApplicationReferenceDataSource
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html
    /// </summary>
    public class ApplicationReferenceDataSourceResource : ResourceBase
    {
        public class ApplicationReferenceDataSourceProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-applicationreferencedatasource.html#cfn-kinesisanalytics-applicationreferencedatasource-referencedatasource
            /// </summary>
			public Union<ReferenceDataSource, IntrinsicFunction> ReferenceDataSource { get; set; }

        }
    
        public string Type { get; } = "AWS::KinesisAnalytics::ApplicationReferenceDataSource";
        
        public ApplicationReferenceDataSourceProperties Properties { get; } = new ApplicationReferenceDataSourceProperties();
    }
}
