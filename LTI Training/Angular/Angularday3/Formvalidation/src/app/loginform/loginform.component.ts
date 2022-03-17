import { Component, OnInit } from '@angular/core';
import{FormGroup,FormControl}from '@angular/forms';
import { NgForm } from '@angular/forms';
@Component({
  selector: 'app-loginform',
  templateUrl: './loginform.component.html',
  styleUrls: ['./loginform.component.css']
})
export class LoginformComponent implements OnInit {

  constructor() { }

  username?:string;
  pwd?:string;
  ngOnInit(): void {
  }
dologin(lform:NgForm)
{
 console.log(this.username);
 console.log(this.pwd);
 console.log(lform.value);

}
 
  
}
