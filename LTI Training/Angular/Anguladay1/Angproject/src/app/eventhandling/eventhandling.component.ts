import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventhandling',
  templateUrl: './eventhandling.component.html',
  styleUrls: ['./eventhandling.component.css']
})
export class EventhandlingComponent implements OnInit
 {
//Ex3
  likeup:number;
  likedown:number;

  //Ex4
  togglestar:boolean;
  clsName:string="glyphicon glyphicon-star-empty";
  //example5
  bonus1:number;
  b1:number;
  constructor() { 
    this.likeup=0;
    this.likedown=0;
    this.togglestar=false;
    
    this.bonus1=0;
    this.b1=0;
    

  }

  ngOnInit(): void {
  }
  welcomeMsg()
  {
    alert("Welcome All!!!");
  }
    
  fname:string='';
  displayname(username:HTMLInputElement)
  { 

    this.fname=username.value;
  }
 
  likeincrement()
  {
    this.likeup=this.likeup+1; 
    this.likedown=this.likeup;
  }
  likedecrement()
  {
    debugger;
    this.likedown=this.likedown-1;
  }
  

  ChangeStar()
  {
    debugger;
    this.togglestar=!this.togglestar;
    if(this.togglestar)
    {
      this.clsName="glyphicon glyphicon-star";
    }
    else{
      this.clsName="glyphicon glyphicon-star-empty"
    }
  }

  bonus(salary:HTMLInputElement)
  {
    
      this.bonus1=(salary.valueAsNumber)*5/100;
      this.b1=this.bonus1+salary.valueAsNumber;

  }

}
