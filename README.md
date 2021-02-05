# Guide Application

## Technologies

* EntityFrameworkCore
* Swagger

## Overview

### Installation
First you must change "ConnectionStrings" under "appsettings.json" according to your own database!
```solidity


"ConnectionStrings": {
    "GuideApp": "Data Source="
  },

```
You must run the following commands through Package Manager Console 

```console
$ Add-Migration "Specified Name"
$ Update-Database
```
