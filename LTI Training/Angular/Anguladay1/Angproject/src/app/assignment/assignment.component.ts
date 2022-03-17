import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  styleUrls: ['./assignment.component.css']
})
export class AssignmentComponent implements OnInit {

  constructor() { }
student: any[]=[{"sname":"Ajay","Roll_no":1,"marks":90},
{"sname":"Sham","Roll_no":2,"marks":80},
{"sname":"Ram","Roll_no":3,"marks":60}]

  ngOnInit(): void {
  }

}
