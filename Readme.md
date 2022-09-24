Core Pluralizer
===============


![EnTier](Graphics/icon.png)


About
--------

This library enables the client code to provide plural form for a noun in a string.

 * Currently only supports English
 * Adds ```ToPlural()``` extension method to string class
 * Supports both regular and irregular forms
 

References
---------

 * The Lexicon for corresponding singular/plural (mostly for irregular forms) is used from [This File](https://raw.githubusercontent.com/RosaeNLG/rosaenlg/master/packages/english-plurals-list/resources/noun.exc) 
 of [RosaNlg Project](https://github.com/RosaeNLG/rosaenlg)
 * Regular form rules are implemented according to [This Page](https://www.grammarly.com/blog/plural-nouns/)

Usage
-------

 * Install the library from [NuGet](https://www.nuget.org/packages/CorePluralizer)
 * call ```ToPlural()``` method on the string containing the singular form noun.

You can also check out the example code: __CorePluralizer.Example__


Thanks and Good luck

Acidmanic