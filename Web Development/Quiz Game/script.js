var question;
var placeholder = false;
var turn = 1;
var p1 = 0;
var p2 = 0;
var ph;
var Cheats = false
var btnClicks = 0;
var numQuesCheat = 0;



function cheatToggle(){
    if (Cheats === false) {
        Cheats = true
        document.getElementById("cheatbtn").innerHTML = "Cheat: On"
        document.getElementById("cheatbtn").style.color = "red"
    }else{
        Cheats = false
        document.getElementById("cheatbtn").innerHTML = "Cheat: Off"
        document.getElementById("cheatbtn").style.color = "Green"
    }
}
function cheat(){
    if (Cheats === true){
        if (question === "1b"){
            document.getElementById("cheating").innerHTML = "mitosis"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "2b"){
            document.getElementById("cheating").innerHTML = "interphase"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "3b"){
            document.getElementById("cheating").innerHTML = "g0"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "1vg"){
            document.getElementById("cheating").innerHTML = "minecraft"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "2vg"){
            document.getElementById("cheating").innerHTML = "roblox"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "3vg"){
            document.getElementById("cheating").innerHTML = "november 18 2012"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "1cs"){
            document.getElementById("cheating").innerHTML = "var"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "2cs"){
            document.getElementById("cheating").innerHTML = "cascading style sheets"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "3cs"){
            document.getElementById("cheating").innerHTML = "brendan eich"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "1h"){
            document.getElementById("cheating").innerHTML = "1936"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "2h"){
            document.getElementById("cheating").innerHTML = "may 29, 1453"
            numQuesCheat = numQuesCheat + 1
        }else if (question === "3h"){
            document.getElementById("cheating").innerHTML = "battle of varna, november 10, 1444"
            numQuesCheat = numQuesCheat + 1
        }

    }
}

document.addEventListener('keydown', function (event){
    if (event.key === 'Enter'){
        check()
        document.getElementById("inp").value = ""
    }
});

function givePoints(){
    if (turn === 1){
        if (ph === 1){
            p1 = p1 + 100
        }else if (ph === 2){
            p1 = p1 + 200
        }else if (ph === 3){
            p1 = p1 + 300
        }else{
            alert("A error has occurred, please try again")
        }
        document.getElementById("p1").innerHTML = p1
    }if (turn === 2){
        if (ph === 1){
            p2 = p2 + 100
        }else if (ph === 2){
            p2 = p2 + 200
        }else if (ph === 3){
            p2 = p2 + 300
        }
        document.getElementById("p2").innerHTML = p2
    }
}
function inccorect(){
    question = "none"
}

function change(){
    turn = turn+1
    if (turn === 3){
        turn=1
    }
    document.getElementById("t").innerHTML = "Who's Turn Is It? = Player " + turn
}


function q1b(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("1bbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "1b";
        ph = 1;
        document.getElementById("p").innerHTML = "What is cell division called?";
    }
}
function q2b(){
    if (placeholder === false) {
        placeholder = true;
        document.getElementById("2bbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "2b";
        ph = 2;
        document.getElementById("p").innerHTML = "What is the state where the cell grows and spends majority of its time in?";
    }
}
function q3b(){
    if (placeholder === false) {
        placeholder = true;
        document.getElementById("3bbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "3b";
        ph = 3;
        document.getElementById("p").innerHTML = "What state does the cell enter during interphase when there are not enough resourses?";
    }
}
function q1vg(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("1vgbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "1vg";
        ph = 1;
        document.getElementById("p").innerHTML = "What game is this?";
        document.getElementById("img").src = "Grass.png"
    }
}
function q2vg(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("2vgbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "2vg";
        ph = 2;
        document.getElementById("p").innerHTML = "What game is this?";
        document.getElementById("img").src = "roblox.png"
    }
}
function q3vg(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("3vgbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "3vg";
        ph = 3;
        document.getElementById("p").innerHTML = "when was minecraft made? (month day year)";
        document.getElementById("img").src = "Grass.png"
    }
}
function q1cs(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("1csbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "1cs";
        ph = 1;
        document.getElementById("p").innerHTML = "How do you declare a variable in javascript?";
    }
}
function q2cs(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("2csbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "2cs";
        ph = 2;
        document.getElementById("p").innerHTML = "What does css stand for?";
    }
}
function q3cs(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("3csbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "3cs";
        ph = 3;
        document.getElementById("p").innerHTML = "who made javascript?";
    }
}
function q1h(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("1hbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "1h";
        ph = 1;
        document.getElementById("p").innerHTML = "When Did WWII Begin?";
    }
}
function q2h(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("2hbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "2h";
        ph = 2;
        document.getElementById("p").innerHTML = "When did constantinople fall?";
    }
}
function q3h(){
    if (placeholder === false) {
        placeholder = true
        document.getElementById("3hbtn").disabled = true
        btnClicks = btnClicks + 1
        question = "3h";
        ph = 3;
        document.getElementById("p").innerHTML = "Where and when did Władysław III of Poland Die?";
    }
}





function check(){
    placeholder = false
    if (question === "1b"){
        if (document.getElementById("inp").value.toLowerCase() === "mitosis"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "2b"){
        if (document.getElementById("inp").value.toLowerCase() === "interphase"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "3b"){
        if (document.getElementById("inp").value.toLowerCase() === "g0"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "1vg"){
        if (document.getElementById("inp").value.toLowerCase() === "minecraft"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
        document.getElementById("img").src = ""
    }
    if (question === "2vg"){
        if (document.getElementById("inp").value.toLowerCase() === "roblox"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
        document.getElementById("img").src = ""
    }
    if (question === "3vg"){
        if (document.getElementById("inp").value.toLowerCase() === "november 18 2011"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
        document.getElementById("img").src = ""
    }
    if (question === "1cs"){
        if (document.getElementById("inp").value.toLowerCase() === "var"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "2cs"){
        if (document.getElementById("inp").value.toLowerCase() === "cascading style sheets"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "3cs"){
        if (document.getElementById("inp").value.toLowerCase() === "brendan eich"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "1h"){
        if (document.getElementById("inp").value.toLowerCase() === "1936"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "2h"){
        if (document.getElementById("inp").value.toLowerCase() === "may 29, 1453"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    if (question === "3h"){
        if (document.getElementById("inp").value.toLowerCase() === "battle of varna, november 10, 1444"){
            document.getElementById("p").innerHTML = "Correct"
            document.getElementById("p").style.color = "green"
            givePoints()
        }else{
            document.getElementById("p").innerHTML = "Incorrect"
            document.getElementById("p").style.color = "red"
            inccorect()
        }
    }
    document.getElementById("p").style.color = "blue"
    change()
    if (btnClicks === 12){
        if (Cheats === true){
            if (p1 > p2) {
                alert("Points: " + p1 + " You did cheat on " + numQuesCheat +  " questions Player 1 wins")
            } else if (p1 < p2) {
                alert("Points: " + p2 + " You did cheat on " + numQuesCheat +  " questions Player 2 wins")
            } else if (p1 === p2) {
                alert("Draw")
            }
        }else{
            if (p1 > p2) {
                alert("Player 1 wins with " + p1 + " Points!")
            } else if (p1 < p2) {
                alert("Player 2 wins with " + p2 + " Points!")
            } else if (p1 === p2) {
                alert("Draw!")
            }
        }
    }
}