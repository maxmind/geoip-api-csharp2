// an example of how to lookup the region of a ip address
using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    //open the database
    LookupService ls = new LookupService("/usr/local/share/GeoIP/GeoIPRegion.dat", LookupService.GEOIP_STANDARD);
    //get region of the ip address
    Region c = ls.getRegion("24.24.24.24");
    Console.Write(" code: " + c.getcountryCode()+"\n");
    Console.Write(" name: " + c.getcountryName()+"\n");
    Console.Write(" region: " + c.getregion() + "\n");
  }
}

