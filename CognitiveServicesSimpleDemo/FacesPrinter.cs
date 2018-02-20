using System;
using System.Linq;
using Microsoft.ProjectOxford.Face.Contract;

namespace CognitiveServicesSimpleDemo
{
    public static class FacesPrinter
    {
        public static void Print(Face[] faces)
        {
            foreach (var face in faces)
            {
                Console.WriteLine();
                Console.WriteLine($"Age: {face.FaceAttributes.Age}");
                Console.WriteLine($"Gender: {face.FaceAttributes.Gender}");
                Console.WriteLine($"Bald: {face.FaceAttributes.Hair.Bald}");
                Console.WriteLine($"Accessories: ");
                if (face.FaceAttributes.Accessories.Any())
                {
                    foreach (var accessory in face.FaceAttributes.Accessories)
                    {
                        Console.WriteLine($"   {accessory.Type} : {accessory.Confidence}");
                    }
                }
                else
                {
                    Console.WriteLine($"   none");
                }
                Console.WriteLine($"Hair color:");
                if (face.FaceAttributes.Hair.HairColor.Any())
                {
                    foreach (var hairColor in face.FaceAttributes.Hair.HairColor)
                    {
                        Console.WriteLine($"   {hairColor.Color} : {hairColor.Confidence}");
                    }
                }
                else
                {
                    Console.WriteLine($"   none");
                }
                Console.WriteLine($"Facial Hair: ");
                Console.WriteLine($"   Beard: {face.FaceAttributes.FacialHair.Beard}");
                Console.WriteLine($"   Moustache: {face.FaceAttributes.FacialHair.Moustache}");
                Console.WriteLine($"   Sideburns: {face.FaceAttributes.FacialHair.Sideburns}");
                Console.WriteLine($"Emotion : ");
                Console.WriteLine($"   Happy: {face.FaceAttributes.Emotion.Happiness}");
                Console.WriteLine($"   Neutral: {face.FaceAttributes.Emotion.Neutral}");
                Console.WriteLine($"   Sad: {face.FaceAttributes.Emotion.Sadness}");
                Console.WriteLine($"   Anger: {face.FaceAttributes.Emotion.Anger}");
                Console.WriteLine($"   Contempt: {face.FaceAttributes.Emotion.Contempt}");
                Console.WriteLine($"   Disgust: {face.FaceAttributes.Emotion.Disgust}");
                Console.WriteLine($"   Fear: {face.FaceAttributes.Emotion.Fear}");
                Console.WriteLine($"   Surprise: {face.FaceAttributes.Emotion.Surprise}");
                Console.WriteLine();
            }
        }
    }
}
