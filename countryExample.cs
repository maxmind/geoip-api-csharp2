// an example of how to lookup the country of a ip address
using System;
using System.IO;
class Appa0{
  public static void Main(String[] args){
    //open the database
    LookupService ls = new LookupService("/usr/local/share/GeoIP/GeoIP.dat");
    //get country of the ip address
    Country c = ls.getCountry("24.24.24.24");  
    Console.Write(" code: " + c.getCode()+"\n");    
    Console.Write(" name: " + c.getName()+"\n");    
  }
}
