# collatz

the collatz conjecture theorizes that using the following formula,

```
if N is even, divide it by 2

if N is odd, multiply it by 3 and add one

repeat on the new value of N
```

N should always end up at 1, in which case it will follow the 4, 2, 1, 4, 2, 1 loop. there has been no official proof that this is always the case, however, all numbers up to an arbirtrarily large amount have been tested and did eventually return to 1.

this program runs the formula on every number, starting with one, with varying levels of output. the fastest of course being no output (console writelines are slow). it has no real purpose, as on any regular computer it takes hours to reach "just" 1 billion, but its cool.
