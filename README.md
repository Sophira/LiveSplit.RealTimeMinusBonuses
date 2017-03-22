==Real Time Minus Bonuses component for LiveSplit==

**WARNING: Please do not solely rely on this component for real timing yet! It's
currently only a proof-of-concept, is likely to be buggy, has not been tested
properly, and has no support for any game except Sonic the Hedgehog 3 and games
based on it (S&K, S3&K) that are run on an NTSC console.**

This component allows games that are traditionally run with Game Time (due to
score bonus countdowns that take a variable amount of time to complete) to be
run in Real Time by automatically pausing the game timer based on entered
in-game times.

This component works similarly to the Manual Game Timer component included with
LiveSplit (and in fact this component is based on that one), but instead of
using the entered time to record your splits, it pauses the in-game timer for a
certain amount of time.

This component is being developed for the classic Sonic speedrunning community,
but is currently in a very early state. In later releases this component will
allow you to create your own profiles for various games, but for now it
hardcodes the time bonuses for one game engine (Sonic 3, NTSC) only. (PAL is not
yet supported; it uses a slower frame rate which affects the time the countdowns
take.)

Sonic & Knuckles and Sonic 3 & Knuckles use the same time bonus rules as Sonic
3, and as such can be run with this component.

This component is likely to be buggy and has not yet been properly tested.
Please don't rely solely on this component for an actual run! Instead, please
verify that the times are correct before submitting any runs.

Feedback on this component would be very, very helpful - as stated above, this
hasn't been properly tested. Please [check the Issues
list](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/issues) before
filing a bug to make sure it hasn't already been filed.

I'm also available as @Sophira on the Sonic speedrunning Discord, if you want to
talk there!
