Changelog for RTA-TB
====================

v0.7.1 (2017-08-04):

* It has been pointed out that the default FPS value of 59.94Hz is not quite
  correct for running Sonic 3 on the Sega Genesis. A new radio button has been
  added for 59.9228Hz and this is now the new default. This will not affect
  layouts that have already been saved.

v0.7 (2017-08-04):

* (GitHub issue #5) When entering points bonuses, a new setting now exists to
  multiply all entered points values during a run by a certain number, such as
  1000. This can cut down on typing significantly during a run.

* The FPS setting has a new radio button for "60 (PC)".

* The IGT/points entry window will now visually show if an entered value is
  invalid by changing the colour of the text box. (Internally, this works by
  changing the colour whenever an error occurs, which is normally due to user
  input.)

* Resizing the IGT/points entry window will now correctly resize the text box as
  well.

v0.6 (2017-06-23, private beta):

* (GitHub issue #4) The component now features adjustable settings from the
  "Layout Settings" button, allowing it to support games other than Sonic 3. The
  input method, countdown speed and IGT lookup table are now all customisable
  and are saved with the layout.

* (GitHub issue #5) As stated above, one of the new settings is the input
  method; you can select between IGT input and points input. The points input
  interface is still very bare-bones, but it works.

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
