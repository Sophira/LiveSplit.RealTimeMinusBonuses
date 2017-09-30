Real Time Minus Bonuses v0.7.1 for LiveSplit [RTA-TB]
=====================================================

**Binary Download (latest version):** [LiveSplit.RealTimeMinusBonuses.dll](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/raw/master/Components/LiveSplit.RealTimeMinusBonuses.dll)

Place this DLL in the 'Components' directory of LiveSplit. You will find the new
component in the **Control** category when adding it to your layout.

This component allows games that are traditionally run with Game Time (due to
score bonus countdowns that take a variable amount of time to complete) to be
run in Real Time by automatically pausing the game timer based on entered
in-game times.

This component works similarly to the Manual Game Timer component included with
LiveSplit (and in fact this component is based on that one), but instead of
using the entered time to record your splits, it pauses the in-game timer for a
certain amount of time.

How to Use
----------

To use this component, simply add it to your layout - you'll find it in the
"Control" category. You will want to choose to compare to "Game Time" instead of
"Real Time"; you can do this by right-clicking on the LiveSplit window and
choosing "Compare Against"->"Game Time" from the menu.

While a run is in progress, depending on your settings, a window with a text box
will appear so that you can enter either your in-game time (default) or the
poins bonus score at the end of a level; if entering a time, you can enter this
as either a colon-separated time (eg. "1:05" for 1 minutes 5 seconds), or enter
the value in seconds (eg. "65").

Upon hitting RETURN, a split will be performed and the Game Time timer will be
paused for the appropriate length of time. (The Real Time timer will continue
running, so that you can measure a pure RTA time if you want.) You do not need
to split separately as the component will do this automatically for you upon
hitting RETURN.

If you do not need to pause when splitting, you may either use your regular
split key (if hotkeys are global) or simply press RETURN while the text box is
blank.

**Note:** There is currently no way to skip splits while still pausing the
  timer, and this is the main reason why the plugin is not numbered as version
  1.0. This is [issue #7](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/issues/7)
  in the GitHub issues list and will be added in a future release.

You may wish to show both Real Time and Game Time splits in your layout for
verification purposes.

Settings
--------

The component has several settings which can be accessed from the Edit Layout
window by clicking the "Layout Settings" button, then clicking the "Real Time
Minus Bonus [RTA-TB]" tab. The default settings are chosen to be suitable for
running Sonic 3 and games based on the Sonic 3 engine (Sonic & Knuckles, Sonic 3
& Knuckles).

**PLEASE NOTE:** The settings here are saved with your layout. This means that
  you will need separate layouts for each game you choose to run, if they use
  different RTA-TB settings. I apologise for the inconvenience - I'm looking
  into ways to make this a bit easier.

The settings available are:

* Input Method: You can choose to either enter the in-game time at the end of a
   level and let the component work out your points bonus automatically using a
   lookup table, or manually enter your points bonus. Depending on which you
   choose, certain settings will be enabled or disabled.

   The default is to enter in-game time.

* Countdown Speed: Here you can tell the component how your game counts down the
   time bonus. The "Points per frame" setting signifies how many points the game
   counts down each frame, and the "Frames per second" setting signifies how
   many frames occur in a second.

   Please note that these settings directly affect the amount of time removed
   during a run, which **will affect your final time**. Therefore, if you submit
   your runs to a leaderboard, please check the leaderboard rules before your
   run to see if they list specific values to use. (In particular, the FPS
   setting will differ depending on a number of factors, including whether you
   run on console or emulator, which emulator is used, etc.)

   The default values are 100 points per frame and 59.9228 frames per second.
   (This value matches the frame rate of the Genesis and Sega Master System.)

* Points Entry options: Only one setting is available at the moment, "Multiply
   entered values by". This allows you to save on typing when inputting points
   bonuses directly; for example, if the game needs to count down 50000 points
   but the "Multiply entered values by" setting is set to 1000, then you need
   only enter "50" during a run.

   The default value for this setting is 1, which will leave your points entry
   unchanged.

* IGT Lookup Table: If you choose to enter in-game times, then this is where you
   tell the component how to calculate the points bonus from the entered time.
   Note that the "Maximum IGT" value represents an exclusive upper bound;
   entering the value 60 will cause that row to apply for times entered *below*
   60 seconds, but not for 60 seconds exactly. The lower bound for each row is
   set by the next lowest "Maximum IGT" value.

   The default IGT Lookup table corresponds to the times used by Sonic 3. (The
   entry for 600s is not a typo; if you get an in-game time of 9:59 for a level
   in Sonic 3, the game gives you 100,000 points.)

About the Component
-------------------

This component was initially developed for the classic Sonic speedrunning
community, but can be used for other games by adjusting the settings.

Times should always be verified when using components that manipulate the timer,
and this component is no exception. This component aims to be frame-accurate,
but some extremely minor timing issues do still remain which may result in the
final time being a frame or two off. If the game you are running is quick or
contested enough to have its times measured in frames, you should be aware of
this and verify the time recorded by the plugin.
(See [issue #8](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/issues/8)
for more information.)

I am not a Sonic speedrunner myself, but the plugin has by now been tested by
several people and I am pretty confident that it is accurate (excepting the
issue linked above). Still, problems can occur; if you find that a time recorded
by the plugin is incorrect, or there are any other bugs - or even if you just
want to give feedback - please do get in touch! That said, before filing a bug,
please [check the Issues list](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/issues)
to make sure that your bug hasn't already been reported.

For a list of changes in this component over time, see the "CHANGES.md" file, or
view the commit log on GitHub:

https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/commits

I'm also available as @Sophira on the Sonic speedrunning Discord, if you want to
talk there!
