using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneSample
{
   public class SmartPhone:ICamera,IPhone,IGPS
    {
        ICamera _cameraRef;
        IPhone _phoneRef;
        IGPS _gpsRef;

        public void SetCamera(ICamera cameraRef)
        {
            this._cameraRef = cameraRef;

        }

        public void SetPhone(IPhone phoneRef)
        {
            this._phoneRef = phoneRef;
        }

        public void SetGps(IGPS gpsRef)
        {
            this._gpsRef = gpsRef;
        }




        public void TakePicture()
        {

            this._cameraRef.TakePicture();


        }
        public void Hangup() 
        {
            this._phoneRef.Hangup();

        }
        public void Release()
        {
            this._phoneRef.Release();
        }
        public void Navigate()
        {
            this._gpsRef.Navigate();

        }
    }
}
