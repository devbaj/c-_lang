using System;
using phone;

public class Nokia : Phone, IRingable
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}

    public new string Ring() => base.Ring();

    public string Unlock()
    {
        return $"Nokia {VersionNumber} unlocked with passcode";
    }

    public override void DisplayInfo()
    {
        string sep = new String('$', 20);
        System.Console.WriteLine(sep);
        System.Console.WriteLine($"Nokia {VersionNumber}");
        System.Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
        System.Console.WriteLine($"Carrier: {Carrier}");
        System.Console.WriteLine($"Ring Tone: {RingTone}");
        System.Console.WriteLine(sep);
        System.Console.WriteLine("");
    }
}