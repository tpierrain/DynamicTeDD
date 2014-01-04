DynamicTeDD
===================

DynamicTeDD is a R# plugin that makes your .NET TDD workflow more fluent than ever. Indeed, with DynamicTeDD:

1. You start writing a test with a temporary (*'modeling clay'*) dynamic variable subject (dynamic types supporting the on-the-fly addition of any method/property) - __RED, but without breaking the IDE build, nor leaving the test scope__
2. Once your test is fully written (including the __[NFluent Check](http://www.n-fluent.net)__), you *Alt-Enter* within the test method scope, and the plugin proposes you to replace your dynamic variable with a classical and non-dynamic skeleton class instance - still __RED__
3. You fill the skeleton with code providing the behavior specified by the test - __GREEN__ and then __REFACTOR__

Disclaimer:
-----------
DynamicTeDD is only at the beginning and not even an alpha version today. To be followed then...


- - -
This workflow is directly inspired by the one imagined by __[Rui CARVALHO](https://twitter.com/rhwy)__ and exposed during an __[french ALT.NET meetup](http://www.meetup.com/altnetfr/events/153888012/)__, but also in his __[Dynamic TDD](http://www.codedistillers.com/rui/2013/12/23/dynamic-tdd/)__ post.


