//an example of how to lookup the city of a ip address
using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    //open the database
    try {
      LookupService ls = new LookupService("/usr/local/share/GeoIP/GeoIPCity.dat", LookupService.GEOIP_STANDARD);
      //get city location of the ip address
      if (args.Length > 0) {
        Location l = ls.getLocation(args[0]);
        if (l != null) {
          Console.Write("country code " + l.countryCode + "\n");
          Console.Write("country name " + l.countryName + "\n");
          Console.Write("region " + l.region + "\n");
          Console.Write("city " + l.city + "\n");
          Console.Write("postal code " + l.postalCode + "\n");
          Console.Write("latitude " + l.latitude + "\n");
          Console.Write("longitude " + l.longitude + "\n");
          Console.Write("metro code " + l.metro_code + "\n");
          Console.Write("area code " + l.area_code + "\n");
          Console.Write("region name " + l.regionName + "\n");
        } else {
          Console.Write("IP Address Not Found\n");
        }
      } else {
        Console.Write("Usage: cityExample IPAddress\n");
      }
    } catch (System.Exception e) {
      Console.Write("Error" + e.Message + "\n");
    }
  }
}

