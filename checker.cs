using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if(bpm < 70 || bpm > 150 || spo2 < 90 || respRate < 30 || respRate > 95) {
            Console.WriteLine("Not ok");
            return false;
        } 
        Console.WriteLine("All ok");
        return true;
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
        
       
        
        
        
    }
}
