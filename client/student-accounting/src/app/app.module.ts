import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material/material.module';
import { NavbarComponent } from './components/navbar/navbar.component';
import { StudentComponent } from './components/student/student.component';
import { GroupComponent } from './components/group/group.component';

import { ReactiveFormsModule } from '@angular/forms';
import { CreateStudentComponent } from './components/forms/student/create-student/create-student.component';
import { CreateGroupComponent } from './components/forms/group/create-group/create-group.component';
import { EditGroupComponent } from './components/forms/group/edit-group/edit-group.component';
import { EditStudentComponent } from './components/forms/student/edit-student/edit-student.component';
import { StudentListComponent } from './components/student-list/student-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    StudentComponent,
    GroupComponent,
    CreateStudentComponent,
    CreateGroupComponent,
    EditGroupComponent,
    EditStudentComponent,
    StudentListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
