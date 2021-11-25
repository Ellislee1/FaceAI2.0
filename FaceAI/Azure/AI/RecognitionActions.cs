using FaceAI.Classes;
using FaceAI.Exceptions;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public async Task<List<Face>> FindSimilar(Face parent, ProgressBar pbar, int incrimentVal)
        {
            try
            {
                List<string> targetImageFileNames = await BlobCommonActions.GetFilesAsync();
                List<Face> targetFaces = new List<Face>();

                int incrimentable = incrimentVal / targetImageFileNames.Count;
                foreach (string targetImageFileName in targetImageFileNames)
                {
                    string url = "https://6221faces.blob.core.windows.net/faces/" + targetImageFileName;
                    // Detect faces from target image url.
                    var faces = await model.DetectFaceRecognize(url);
                    // Add detected faceId to list of values about this face.
                    foreach (var face in faces)
                    {
                        Face faceVal = new Face(targetImageFileName, url, 0, face.FaceId.Value, face.FaceRectangle);
                        targetFaces.Add(faceVal);
                    }

                    IList<SimilarFace> results = await model.FindSimilar(parent.DetectedFace, targetFaces);

                    foreach (SimilarFace face in results)
                    {
                        foreach (Face aFace in targetFaces.Where(x =>
                        {
                            return (x.ImageGuid != parent.DetectedFace.FaceId) && (x.ImageGuid == face.FaceId);
                        }))
                        {
                            aFace.Similarity = face.Confidence >= this.threashold ? face.Confidence : 0;
                        }
                    }

                    pbar.Value += incrimentable;
                }
                return targetFaces;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Face>> FindParent(Bitmap image)
        {
            BlobImage blobImage = await BlobCommonActions.SaveImageAsync(tempPath, image);
            List<DetectedFace> detected = await model.DetectFaceRecognize(blobImage.Url);

            List<Face> allFaces = new List<Face>();
            foreach(var face in detected)
            {
                Face thisFace = new Face(blobImage.Filename, blobImage.Url, 1, face.FaceId.Value, face.FaceRectangle, face);
                allFaces.Add(thisFace);
            }

            return allFaces;
        }
    }
}
