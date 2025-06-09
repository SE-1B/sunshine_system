using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public class LoadImage
    {
        // load image from URL
        public void LoadImageFromWeb(PictureBox pb, string imageUrl)
        {
            try
            {
                if (imageUrl.Substring(0, 1) == "#")
                {
                    imageUrl = imageUrl.Substring(1);
                }
                WebRequest request = WebRequest.Create(imageUrl);
                using (WebResponse response = request.GetResponse())
                using (System.IO.Stream stream = response.GetResponseStream())
                {
                    Image img = Image.FromStream(stream);
                    pb.Image = img;
                }
            }
            catch (Exception ex)
            {
                // Show error image
                pb.Image = null;
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
    }
}
