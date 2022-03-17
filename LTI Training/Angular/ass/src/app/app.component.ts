import { Component,Input,Output,EventEmitter } from '@angular/core';

@Component({
  selector: '(output1)="recivedata($event)',
  template: 'Name:<input type="text" #name />Age:<input type="number" #age/> <button (click)="sendtoparentdata(name)" (click)="sendtoparentdata(age)"> send data</button>',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ass';

  
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
  mychildname?:string;
  age?:number;
recivedata(info:any)
{
  console.log(info);
  this.mychildname=info;
  
}
}
