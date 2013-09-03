//an example of how to lookup the isp or org of a ip address
using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    //open the database
    LookupService ls = new LookupService("/usr/local/share/GeoIP/GeoIPOrg.dat", LookupService.GEOIP_STANDARD);
    //get org of the ip address
    String orgorisp = ls.getOrg("24.24.24.24");
    Console.Write(" org: " + orgorisp + "\n");
  }
}
