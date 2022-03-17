import { Component, OnInit } from '@angular/core';
import { Department } from '../Module/department.model';

@Component({
  selector: 'app-pipeseg',
  templateUrl: './pipeseg.component.html',
  styleUrls: ['./pipeseg.component.css']
})
export class PipesegComponent implements OnInit {

  constructor() { }

  title:string="welcome to learn Pipes";
  public ammount?:number;
  public todaydate?:Date;
  public stext:any;


  ngOnInit(): void {
    this.todaydate=new Date();
    this.ammount=100;
  }
  dept:Department[]=[
    {did:101,dname:"Ux",location:"Chennai"},
    {did:102,dname:"finance",location:"mumbai"},
    {did:103,dname:"AI",location:"Mumbai"},
    {did:104,dname:"HR",location:"chennai"}]

}
