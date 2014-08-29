# GeoIP Legacy .NET API #

## Important Note ##

This API is for the GeoIP Legacy format (dat). To read the MaxMind DB format
(mmdb) used by GeoIP2, please see
[our GeoIP2 .NET API](https://github.com/maxmind/GeoIP2-dotnet).

## Thread Safety ##

As of version 1.14 this API is thread safe.

## Instructions for Mono ##

To compile the examples:

Country:
gmcs examples/countryExample.cs src/*.cs

City:
gmcs examples/cityExample.cs src/*.cs

Country v6:
gmcs examples/countryV6Example.cs src/*.cs

City v6:
gmcs examples/cityV6Example.cs src/*.cs

Region:
gmcs examples/regionExample.cs src/*.cs

Organization:
gmcs examples/orgExample.cs src/*.cs

Domain:
gmcs examples/domainExample.cs src/*.cs

Netspeed cell:
gmcs examples/netspeedCellExample.cs src/*.cs

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

## Memory Caching ##

There are two options available:

* `GEOIP_STANDARD` - Read database from filesystem. Uses least memory.
* `GEOIP_MEMORY_CACHE` - load database into memory, faster performance
  but uses more memory

Copyright 2013 MaxMind, Inc.

Licensed under the LGPL
