import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angproject';

  //variable

  username:string="Ajay";
  Age:number=43;
  hobbies:string[];
  Isture:boolean;
  tupleval:[string,number,boolean];
  dynamicvalue:any;

  constructor()
  {
    this.hobbies=["playing","singing"];
    this.Isture=false;
    this.tupleval=["sai",23,true];
    this.dynamicvalue="hi";

  }
}
