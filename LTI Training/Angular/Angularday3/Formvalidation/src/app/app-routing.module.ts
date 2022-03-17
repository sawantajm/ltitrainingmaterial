import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginformComponent } from './loginform/loginform.component';
import { RegistrationFormComponent } from './registration-form/registration-form.component';

import { HomepageComponent } from './homepage/homepage.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { productdetails } from './Model/Product.model';
import { ProductdetailsComponent } from './productdetails/productdetails.component';






const routes: Routes = [
  
  {path:'',redirectTo:'/home',pathMatch:'full'},
  {path:"home" ,component:HomepageComponent},
  {path:'register',component:RegistrationFormComponent},
  {path:'login',component:LoginformComponent},
  {path:"product",component:ProductdetailsComponent},
  {path:'**',component:PagenotfoundComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
