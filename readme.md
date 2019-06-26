# HelperExtensions
_Miscellaneous Helper Extensions_   
[![Version](https://img.shields.io/nuget/v/Midnite81.HelperExtensions.svg)](https://www.nuget.org/packages/Midnite81.HelperExtensions/)&nbsp;
[![Downloads](https://img.shields.io/nuget/dt/Midnite81.HelperExtensions.svg)](https://www.nuget.org/packages/Midnite81.HelperExtensions/)&nbsp; 
[![Licence](https://img.shields.io/github/license/midnite81/HelperExtensions.svg)](https://github.com/midnite81/HelperExtensions/blob/master/LICENSE)&nbsp; 
[![Build](https://travis-ci.org/midnite81/HelperExtensions.svg?branch=master)](https://travis-ci.org/midnite81/HelperExtensions)&nbsp;
[![Issues](https://img.shields.io/github/issues/midnite81/HelperExtensions.svg)](https://github.com/midnite81/HelperExtensions/issues)&nbsp;

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