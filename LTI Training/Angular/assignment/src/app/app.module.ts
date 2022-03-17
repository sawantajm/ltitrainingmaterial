import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AssComponent } from './ass/ass.component';
import { RectformComponent } from './rectform/rectform.component';

@NgModule({
  declarations: [
    AppComponent,
    AssComponent,
    RectformComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
