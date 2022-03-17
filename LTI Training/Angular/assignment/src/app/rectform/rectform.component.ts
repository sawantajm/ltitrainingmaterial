import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder,FormGroup } from '@angular/forms';
import { } from '@angular/core';

@Component({
  selector: 'app-rectform',
  template: `<app-ass></app-ass>`,
  styleUrls: ['./rectform.component.css']
})
export class RectformComponent implements OnInit {

  constructor(private fb:FormBuilder) { }

  ngOnInit(): void {
  }
registration=this.fb.group({username:['',RectformComponent.charonly]});
  

items=[];
  mychildname?:string;
  age?:number;
recivedata(info:any)
{
  console.log(info);
  this.mychildname=info;
  
}


static charonly(control:AbstractControl)
  {
    let pattern=/^[a-zA-Z]+$/;
    if(!control.value.match(pattern))
    {
      return {'CustomValidation':true}
    }
    return null;
  }

}
