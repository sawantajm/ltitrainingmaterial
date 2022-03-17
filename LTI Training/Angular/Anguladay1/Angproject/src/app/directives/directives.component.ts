import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directives',
  templateUrl: './directives.component.html',
  styleUrls: ['./directives.component.css']
})
export class DirectivesComponent implements OnInit {

  constructor() { }
  employee:any=[]=[{"name":"sai","age":22,"dept":"HR"},
{"name":"Hari","age":23,"dept":"Finanace"},
{"name":"Aru","age":24,"dept":"Finance"},
{"name":"Banu","age":27,"dept":"Devlopment"}]

  ngOnInit(): void {
  }

}
