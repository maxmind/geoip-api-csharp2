// an example of how to lookup the country of a ip address

// This only works with the GeoIP Country database
// See regionExample.cs, cityExample.cs, and orgExample.cs
// for the Region database, city database, and ISP/Organization databases

using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    string GeoipDbPath = "/usr/local/share/GeoIP/";
    string GeoipDb = GeoipDbPath + "GeoIP.dat";
    //open the database
    LookupService ls = new LookupService(GeoipDb, LookupService.GEOIP_MEMORY_CACHE);
    //get country of the ip address
    Country c = ls.getCountry("24.24.24.24");  
    Console.Write(" code: " + c.getCode()+"\n");    
    Console.Write(" name: " + c.getName()+"\n");    
  }
}
