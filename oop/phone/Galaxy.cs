using System;
using phone;

public class Galaxy : Phone, IRingable
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}

    public new string Ring() => base.Ring();

    public string Unlock()
    {
        return $"Galaxy {VersionNumber} unlocked with fingerprint scanner";
    }

    public override void DisplayInfo()
    {
        string sep = new String('#', 20);
        System.Console.WriteLine(sep);
        System.Console.WriteLine($"Galaxy {VersionNumber}");
        System.Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
        System.Console.WriteLine($"Carrier: {Carrier}");
        System.Console.WriteLine($"Ring Tone: {RingTone}");
        System.Console.WriteLine(sep);
        System.Console.WriteLine("");
    }
}