# Confusions

When I switch between languages, I sometimes get confused by apparently similar language features. This is a place for me to collect and
understand them, and also so I can refer back to them in the future.

# the "yield" keyword

Technically, I first encountered this keyword in [Scala](./yield/scala/README.md) but didn't make any heavy use of it. Some time after,
I was reading a lot of [C#](./yield/csharp/README.md) code which used it in 'interesting' ways. I then indirectly encountered it via generators
in [Python](./yield/python3/README.md), which is where my confusion of the different meanings in different languages really took hold.

In Scala, "yield" is [pure syntactic sugar for operations on collections](http://docs.scala-lang.org/tutorials/FAQ/yield.html). In my simple usage
([yield some strings by iterating over some integers, updating a counter as a side-effect](./yield/scala/src/Main.scala)) the semantics then boil down to eagerly applying `map` over a collection and then saving the output. Iterating over this multiple times produces the same answer every time.

In the context of this example, I had thought C# and Scala would be the same, but apparently not. Yes, yield is still converted by the compiler
into something else, but what it converts it to is a little state machine. The upshot of this is that the `X` part of `yield return X` is
re-evaluated every time the strings are iterated over. The impact in my toy example is pretty minor but there can also be some [pretty weird
knock-on effects](http://www.daedtech.com/getting-too-cute-with-c-yield-return/). However, regardless of this, as long as you didn't take advantage
of or rely on any side-effects, the output would look the same: strings, iterated twice-over, show same results each time.

So, enter [Python](./yield/python3/README.md), and why I wrote up this confusion. In Python, "yield" is actually closer to a C# [IO Stream](https://msdn.microsoft.com/en-us/library/system.io.stream(v=vs.110).aspx) or a [Reactive Observable](https://msdn.microsoft.com/en-us/library/system.reactive.linq.observable(v=vs.103).aspx), in that the values yielded are consumed.

Debugging of other peoples code is typically where I find the semantics problematic i.e. when you evaluate the generator, the values get consumed, and you're left wondering why the code has changed behaviour. Second in terms of frequency of head-banging is re-using the same 'collection' twice, since here you're left with an empty collection, and nothing to iterate over.

Conclusions? I'm too much of a newbie to Python to say its "yield" semantics are a bad thing, but they definitely need to be understood. In C#, as long as you stay away from relying too much on the exact evaluation order, you can use `yield` fairly safely as a shortcut syntax for a lazily evaluated collection. In Scala? Well, it seems pretty safe to use it anywhere, but I don't have much call to use Scala nowadays; I'll leave you to draw your own conclusions from that :-)


