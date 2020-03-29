using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input2;
            bool Continue;
            Continue = true;
            while (Continue) 
            {
              

                // Create class call sensor monitor 
                // list the instance variables for that class
                // create the class constructor and store the initialization parameters
                // create a method to update the desired parameters - gulcose level, blood pressure and heart rate
                // create a method to check the if the input is at a safe level
                // create method to return the safe status of the sensor
                // create a method to return the name of the sensor 
                // enter the main class and create 3 instances of a class for gulcose level, blood pressure and heart rate respectivly 
                // create 3 differnt varibales to store input from the console 
                // update the sensor for each parameter 
                // print each sensor name and the safe status with the corresponding advice to the patient 

                sensorreader sensor1;
                sensor1 = new sensorreader("Heart Rate Sensor", 100);

                sensorreader sensor2;
                sensor2 = new sensorreader("Blood Pressure Sensor ", 140);

                sensorreader sensor3;
                sensor3 = new sensorreader("Gulcose Level", 130);

                int Currentreading1;
                int Currentreading2;
                int Currentreading3;

                void ReadInput1(string ParameterName)
                {

                    string input;
                    Console.WriteLine(ParameterName);
                    input = Console.ReadLine();
                    Currentreading1 = int.Parse(input);
                }
                void ReadInput2(string ParameterName)
                {

                    string input;
                    Console.WriteLine(ParameterName);
                    input = Console.ReadLine();
                    Currentreading2 = int.Parse(input);
                }
                void ReadInput3(string ParameterName)
                {

                    string input;
                    Console.WriteLine(ParameterName);
                    input = Console.ReadLine();
                    Currentreading3 = int.Parse(input);
                }

                ReadInput1("Enter Heart Rate in BPM");
                ReadInput2("Enter Blood Pressure in mmHg");
                ReadInput3("Enter Blood Gulcose Level in mg/dL");

                sensor1.updatesensorreading(Currentreading1);
                sensor2.updatesensorreading(Currentreading2);
                sensor3.updatesensorreading(Currentreading3);

                static void PrintSensorStatus(string sensorname, bool sensorsafestatus)
                {
                    Console.WriteLine(sensorname);
                    Console.WriteLine("Is it safe?" + sensorsafestatus);

                }




                static void Getadvice(string advice1, string adivce2, bool sensorsafestatus)
                {
                    if (sensorsafestatus == false)
                    {
                        Console.WriteLine(adivce2);
                    }
                    else
                    {
                        Console.WriteLine(advice1);

                    }
                }




                PrintSensorStatus(sensor1.SensorName(), sensor1.IsSensorSafe());
                Getadvice(" Your heart rate is good", " Reduce consumption of cholestrol and exercise on a daily basis", sensor1.IsSensorSafe());


                PrintSensorStatus(sensor2.SensorName(), sensor2.IsSensorSafe());
                Getadvice("Your Blood Pressure is good", "Reduce consumption of salt and engage in distressing actvities more frequenty.", sensor2.IsSensorSafe());


                PrintSensorStatus(sensor3.SensorName(), sensor3.IsSensorSafe());
                Getadvice("Your Blood Gulcose Level is good", "Reduce consumption of sugar and carbohydrates in excess", sensor3.IsSensorSafe());


               
                Console.Write(" quit ?");
               input2 = Console.ReadLine();


                if (input2 == "yes")
                {
                    Continue = false;

                }
                else
                {
                    Continue = true;   
                }


            }
            Console.WriteLine("Thank You, the Program has ended");
        }
    }
}