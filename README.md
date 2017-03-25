Real Time Minus Bonuses v0.5 for LiveSplit [RTA-TB]
===================================================

**Binary Download (latest version):** [LiveSplit.RealTimeMinusBonuses.dll](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/blob/master/Components/LiveSplit.RealTimeMinusBonuses.dll)

**This component currently only supports Sonic the Hedgehog 3 and games based on
it (S&K, S3&K) that are run on an NTSC console.**

This component allows games that are traditionally run with Game Time (due to
score bonus countdowns that take a variable amount of time to complete) to be
run in Real Time by automatically pausing the game timer based on entered
in-game times.

This component works similarly to the Manual Game Timer component included with
LiveSplit (and in fact this component is based on that one), but instead of
using the entered time to record your splits, it pauses the in-game timer for a
certain amount of time.

This component is being developed for the classic Sonic speedrunning community,
and while it is still very limited, I feel it is good and accurate enough to use
for runs. In later releases this component will allow you to create your own
profiles for various games, but for now it hardcodes the time bonuses for one
game engine (Sonic 3, NTSC) only. (PAL is not yet supported; it uses a slower
frame rate which affects the time the countdowns take.)

Sonic & Knuckles and Sonic 3 & Knuckles use the same time bonus rules as Sonic
3, and as such can be run with this component.

As always, times should be verified when using components that manipulate the
timer. While I believe this component is highly accurate and suitable for use,
I am not a Sonic runner. Please verify that the times recorded are correct. (If
you do this, please let me know your results by getting in touch with me on
Discord, or by opening a issue on GitHub with the "feedback" label.)

In fact, any feedback on this component would be very, very helpful - as stated
above, I'm not a runner and I may have missed some issues. Please [check the
Issues list](https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/issues)
before filing a bug to make sure it hasn't already been filed.

For a list of changes in this component over time, see the "CHANGES.md" file, or
view the commit log on GitHub:

https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/commits

I'm also available as @Sophira on the Sonic speedrunning Discord, if you want to
talk there!
