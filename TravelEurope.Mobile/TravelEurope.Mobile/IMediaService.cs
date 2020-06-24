using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Mobile
{
    public interface IMediaService
    {
        byte[] ResizeImage(byte[] imageData, float width, float height);
    }
}
