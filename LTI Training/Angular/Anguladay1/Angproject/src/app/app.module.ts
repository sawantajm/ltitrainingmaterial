import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DirectivesComponent } from './directives/directives.component';
import { EventhandlingComponent } from './eventhandling/eventhandling.component';
import { AssignmentComponent } from './assignment/assignment.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';

import { FormsModule } from '@angular/forms';
import { CrudComponent } from './crud/crud.component';
import { PipesegComponent } from './pipeseg/pipeseg.component';
import { DepartmentFilterPipe } from './departmentfilter';
@NgModule({
  declarations: [
    AppComponent,
    DirectivesComponent,
    EventhandlingComponent,
    AssignmentComponent,
    TwowaybindingComponent,
    
    CrudComponent,
         PipesegComponent,
        
         DepartmentFilterPipe

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
