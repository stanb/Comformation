using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.S3;
using Amazon.S3.Model;
using Comformation.IntrinsicFunctions;
using Comformation.S3.Bucket;
using Xunit;

namespace Comformation.Tests
{
    public class CreateStackTest
    {
        private readonly AmazonCloudFormationClient _cloudformation;
        
        public CreateStackTest()
        {
            _cloudformation = new AmazonCloudFormationClient(RegionEndpoint.EUWest1);
            
        }

        /// <summary>
        /// This test is a sample of usage for the Comformation library.
        /// The generated template plays arround mappings, input and output parameters. 
        /// The template creates S3 bucket whose name generated using several intrinsic functions.
        /// </summary>
        [Fact]
        public async Task CreateSimpleStack()
        {
            // Generate template
            var template = CreateSimpleTemplate();

            var request = new CreateStackRequest
            {
                StackName = "ComformationTestSimpleTemplate",
                TemplateBody = template.ToString(),
                Parameters = new List<Amazon.CloudFormation.Model.Parameter>
                {
                    new Amazon.CloudFormation.Model.Parameter
                    {
                        ParameterKey = "Param2",
                        ParameterValue = "2"
                    }
                },
            };

            try
            {
                // Create stack
                var createResponse = await _cloudformation.CreateStackAsync(request);

                try
                {
                    // Get created stack details
                    var stack = await _cloudformation.GetCreatedStack(createResponse.StackId);
                
                    // Validate created stack
                    await AssertCreatedStuck(stack, template);
                }
                finally
                {
                    // cleanup
                    var deleteResponse =
                        await _cloudformation.DeleteStackAsync(new DeleteStackRequest
                        {
                            StackName = createResponse.StackId
                        });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async Task AssertCreatedStuck(Stack stack, Template template)
        {
            var createdBucket = stack.Outputs.FirstOrDefault(x => x.OutputKey == "CreatedBucket");
            Assert.NotNull(createdBucket);
            Assert.StartsWith("test-bucket-ireland-2-", createdBucket.OutputValue);

            var s3 = new AmazonS3Client(RegionEndpoint.EUWest1);
            var locationResponse = await s3.GetBucketLocationAsync(createdBucket.OutputValue);
            Assert.Equal(locationResponse.Location, S3Region.EUW1);
            var taggingResponse = await s3.GetBucketTaggingAsync(
                new GetBucketTaggingRequest {BucketName = createdBucket.OutputValue});
            Assert.Contains(taggingResponse.TagSet, x => x.Key == "Project" && x.Value == "Comformation");
        }

        private Template CreateSimpleTemplate()
        {
            var template = new Template
            {
                Description = "Test comformation",
                Parameters = new Parameters
                {
                    new Parameter
                    {
                        LogicalId = "Param1",
                        Type = ParameterType.String,
                        Default = "Value1",
                        Description = "Parameter 1",
                    },
                    new Parameter
                    {
                        LogicalId = "Param2",
                        Type = ParameterType.Number,
                        AllowedValues = new object [] { 1, 2 },
                        Description = "Parameter 2",
                    }
                },
                Resources = new Resources
                {
                    new BucketResource
                    {
                        LogicalId = "MyBucket",
                        Properties =
                        {
                            // resource name build using intrinsic functions and based on input parameters and mapping
                            BucketName = Fn.Sub($"test-bucket-${{sufix}}-{Guid.NewGuid()}",
                                new Sub.Item("sufix", Fn.FindInMap("BucketSufix", Fn.Ref(PseudoParameter.Region), Fn.Ref("Param2")))),
                            Tags = new List<Tag>
                            {
                                new Tag
                                {
                                    Key = "Project", Value = "Comformation"
                                }
                            }
                        }
                    }
                },
                Mappings = new Mappings
                {
                    new Mapping
                    {
                        Name = "BucketSufix",
                        Regions =
                        {
                            new RegionMap
                            {
                                Region = RegionEndpoint.EUWest1,
                                Map = { { "1", "ireland-1" }, {"2", "ireland-2"} }
                            },
                            new RegionMap
                            {
                                Region = RegionEndpoint.EUWest2,
                                Map = { { "1", "london-1" }, { "2", "london-2"} }
                            }
                        }
                    }
                },
                Outputs = new Outputs
                {
                    // output based on input parameter
                    new Output
                    {
                        Description = "Input Parameter 1",
                        LogicalId = "Input1",
                        Value = Fn.Ref("Param1")
                    },
                    // output based on input parameter
                    new Output
                    {
                        Description = "Input Parameter 2",
                        LogicalId = "Input2",
                        Value = Fn.Ref("Param2")
                    },
                    // output based on pseudo parameter - region where stack run
                    new Output
                    {
                        LogicalId = "Region",
                        Description = "Region",
                        Value = Fn.Ref(PseudoParameter.Region)
                    },
                    // output based on pseudo parameter - created stack id
                    new Output
                    {
                        LogicalId = "StackId",
                        Description = "Stack Id",
                        Value = Fn.Ref(PseudoParameter.StackId)
                    },
                    // output based on pseudo parameter - created stack name
                    new Output
                    {
                        LogicalId = "StackName",
                        Description = "Stack Name",
                        Value = Fn.Ref(PseudoParameter.StackName)
                    },
                    // output based on created resource
                    new Output
                    {
                        LogicalId = "CreatedBucket",
                        Description = "Name of created bucket",
                        Value = Fn.Ref("MyBucket")
                    },
                    // output based on input param and mapping
                    new Output
                    {
                        LogicalId = "Sufix",
                        Description = "Bucket name sufix",
                        Value = Fn.FindInMap("BucketSufix", Fn.Ref(PseudoParameter.Region), Fn.Ref("Param2"))
                    }
                }
            };
            return template;
        }

    }
}
