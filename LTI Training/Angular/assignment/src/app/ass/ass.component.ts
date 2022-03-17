import { Component, OnInit,Output,Input,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-ass',
  template:'<div><form>Name:<input type="text" #name />Age:<input type="number" #age/> <button (click)="sendtoparentdata(name)" (click)="sendtoparentdata(age)"> send data</button></form>',
          
  styleUrls: ['./ass.component.css']
})
export class AssComponent implements OnInit {

  constructor() { }

name:string="Ajinath";
age:any=20;


  @Output()  output1=new EventEmitter<string>();
  @Output() output2=new EventEmitter<any>();
  sendtoparentdata(input:HTMLInputElement)
  {
    debugger;
    this.output1.emit(input.value);
    console.log(this.output1);
    //this.output2.emit(input.value);
    //console.log(this.output2);

  }




  ngOnInit(): void {
  }

}
