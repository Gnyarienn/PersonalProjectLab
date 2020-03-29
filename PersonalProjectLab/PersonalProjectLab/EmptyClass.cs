using System;
namespace PersonalProjectLab
{
    public class sensorreader
    {
        //enter the necessary instace varibales
        string Sensorname;
        int Warninglevel;
        int Currentreading;
        bool Sensorissafe;
        



        public sensorreader(string sensorname, int warninglevel)
        {

            Sensorname = sensorname;
            Warninglevel = warninglevel;

        }

        public void updatesensorreading(int currentreading)
        {
            Currentreading = currentreading;
            Checksensor();
        }

        private void Checksensor()
        {
            if (Currentreading > Warninglevel)
            {
                Sensorissafe = false;
                

            }
            else
            {
                Sensorissafe = true;
                
            }
        }
        public bool IsSensorSafe()
        {
            return Sensorissafe;
        }

        public string SensorName()
        {
            return Sensorname;

        }

        

    }
}
