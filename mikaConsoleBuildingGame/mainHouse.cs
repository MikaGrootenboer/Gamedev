using System;

class mainHouse : Building
{
    string name = "MainHouse";
    string info = "this is the mainbuilding, the job of this building is a global overview of your city";

    int mainhouseHp = 100;
    public void getBuildingName(){
        Console.WriteLine("this is " + name );
    }
    public void getBuildingInfo()
    {
        Console.WriteLine(info);
    }
    public void getBuildingHP(){
        Console.WriteLine("building hp = " + mainhouseHp);
    }    
}