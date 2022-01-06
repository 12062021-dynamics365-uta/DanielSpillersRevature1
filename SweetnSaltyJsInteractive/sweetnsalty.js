let buttonElement = document.createElement("button");
let instructionsElem = document.createElement("h1");
let inputElement = document.createElement("input");
let input1Button = document.createElement("button");
let input2Button = document.createElement("button");
let resetButton = document.createElement("button");
let newPara = document.createElement("p");

let firstVal;
let lastVal;
//let lastVal = prompt("Please enter the last number for sweet n salty.");

//Instructions
document.body.appendChild(instructionsElem);
instructionsElem.innerText = "Welcome to Sweet-n- Salty";

document.body.appendChild(buttonElement);
buttonElement.innerText = "Start Here";

buttonElement.addEventListener("click", (e) => {
  instructionsElem.innerText = "Please enter a starting number";
  document.body.appendChild(inputElement);
  document.body.appendChild(input1Button);
  input1Button.innerText = "Enter";
  document.body.removeChild(buttonElement);
});

input1Button.addEventListener("click", (e) => {
  instructionsElem.innerText = "Please enter a final number";
  firstVal = inputElement.value;
  console.log(firstVal);
  inputElement.value = "";
  inputElement.focus();
  document.body.removeChild(input1Button);
  document.body.appendChild(input2Button);
  input2Button.innerHTML = "Enter";
});

input2Button.addEventListener("click", (e) => {
  instructionsElem.innerText = "Please enter a final number";
  lastVal = inputElement.value;
  console.log(lastVal);
  document.body.removeChild(inputElement);
  document.body.removeChild(input2Button);
  EvaluateStartingNumber(firstVal, lastVal);
  EvaluateNegativeNumbers(firstVal, lastVal);
  PrintValues(firstVal, lastVal);
});

function EvaluateStartingNumber(firstVal, lastVal) {
  if (lastVal - firstVal < 200) {
    instructionsElem.innerText =
      "Please enter 2 values that have a range greater than 200.";
    location.reload();
  } else if (lastVal - firstVal > 10000) {
    alert("Please enter 2 values that have a range smaller than 10,000.");
    location.reload();
  } else if (lastVal < firstVal) {
    alert("The last value must be greater than the first value. Try Again.");
  } else {
    return;
  }
}

function EvaluateNegativeNumbers(firstVal, lastVal) {
  if (firstVal < 0 || lastVal < 0) {
    alert("Invalid number. You must return a positive number only.");
    location.reload();
  } else {
    return;
  }
}

function PrintValues(firstVal, lastVal) {
  let sweet = 0;
  let salty = 0;
  let sweetNsalty = 0;
  let myArray = new Array();
  var tempArray = new Array();

  for (let i = firstVal; i <= lastVal; i++) {
    if (i % 3 == 0 && i % 5 == 0) {
      myArray.push("<span>Sweet -n- Salty</span>");
      sweetNsalty++;
    } else if (i % 5 == 0) {
      myArray.push("<span>Salty</span>");
      salty++;
    } else if (i % 3 == 0) {
      myArray.push("<span>Sweet</span>");
      sweet++;
    } else {
      if (i < 1000) {
        myArray.push(`${i}`);
      } else {
        myArray.push(`${i.toLocaleString()}`);
      }
    }
  }

  for (let i = 0; i < myArray.length; i++) {
    tempArray.push(myArray[i]);
    if (tempArray.length == 40) {
      newPara = document.createElement("p");
      document.body.appendChild(newPara);
      newPara.innerHTML = tempArray.toString();
      tempArray = [];
    }
  }

  instructionsElem.appendChild(resetButton);
  resetButton.innerHTML = "Reset";
  HowManySSSnS(sweet, salty, sweetNsalty);
}

function HowManySSSnS(sweet, salty, sweetNsalty) {
  newEval = document.createElement("h4");
  newEval2 = document.createElement("h4");
  newEval3 = document.createElement("h4");
  document.body.appendChild(newEval);
  document.body.appendChild(newEval2);
  document.body.appendChild(newEval3);
  newEval.innerText = `You printed sweet ${sweet} times to the screen.`;
  newEval2.innerText = `You printed sweet ${salty} times to the screen.`;
  newEval3.innerText = `You printed sweet ${sweetNsalty} times to the screen.`;
}

resetButton.addEventListener("click", (e) => {
  location.reload();
});
