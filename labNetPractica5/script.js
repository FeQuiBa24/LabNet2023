let randomNumber = parseInt(Math.random()*21);

let scorePoints = 20;
let highScorePoints = 20;

let score = document.querySelector(".score");
let highScore = document.querySelector(".highScore");
let numberInput;
let winnerButton;
let winnerH1;
let button = document.querySelector("button");
let span = document.querySelector("span");

function create(e) {
    document.querySelector(".acierto").appendChild(document.createElement(e))    
}

function borrar(e) {
    document.querySelector(e).remove();
}


button.addEventListener("click", ()=>{
    numberInput = document.querySelector("#numberInput").value;
    if(parseFloat(numberInput)==parseInt(numberInput)){
        if(randomNumber==numberInput){
            button.disabled=true;
            span.innerHTML=`<span></span>`;
            scorePoints++;
            create("h1");
            winnerH1 = document.querySelectorAll("h1")[1];
            winnerH1.textContent="¡HAS ACERTADO!";
            winnerH1.classList.add("winnerH1");
            create("button");
            winnerButton=document.querySelectorAll("button")[1];
            winnerButton.classList.add("winnerButton");
            winnerButton.textContent='Volver a jugar';
            winnerButton.addEventListener("click",()=>{
                button.disabled=false;
                randomNumber = parseInt(Math.random()*21);
                borrar(".winnerButton");
                borrar(".winnerH1");
            })
        }
        else{
            numberInput>randomNumber ? span.innerHTML=`<span>Muy alto</span>` : span.innerHTML=`<span>Muy bajo</span>`;
            scorePoints--;
        }
        score.innerHTML=`<h3>Score: ${scorePoints}</h3>`;
        if(scorePoints>highScorePoints){
            highScorePoints=scorePoints;
            highScore.innerHTML=`<h3>High Score: ${highScorePoints}</h3>`;}
    }
    else{span.innerHTML=`<span>Debes ingresar un numero entero</span>`};
});


