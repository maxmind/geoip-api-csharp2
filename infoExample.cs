//an example of how to lookup the database info
using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    string GeoipDbPath = "/usr/local/share/GeoIP/";
    string GeoipDb = GeoipDbPath + "GeoIPCity.dat";
    if (args.Length > 0) {
      GeoipDb = args[0];
    }
    //open the database
    LookupService ls = new LookupService(GeoipDb, LookupService.GEOIP_STANDARD);
    //get the database info
    DatabaseInfo dbinfo = ls.getDatabaseInfo();
    Console.Write(" dbinfo string: " + dbinfo.toString() + "\n");
    Console.Write(" dbinfo type: " + dbinfo.getType() + "\n");
    Console.Write(" dbinfo date: " + dbinfo.getDate() + "\n");
  }
}
