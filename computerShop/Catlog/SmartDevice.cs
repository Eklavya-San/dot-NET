namespace Catlog;
using System;
public class SmartDevice:Product{
    private int Count {get;set;}
    public string ? specification {get;set;}

    public SmartDevice():base(){

    }
    ~SmartDevice(){

    }
    public void Connect () {
        Console.WriteLine("Connected to device");
    }
    public void DisConnected () {
        Console.WriteLine("Disconnected to device");
    }
}