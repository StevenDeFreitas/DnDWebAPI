const baseURI = ""
const diceEndpoint = "/api/dice/roll"

window.onload = function onload() {
    const calcButton = document.getElementById('calcButton');
    calcButton.addEventListener("click", calculate);
}

function rollD20(numDice, numSides) {//rolls 1 d20 for attack roll, bab added later
    console.log("async function hit")
    //const attackRoll = await fetch(`${baseURI}${diceEndpoint}?numDice=1&numSides=20`)
    return fetch(`${baseURI}${diceEndpoint}?numDice=${numDice}&numSides=${numSides}`)
        .then(response => response.json())
        .then(data => alert(data.diceRolls));
}

function calculate() {
    const enemyAC = document.getElementById('en-ac').value;
    const numDice = document.getElementById('num-dice').value;
    const numSides = document.getElementById('num-sides').value;
    const bab = document.getElementById('bab').value;
    console.log("Enemy AC = " + enemyAC + " Number of dice = " + numDice +
        " Number of Sides = " + numSides + " Base Attack Bonus = " + bab);
    var diceResponse = rollD20(numDice, numSides);
    console.log(diceResponse);
}
