//console.log('Hey, There, Tiger!');

// create the input element
let inputElem = document.createElement("input");
//add the element to the body
document.body.appendChild(inputElem);

// create the submit element
let submitTodo = document.createElement("button");
//add the element to the body
document.body.appendChild(submitTodo);
submitTodo.innerText = "Submit A New Todo!";

document.write("<br>");


//input field for new title
let inputListTitle = document.createElement("input");
//add the element to the body
document.body.appendChild(inputListTitle);

//submit title button
let submitTitle = document.createElement("button");
//add the element to the body
document.body.appendChild(submitTitle);
submitTitle.innerText = "New Title!";

//changes title text
submitTitle.addEventListener('click', (e) => {
  let newTitle = inputListTitle.value;
  title.innerText = newTitle;
});

inputListTitle.addEventListener('keypress', (e) => {
  if (e.key === 'Enter'){
    let newTitle = inputListTitle.value;
    title.innerText = newTitle;
    inputListTitle.value = "";
    inputListTitle.focus();
  }
});

// create the title element for the list
let title = document.createElement("h1");
//add the element to the body
document.body.appendChild(title);
//let markymark = 'markymark';
//title.innerText = `Your Todos! ${markymark}`;
title.innerText = `Your Todos!`;

let todoList = document.createElement("ul");
document.body.appendChild(todoList); // this is the same as .innerHTML.
let mar = "it's mark!";
todoList.innerHTML = `<li>This is the first ${mar} item</li>`;
todoList.innerHTML += `<li class="hoverDemo">This is the first second item</li>`;

// you can target the ordered list.
//let myUl = document.querySelector('ul');// this is getting another access to that <ul>.it is uneeded
todoList.classList.add("ulClass");

// create the eventlistener to do the things with the content of hte input box.
submitTodo.addEventListener("click", (e) => {
  let newTodo = inputElem.value;
//blank field check
  if (newTodo == "") {
    alert("The Field is empty!");
    
    return false;
  }
//Maxlength check
  if (newTodo.length > 24) {
    alert("You have entered too many characters!");
    inputElem.value = "";
    inputElem.focus();
    return false;
  }

  console.log(newTodo);
  let myLi = document.createElement("li");
  myLi.innerText = `${newTodo}`;
  todoList.appendChild(myLi);
  inputElem.value = "";
  inputElem.focus();
});

//targets enter key
inputElem.addEventListener("keyup", (e) => {  
  if (e.key === 'Enter'){
      let newTodo = inputElem.value;
      //blank field check
      if (newTodo == "") {
        alert("The Field is empty!");

        return false;
      }
      //Maxlength check
      if (newTodo.length > 24) {
        alert("You have entered too many characters!");
        inputElem.value = "";
        inputElem.focus();
        return false;
      }

      console.log(newTodo);
      let myLi = document.createElement("li");
      myLi.innerText = `${newTodo}`;
      todoList.appendChild(myLi);
      inputElem.value = "";
      inputElem.focus();
  }
});

/**
 * still need to delete on click of hte todo item.
 **/
document.body.addEventListener("click", (e) => {
  console.log("the body clicke event was triggered");
});

//put an event listener on the ul.
todoList.addEventListener("click", (event) => {
  //console.log(event.target);
  event.stopPropagation(); // use this to stop the emission of the event up through the hierarchy
  event.target.remove();
});




/* 
DOM Group Work:
- prevent from adding a blank todo.
- implement a character limit and alert the user that there were too many chars.
- make it so that you can simply type enter to submit the new todo.
- Add an input that allows you to change the title of the todo list. 

*/
