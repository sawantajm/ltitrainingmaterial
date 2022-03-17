import { NgModule } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationFormComponent } from './registration-form/registration-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginformComponent } from './loginform/loginform.component';

import { FormsModule } from '@angular/forms';
import { HomepageComponent } from './homepage/homepage.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { productService } from './Services/product.service';
import { ProductdetailsComponent } from './productdetails/productdetails.component';
// import { ApidataComponent } from './apidata/apidata.component';
//import{ApiService} from './Services/Api.service';
import { HttpClient  } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    RegistrationFormComponent,
    LoginformComponent,
    HomepageComponent,
    PagenotfoundComponent,
    
    
    ProductdetailsComponent,
           //   ApidataComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClient

    

    

  ],
  providers: [productService],
  bootstrap: [AppComponent]
})
export class AppModule { }
