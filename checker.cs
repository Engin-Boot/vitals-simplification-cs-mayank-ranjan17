using System;
using System.Diagnostics;

class Checker
{
    static int checkvitals=1;
    static void checkbpm(float bpm)
    {
       //correcting the max range for bpm given as 150 initially
       if(bpm < 70 || bpm > 100) {
             checkvitals=0;
        } 
    }
    
     static void checkspo2(float spo2)
    {
       if(spo2 < 90) {
            checkvitals=0;  
        } 
    }
    
    static void checkresprate(float respRate)
    {
       //respiratory rate is 12 to 16 for a normal adult
       if(respRate < 12 || respRate >16) {
            checkvitals=0;
        } 
        
    }
    
    //new feature to check bp
    static void checkbp(float bp)
    {
        if(bp < 80 || bp > 120)
        {
            checkvitals=0;
        }
    }
    
    static void vitalsAreOk(float bpm, float spo2, float respRate,float bp) {
        
        checkvitals=1;//condition for all ok case
        checkresprate(respRate);
        checkbpm(bpm);
        checkspo2(spo2);
        checkbp(bp);
        
        
    }
    /*static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }*/
    static int Main() {
        //ExpectTrue(vitalsAreOk(100, 95, 60));
        //ExpectFalse(vitalsAreOk(40, 91, 92));
        vitalsAreOk(100,95,60,80);
        if(checkvitals==1)
        {
            Console.WriteLine("All ok");
            return 0;
        }
        Console.WriteLine("Not ok");
        return 0;  
    }
}
