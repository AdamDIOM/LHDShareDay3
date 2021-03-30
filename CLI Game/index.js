console.log("Console Quiz Game!")

function play(){
    firstnumbers = [];
    secondnumbers = [];
    for(i = 0; i < 10; i++) {
        firstnumbers.push(Math.floor((Math.random()*12)));
        console.log(firstnumbers[i]);
        secondnumbers.push(Math.floor((Math.random()*12)));
        console.log(secondnumbers[i]);
    }

    for(i = 0; i < 10; i++) {
        answer = prompt(`What is ${firstnumbers[i]} + ${secondnumbers[i]}?`)
        if(answer == firstnumbers[i] + secondnumbers[i]) {
            console.log("Correct!")
        }
        else{
            console.log(`Incorrect! Correct answer is ${firstnumbers[i] + secondnumbers[i]}`);
        }
    }

}
