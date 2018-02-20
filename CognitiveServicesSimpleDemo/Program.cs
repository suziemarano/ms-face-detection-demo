using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Face;
using Microsoft.ProjectOxford.Face.Contract;

namespace CognitiveServicesSimpleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read and display image
            var fileName = args[0];
            var fileStream = new FileStream(fileName, FileMode.Open);
            Process.Start(fileName);

            //Get face info for image
            var faces = GetFaces(fileStream).GetAwaiter().GetResult();

            //Print face info
            FacesPrinter.Print(faces);
        }

        static async Task<Face[]> GetFaces(Stream fStream)
        {
            // Create Face API Client.
            FaceServiceClient faceClient = new FaceServiceClient("748c9688f6af4638b4187b822976d7ed",
                "https://westcentralus.api.cognitive.microsoft.com/face/v1.0");

            var attrs = new List<FaceAttributeType>
            {
                FaceAttributeType.Age,
                FaceAttributeType.Gender,
                FaceAttributeType.Accessories,
                FaceAttributeType.Hair,
                FaceAttributeType.Emotion,
                FaceAttributeType.FacialHair
            };
            return await faceClient.DetectAsync(fStream, returnFaceAttributes: attrs);
        }
    }
}
