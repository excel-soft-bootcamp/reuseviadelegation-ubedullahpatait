using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera _camera = new Camera();
            GPS _gps = new GPS();
            Phone _phone = new Phone();

            SmartPhone _smartPhone = new SmartPhone();//Smartphone Should Deleagte Calls to  Camera, Gps,Phone
            _smartPhone.SetCamera(_camera);
            _smartPhone.SetGps(_gps);
            _smartPhone.SetPhone(_phone);

            

            //Substitute Camera with SmartPhone , GPS with SmartPhone , Phone With SamrtPhone
            PhotoGrapher _photoGrapher = new PhotoGrapher();
            _photoGrapher.Capture(_camera);
            _photoGrapher.Capture(_smartPhone);

            Traveller _traveller = new Traveller();
            _traveller.Hike(_gps);
            _traveller.Hike(_smartPhone);

            Person _person = new Person();
            _person.Communicate(_phone);
            _person.Communicate(_smartPhone);



            _photoGrapher.Capture(_smartPhone);
            _traveller.Hike(_smartPhone);
            _person.Communicate(_smartPhone);






        }
    }
}
