function processData(input) {
    //Enter your code here
    var n = parseInt(input);
    console.log(fibonacci(input));
} 

function fibonacci(n) {

    if(n < 2) {
        return(n);
    }
    
    return (fibonacci(n-1) + fibonacci(n-2));
}