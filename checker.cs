using System;
using System.Diagnostics;

class Checker
{
    static int checkvitals=1;
    static bool checkbpm(float bpm)
    {
       if(bpm < 70 || bpm > 150) {
            return false;  
        } 
        return true;
    }
    
     static bool checkspo2(float spo2)
    {
       if(spo2 < 90) {
            return false;  
        } 
        return true;
    }
    
    static bool checkresprate(float respRate)
    {
       if(respRate < 30 || respRate > 95) {
            return false;  
        } 
        return true;
    }
    
    static void vitalsAreOk(float bpm, float spo2, float respRate) {
        
        if(checkresprate(resprate) && checkbpm(bpm) && checspo2(spo2))
        {
            checkvitals=1;  
        } 
        checkvitals=0;
       
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
        vitalsAreOk(100,95,60);
        if(checkvitals==1)
        {
            Console.WriteLine("All ok");
            return 0;
        }
        Console.WriteLine("Not ok");
        return 0;  
    }
}
