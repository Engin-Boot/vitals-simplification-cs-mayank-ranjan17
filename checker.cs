using System;
using System.Diagnostics;

class Checker
{
    static int checkvitals=1;
    static void checkbpm(float bpm)
    {
       if(bpm < 70 ) {
             Console.WriteLine("Low beats per minute");
             checkvitals=0;
        } 
        else if(bpm >100)
        {
            Console.WriteLine("High beats per minute");
            checkvitals=0;
        }
    }
    
     static void checkspo2(float spo2)
    {
       if(spo2 < 90) {
            Console.WriteLine("Low Spo2 rate");
            checkvitals=0;  
        } 
       else if(spo2>100){
           Console.WriteLine("Not a valid range for SpO2");
           checkvitals=0;
       }
    }
    
    static void checkresprate(float respRate)
    {
       if(respRate < 12 ) {
            Console.WriteLine("Low Respiratory rate");
            checkvitals=0;
        } 
        else if(respRate>16)
        {
            Console.WriteLine("High Respiratory rate");
            checkvitals=0;
        }
        
    }
    static void checkbp(float bp)
    {
        if(bp < 80)
        {
            Console.WriteLine("Low BP");
            checkvitals=0;
        }
        else if(bp>120)
        {
            Console.WriteLine("High BP");
            checkvitals=0;
        }
    }
    
    static void vitalsAreOk(float bpm, float spo2, float respRate,float bp) {
        
        checkvitals=1;
        checkresprate(respRate);
        checkbpm(bpm);
        checkspo2(spo2);
        checkbp(bp);
        
        
    }
    static int Main() {
        vitalsAreOk(100,95,60,80);
        if(checkvitals==1)
        {
            Console.WriteLine("All ok");
            return 0;
        }
        Console.WriteLine("Check for all the above remarks");
        return 0;  
    }
}
