using System;
using System.Windows.Forms;
using Amazon.S3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jenx.Aws.Buckets
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var servicesContainer = new ServiceCollection();
            servicesContainer.AddSingleton<IConfiguration>(configuration);
            servicesContainer.AddAWSService<IAmazonS3>();
            servicesContainer.AddSingleton<AmazonBucketTestingForm>();

            // apply app styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = servicesContainer.BuildServiceProvider();
            var entryForm = (Form)serviceProvider.GetService(typeof(AmazonBucketTestingForm));
            Application.Run(entryForm);
        }
    }
}
