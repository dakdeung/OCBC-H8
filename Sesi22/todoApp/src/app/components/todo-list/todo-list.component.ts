import { Component, OnInit } from '@angular/core';
import { Todo } from 'src/app/models/todo';


@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  isEditable= false;
  inputTodo: string = "";
  todos:Todo[]=[];

  constructor() { }

  ngOnInit(): void {
    this.todos = [
      {
        context: "First todo",
        completed: false,
        edited: false
      },
      {
        context: "Second todo",
        completed: false,
        edited:false
      }
    ]
  }

  toggleDone(id:number){
    this.todos.map((v,i) => {
      if(i == id) v.completed = !v.completed;
      return v;
    })
  }

  deleteTodo(id:number){
    this.todos = this.todos.filter((v, i) => i !== id);
  }

  addTodo(todo: Todo) {
    this.todos.push(todo);
  }

  onEditable(id:number){
    this.todos.map((v,i) => {
      if(i == id) {
        v.edited = !v.edited;
        this.inputTodo = v.context;
      }
      return v;
    })
  }

  onSaved(id:number){
    this.todos.map((v,i) => {
      if(i == id) {
        v.edited = !v.edited;
        v.context = this.inputTodo;
      }
      return v;
    })
  }

}
