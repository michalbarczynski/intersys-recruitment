function optionalPow(a, b) {
    if (a == b) {
        return console.log(a ** a);
    } 
    
    if (confirm(`Press OK to confirm the calculation with the given data. 
    Press Cancel to swap the base with the exponent.`) == true) {
        return console.log(a ** b);
    } else {
        return console.log(b ** a); 
    }
}

