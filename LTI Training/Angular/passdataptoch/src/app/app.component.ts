import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'passdataptoch';
  username:string='i am data from parent component:sai-parent';


  //reciveiving from child
  mychildname:any;
  recievedata(info: any)
  {
    this.mychildname=info;
    console.log(info);

  }
  //example2
  myhobby:string="";
  recievehobby(hobbyname:string)
  {
    console.log(hobbyname);
    this.myhobby=hobbyname;

  }
}
