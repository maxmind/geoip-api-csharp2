using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    LookupService ls = new LookupService("/usr/local/share/GeoIP/GeoIPNetSpeed.dat", LookupService.GEOIP_STANDARD);
    int id = ls.getID(args[0]);
    int speed = id;
    if (speed == LookupService.GEOIP_UNKNOWN_SPEED){
      Console.Write("Unknown \n");
    } else if (speed == LookupService.GEOIP_DIALUP_SPEED){
      Console.Write("Dialup \n");
    } else if (speed == LookupService.GEOIP_CABLEDSL_SPEED){
      Console.Write("Cable/DSL \n");
    } else if (speed == LookupService.GEOIP_CORPORATE_SPEED){
      Console.Write("Corporate \n");
    }
  }
}
