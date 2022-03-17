import { Component, OnInit,Input,Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {


  //getting  data from parent to child
  @Input() inputfromparent?:string;
  

  //passing data from child to parent
  @Output() outputfromchild:EventEmitter<string>=new EventEmitter();


  outputtext:string="i am your child:Ajinath";
  constructor() { }

  ngOnInit(): void {
    console.log(this.inputfromparent);

  }

  sendatatoparent()
  {
    this.outputfromchild.emit(this.outputtext);
  }


  @Output()  sendvalue:EventEmitter<string>=new EventEmitter();

  gethobby(input:HTMLInputElement)
  {
    this.sendvalue.emit(input.value);
    console.log(this.sendvalue);
  }

}
