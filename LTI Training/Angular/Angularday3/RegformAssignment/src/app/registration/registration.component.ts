import { Component, OnInit } from '@angular/core';
import { FormBuilder,AbstractControl,Validator } from '@angular/forms';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private fb:FormBuilder) { }

  ngOnInit(): void {
  }

   registration=this.fb.group({
     name:[''],
     password:['',this.passwordValidator],
     confirmpass:[''],
     email:[''],
     male:[''],
     female:[''],
     adhar:[''],
     driving:[''],
     pan:['']


   });
   passwordValidator(control:AbstractControl):{[key:string]:boolean}|null
   {
     //debugger;
    if(control.value!==undefined && (isNaN(control.value)||control.value=="/^[a-zA-Z0-9!@#\$%\^\&*_=+-]{8,12}$/g"))
    {
      return{'password':true}

    }
    return null;
   }
  
  

}
