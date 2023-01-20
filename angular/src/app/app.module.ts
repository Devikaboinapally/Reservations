import { NgModule } from '@angular/core';
import {  FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialogModule } from '@angular/material/dialog';
import { MatTableModule } from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { DeleteComponent } from './login/delete/delete.component';
import { AddComponent } from './login/add/add.component';
import { EditComponent } from './login/edit/edit.component';
import { ResComponent } from './res/res.component';
import { MatNativeDateModule } from '@angular/material/core';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import {MatInputModule } from '@angular/material/input';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AddComponent,
    EditComponent,
    DeleteComponent,
    ResComponent,
    
    
  ],
  imports: [
    BrowserModule,
    MatSortModule,
    MatPaginatorModule,
    MatToolbarModule,
    MatAutocompleteModule,
    MatDatepickerModule,
    MatIconModule,
    MatFormFieldModule,
    MatSelectModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatDialogModule,
    MatTableModule,
    HttpClientModule,
    MatNativeDateModule,
    MatInputModule
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
