# GeoIP C# API 1.18

As of version 1.14 this API is thread safe.

Instructions for Mono. See http://www.mono-project.com/
Should also work in Windows C# environment.

To compile the examples:

Country:
gmcs examples/countryExample.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

City:
gmcs examples/cityExample.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

Country v6:
gmcs examples/countryV6Example.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

City v6:
gmcs examples/cityV6Example.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

Region:
gmcs examples/regionExample.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

Organization:
gmcs examples/orgExample.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

Domain:
gmcs examples/domainExample.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

Netspeed cell:
gmcs examples/netspeedCellExample.cs Country.cs DatabaseInfo.cs Location.cs LookupService.cs Region.cs RegionName.cs

To run the examples:

Country:
mono countryExample.exe

City:
mono cityExample.exe 24.24.24.24

Organization:
mono orgExample.exe

Domain:
mono domainExample.exe

ASN:
mono asnExample.exe

Country v6:
mono countryV6Example.exe

City:
mono cityV6Example.exe ::24.24.24.24

ASN v6:
mono asnV6Example.exe

## Memory Caching

There are two options available:

* `GEOIP_STANDARD` - Read database from filesystem. Uses least memory.
* `GEOIP_MEMORY_CACHE` - load database into memory, faster performance
  but uses more memory

Copyright 2013 MaxMind, Inc.

Licensed under the LGPL
