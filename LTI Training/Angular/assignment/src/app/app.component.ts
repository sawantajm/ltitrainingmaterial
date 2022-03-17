import { Component ,Input,Output,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-root',
  template: '<app-rectform></app-rectform>',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  items=[];
  mychildname?:string;
  age?:number;
recivedata(info:any)
{
  console.log(info);
  this.mychildname=info;
  
}
/*recivedata1(ingfo1:any)
{
console.log(ingfo1);
  this.age=ingfo1;

}*/

}
