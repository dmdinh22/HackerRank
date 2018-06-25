function factorial(n) {
    // If n = 0 OR n = 1, the factorial will return 1
    if (n === 0 || n === 1)
        return 1;
  
    // We start the FOR loop with i = 4
    // We decrement i after each iteration 
    for (var i = n - 1; i >= 1; i--) {
    // We store the value of n at each iteration
        n = n * i; // or n *= i;
    /* 
                     n           var i = n - 1       n *= i         i--       i >= 1?
    1st iteration:   5           4 = 5 - 1         20 = 5 * 4        3          yes   
    2nd iteration:  20           3 = 4 - 1         60 = 20 * 3       2          yes
    3rd iteration:  60           2 = 3 - 1        120 = 60 * 2       1          yes  
    4th iteration: 120           1 = 2 - 1        120 = 120 * 1      0          no             
    5th iteration: 120               0                120
    End of the FOR loop 
    */
    }
    return n; //120
}