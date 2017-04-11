Changelog for RTA-TB
====================

v0.5.1 (2017-04-11):

* (GitHub issue #6) Undoing a split made using the regular split key (rather
  than by using the plugin) will now correctly restore the proper time.

v0.5 (2017-03-25):

* Timing in this version has been given a major overhaul. The component now uses
  Game Time to measure RTA-TB, rather than Real Time (which reverts back to
  being pure RTA in this release). Any Best Segment times (gold splits) that
  were achieved in v0.1 are now invalid for Real Time; you will need to move
  these to the "Game Time" tab in the Edit Splits dialog. There are no more
  major timing changes planned.

* (GitHub issue #2) Timing is now much more accurate in this version. v0.1 used
  a substandard method of determining when to resume the timer; this version
  uses LiveSplit's internal timing functionality, and uses techniques to improve
  accuracy as much as reasonably possible.

* (GitHub issue #1) Undoing splits is now possible in this release. Undoing a
  split will now correctly restore the time that was lost when pausing, even if
  the split is undone in the middle of a pause.

v0.1 (2017-03-22):

* Extremely rough proof-of-concept release to demonstrate how an RTA-TB
  component might work. Although a public release, usage of this version is
  discouraged as there are a number of bugs.
