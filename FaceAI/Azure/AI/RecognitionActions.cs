using FaceAI.Classes;
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
        public RecognitionActions(string tempPath)
        {
            this.tempPath = tempPath;
            model = new FaceModel();
        }

        public async Task<bool> ImageisFaceAsync(Bitmap image)
        {
            string url = await BlobCommonActions.SaveImageAsync(tempPath, image);
            return await model.ImageisFaceAsync(url);
        }
    }
}
