NFluent.DynamicTeDD
===================

NFluent.DynamicTeDD is a R# plugin that makes your TDD workflow more fluent than ever.

Here is the TDD workflow you can have with DynamicTeDD:

1. You start writing a test with a (*'modeling clay'*) dynamic variable as the subject (dynamic types supporting the on-the-fly addition of any method/property) - __RED, but without breaking the IDE build, nor leaving the test scope__
2. Once your test is written (including the Assertion/Check), you *Alt-Enter* within the test method scope, and the plugin proposes you to replace your dynamic variable with a classical and non-dynamic skeleton class instance - still __RED__
3. You fill the skeleton with code providing the behavior specified by the test - __GREEN__

- - -
This workflow is directly inspired by the one suggested by __[Rui CARVALHO](https://twitter.com/rhwy)__ in his __[Dynamic TDD post](http://www.codedistillers.com/rui/2013/12/23/dynamic-tdd/)__

