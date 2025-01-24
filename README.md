# F# Mutability and Function Arguments

This example demonstrates a common issue in F# related to mutability and how function arguments are handled.  The `add` function uses the values of `x` and `y` at the time the function is called, not their values at the moment the result is used.  This can lead to unexpected results if the variables are modified after the function call but before the result is used.

## Bug
The initial values of x and y are used in the `add` function. After `add` is called, x and y are updated. However, the output reflects the initial, not updated values of x and y.

## Solution
The solution involves either passing the current values of x and y directly to the `add` function or recalculating the sum after the values have been modified.  Immutability, where values are not changed after declaration, is generally preferred in F# for clearer code.