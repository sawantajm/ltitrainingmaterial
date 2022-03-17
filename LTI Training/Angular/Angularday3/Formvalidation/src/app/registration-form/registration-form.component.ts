import { Component, OnInit } from '@angular/core';
import{FormGroup,FormControl,FormBuilder,Validators, AbstractControl} from '@angular/forms';
@Component({
  selector: 'app-registration-form',
  templateUrl: './registration-form.component.html',
  styleUrls: ['./registration-form.component.css']
})
export class RegistrationFormComponent implements OnInit {

  constructor(private fb:FormBuilder){ 
    
  }

  ngOnInit(): void {
  }
  //way1 
  //user Definesd Name FormGroup,FormControl
  /*
  registrationform=new FormGroup(
  {
    
    uname:new FormControl(),
    age:new FormControl(),
    email:new FormControl(),
    password : new FormControl(),
    Confirmpassword:new FormControl()
  }
  
  );
  */
 registrationform=this.fb.group({
   uname:['',[Validators.required,Validators.minLength(3)]],
   age:['',this.ageRangeValidator],
   email:['',[Validators.required,  Validators.email]],
   password:[''],
   confirmpassword:['']
 });
  doregister()
  {
    debugger;
    console.log(this.registrationform.value);
  }

  ageRangeValidator(control:AbstractControl):{[key:string]:boolean}|null
  {
    
      if(control.value!==undefined && (isNaN(control.value)||control.value<18||control.value>45))
      {
        return{'ageRange':true}

      }
      return null;
  }

}
