# HelperExtensions
_Miscellaneous Helper Extensions_   
[![Version](https://img.shields.io/nuget/v/Midnite81.HelperExtensions.svg)](https://www.nuget.org/packages/Midnite81.HelperExtensions/) [![Downloads](https://img.shields.io/nuget/dt/Midnite81.HelperExtensions.svg)](https://www.nuget.org/packages/Midnite81.HelperExtensions/) [![Licence](https://img.shields.io/github/license/midnite81/HelperExtensions.svg)](https://github.com/midnite81/HelperExtensions/blob/master/LICENSE) [![Build](https://travis-ci.org/midnite81/HelperExtensions.svg?branch=master)](https://travis-ci.org/midnite81/HelperExtensions) [![Issues](https://img.shields.io/github/issues/midnite81/HelperExtensions.svg)](https://github.com/midnite81/HelperExtensions/issues) [![Coverage Status](https://coveralls.io/repos/github/midnite81/HelperExtensions/badge.svg?branch=master)](https://coveralls.io/github/midnite81/HelperExtensions?branch=master)

## Introduction

This is a bit of a personal project for the time being. Over the coming
months and years, I intend to fill this project with useful extension
methods to make code more readable and less fiddly! 

## IsNull and IsNotNull

I am not overly keen on checking for null by doing `if (user == null) ...`
so I have created two helper functions, one checks if the item is null
the other checks if the item is not null. 

### Usage

```
if (user.IsNull())
  throw new UserNotFoundException();
  
if (user.IsNotNull())
  login();  
```

## IsOneOf and IsOneOfCaseInsensitive

This extension checks to see if an the original (IComparable) object is 
equal to one of the (IEnumerable and Icomparable) items passed to the 
method. 

If you wish for the comparison to be case insensitive use 
`IsOneOfCaseInsensitive`

### Usage

```
if (user.UserLevel.IsOneOf(new[] { "Admin", "Super Admin" }))
   RedirectToAdminDashboard();
 
```

## HasValueEqualTo

This extension checks to see if a nullable type has a value and if it 
does it checks to see if it is equal to the (Icomparable) value passed 
in the parameter.

### Usage

```
int? dayOfWeek = 5;

if (dayOfWeek.HasValueEqualTo(5))
   LetsPartyItsFriday();
 
```