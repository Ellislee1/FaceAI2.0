﻿using FaceAI.Classes;
using FaceAI.Exceptions;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceAI.Azure.AI
{
    class RecognitionActions
    {
        private FaceModel model;
        // Path to temporary folder
        string tempPath;

        private double threashold;
        public RecognitionActions(string tempPath, double threashold = 0.75)
        {
            this.tempPath = tempPath;
            this.threashold = threashold;
            this.model = new FaceModel();
        }

        public async Task<bool> ImageisFaceAsync(Bitmap image)
        {
            BlobImage blobImage = await BlobCommonActions.SaveImageAsync(tempPath, image);
            bool isFace =  await model.ImageisFaceAsync(blobImage.Url);
            // Delete the image for privacy
            BlobCommonActions.DeleteImage(blobImage);
            return isFace;
        }

        public async Task<bool> ImageisFaceAsync(BlobImage blobImage)
        {
            bool isFace = await model.ImageisFaceAsync(blobImage.Url);
            // Delete the image for privacy

            return isFace;
        }

        public async Task<List<FaceSimilarity>> FindSimilar(Bitmap image)
        {
            BlobImage blobImage = await BlobCommonActions.SaveImageAsync(tempPath, image);
            bool isFace = await ImageisFaceAsync(blobImage);
            // If no face is detected then throw this exception
            if (!isFace)
            {
                throw new NoFaceException();
            }

            List<string> targetImageFileNames = await BlobCommonActions.GetFilesAsync();
            IList<FaceSimilarity> targetFaces = new List<FaceSimilarity>();
            foreach (string targetImageFileName in targetImageFileNames)
            {
                string url = "https://6221faces.blob.core.windows.net/faces/" + targetImageFileName;
                // Detect faces from target image url.
                var faces = await model.DetectFaceRecognize(url);
                // Add detected faceId to list of values about this face.
                foreach(var face in faces)
                {
                    FaceSimilarity faceVal = new FaceSimilarity(targetImageFileName, url, 0, face.FaceId.Value, face.FaceRectangle);
                    targetFaces.Add(faceVal);
                }

                IList<DetectedFace> detectedFace = await model.DetectFaceRecognize(blobImage.Url);

                IList<SimilarFace> results = await model.FindSimilar(detectedFace[0], targetFaces);

                foreach(SimilarFace face in results)
                {
                    foreach (FaceSimilarity aFace in targetFaces.Where(x=>
                    {
                        return x.ImageGuid == face.FaceId;
                    }))
                    {
                        aFace.Similarity = face.Confidence >= this.threashold ? face.Confidence : 0;
                    }
                }
            }

            BlobCommonActions.DeleteImage(blobImage);
            return (List<FaceSimilarity>)targetFaces;
        }
    }
}
