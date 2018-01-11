using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockRadio
{
    class AlarmClockRadio
    {
        //member variables
        string currentTime;
        string setRadioStation;
        string alarmTime;
        string userInput;
        public bool alarmIsOn;
        public bool radioIsOn;
        public string radio;
        public string alarm;

        //constructor
        public AlarmClockRadio()
        {
            currentTime = "12:00 AM";
            alarmTime = "5:30 AM";
            setRadioStation = "89.9 FM";
            alarmIsOn = false;
            radioIsOn = false;
        }

        //member methods
        public void SetAlarmTime()
        {
            Console.WriteLine("What time would you like to set the alarm for?");
            alarmTime = Console.ReadLine();
        }

        public void ToggleAlarm()
        {       
            alarmIsOn = !alarmIsOn;
         }

        public void RadioPower()
        {
           
            radioIsOn = !radioIsOn;
            if (radioIsOn == true)
            {
               radio = "on";
            }
            else
            {
                radio = "off";
            }
        }

        public string getCurrentTime()
        {
            Console.WriteLine("What is the current time?");
            currentTime = Console.ReadLine();
            return currentTime;
        }
    
        public void SetRadio()
        {
            Console.WriteLine("What station would you like the radio set to?");
            setRadioStation = Console.ReadLine();
        }
  
        public void Menu()
        {
            string alarm;
             if (alarmIsOn == true)
                {
                    alarm = "on";
                }
                else
                {
                    alarm = "off";
                }
            string radio;
            if (radioIsOn == true)
            {
                radio = "on";
            }
            else
            {
                radio = "off";
            }
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Select 1 to change the time. The current time is " + currentTime + ".");
            Console.WriteLine("Select 2 to set the alarm time. The alarm is set to " + alarmTime + ".");
            Console.WriteLine("Select 3 to turn the alarm on/off. The alarm is currently " + alarm + ".");
            Console.WriteLine("Select 4 to turn the radio on/off. The radio is " + radio + " .");
            Console.WriteLine("Select 5 to change the radio station. The station is currently " + setRadioStation + ".");
            Console.WriteLine("Select 0 to exit.");
            userInput = Console.ReadLine();
            Console.WriteLine("\n");

            switch (userInput)
                {
                case "0":
                Environment.Exit(0);
                    break;
                case "1":
                    getCurrentTime();
                    break;
                case "2":
                    SetAlarmTime();
                    break;
                case "3":
                    ToggleAlarm();
                    break;
                case "4":
                    RadioPower();
                    break;
                case "5":
                    SetRadio();
                    break;
                default:
                    Console.WriteLine("You have entered an invalid option. Please try again.");
                    break;
            }
            Console.Clear();
            Menu();
        }
    }
}


