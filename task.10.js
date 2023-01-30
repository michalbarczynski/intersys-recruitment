function fixage (arr) {
    
    for (let i = 0; i < arr.length; i++) {
        if (arr[i]> 100 || arr[i] < 0) {
            return console.log('Error: pass the numbers between 0 and 100');
        }
    }
    let result = arr.filter(element => element >= 18 && element <= 60).join(',');

    if (result.length == 0) {
        return console.log('NA');
    } else {
        return console.log(result);
    }
}
