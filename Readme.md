NFluent.DynamicTeDD
===================

NFluent.DynamicTeDD is a R# plugin that makes your TDD workflow more fluent than ever.

Here is the new TDD workflow with DynamicTeDD:

1. You start writing your test with a ('modeling clay') dynamic variable (with a dynamic, you can add it any method/property you need on-the-fly, without breaking the build) - __RED__
2. You *Alt-Enter* within the test method scope, and the plugin proposes you to replace your dynamic variable with a classical and non-dynamic skeleton class - still __RED__
3. You fill the skeleton with code providing the behavior specified by the test - __GREEN__

