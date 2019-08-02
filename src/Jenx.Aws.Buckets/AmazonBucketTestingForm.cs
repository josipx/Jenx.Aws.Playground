using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

namespace Jenx.Aws.Buckets
{
    public partial class AmazonBucketTestingForm : Form
    {
        private readonly IAmazonS3 _amazonS3;

        public AmazonBucketTestingForm(IAmazonS3 amazonS3)
        {
            _amazonS3 = amazonS3;
            InitializeComponent();
        }

        private async void CreateEmptyBucketTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                // create ad-hoc unique bucket name.
                var newBucketName = "test-bucket-" + Guid.NewGuid();

                // create...
                var actionResponse = await _amazonS3.PutBucketAsync(newBucketName);

                // display what happened...
                if (actionResponse.HttpStatusCode == HttpStatusCode.OK)
                    WriteLogLine($@"New {newBucketName} created.");
                else
                    WriteLogLine($@"Something went wrong when creating new ""{newBucketName}"" bucket.");
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                WriteLogLine($@"S3 error occurred. Exception: {amazonS3Exception}.");
            }
            catch (Exception ex)
            {
                WriteLogLine($@"Exception: {ex}.");
            }
        }

        private async void CreateAndDeleteEmptyBucketTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                // create ad-hoc unique bucket name.
                var newBucketName = "test-bucket-" + Guid.NewGuid();

                // create...
                var createActionResponse = await _amazonS3.PutBucketAsync(newBucketName);

                // display what happened...
                if (createActionResponse.HttpStatusCode == HttpStatusCode.OK)
                {
                    WriteLogLine($@"New {newBucketName} created.");
                }
                else
                {
                    WriteLogLine($@"Something went wrong when creating new ""{newBucketName}"" bucket.");
                    return;
                }

                WriteLogLine($@"Waiting 5 sec and then deleting {newBucketName} bucket.");
                await Task.Delay(5000);

                var deleteActionResponse = await _amazonS3.DeleteBucketAsync(newBucketName);

                if (deleteActionResponse.HttpStatusCode == HttpStatusCode.NoContent) // here extra check is needed!!
                    WriteLogLine($@"{newBucketName} deleted.");
                else
                    WriteLogLine($@"Something went wrong when deleting ""{newBucketName}"" bucket.");
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                WriteLogLine($@"S3 error occurred. Exception: {amazonS3Exception}.");
            }
            catch (Exception ex)
            {
                WriteLogLine($@"Exception: {ex}.");
            }
        }

        private async void CreateEmptyBucketAndUploadTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                // new aws bucket name...
                var newBucketName = "test-bucket-" + Guid.NewGuid();

                // pickup local file to be uploaded...
                var localDir = Assembly.GetExecutingAssembly().GetDirectoryPath();
                var filename = "TestFile.txt";
                var localFileNamePath = Path.Combine(localDir, filename);

                // create aws bucket first...
                var bucketCreationResponse = await _amazonS3.PutBucketAsync(newBucketName);

                if (bucketCreationResponse.HttpStatusCode != HttpStatusCode.OK)
                    WriteLogLine($@"New {newBucketName} creation failed, exiting.");

                // start uploading selected file...
                var request = new TransferUtilityUploadRequest();
                using var utility = new TransferUtility(_amazonS3);
                request.BucketName = newBucketName;
                request.Key = filename;
                request.FilePath = localFileNamePath;

                await utility.UploadAsync(request);
                WriteLogLine($@"File ""{filename}""uploaded to newly created {newBucketName} bucket.");
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                WriteLogLine($@"S3 error occurred. Exception: {amazonS3Exception}.");
            }
            catch (Exception ex)
            {
                WriteLogLine($@"Exception: {ex}");
            }
        }

        private async void GetBucketSubfolderTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new ListObjectsV2Request {BucketName = "jenx-test-bucket", MaxKeys = 10};

                ListObjectsV2Response response;
                do
                {
                    response = await _amazonS3.ListObjectsV2Async(request);

                    foreach (var entry in response.S3Objects)
                        WriteLogLine($@"key = {entry.Key} size = {entry.Size}, {entry.StorageClass}");
                    request.ContinuationToken = response.NextContinuationToken;
                } while (response.IsTruncated);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                WriteLogLine($@"S3 error occurred. Exception: {amazonS3Exception}.");
            }
            catch (Exception ex)
            {
                WriteLogLine($@"Exception: {ex}.");
            }
        }

        private void WriteLogLine(string logEntry)
        {
            OutputControl.Text += logEntry + Environment.NewLine;
        }
    }
}